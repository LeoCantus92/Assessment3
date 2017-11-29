using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            bool exitProgram = false;
            using (NamedPipeServerStream server = new NamedPipeServerStream("As3Pipe", PipeDirection.InOut))
            {
                Console.WriteLine("Server created successfully.");

                //Wait for a client to connect
                Console.Write("Waiting for client to connect...");
                server.WaitForConnection();

                Console.WriteLine("Client connected.");
                Console.WriteLine("Type Exit to close the program");
                    try
                    {
                        //Have user input text to send to the client
                        using (StreamWriter writer = new StreamWriter(server))
                        {
                            while (exitProgram == false)
                            {
                                writer.AutoFlush = true;
                                Console.Write("Enter text to send to client: ");
                                string textToSend = Console.ReadLine();
                                writer.WriteLine(textToSend);

                                if (textToSend == "Exit")
                                {
                                    exitProgram = true;
                                }
                            }
                        }
                    }
                    //Catch exception in case of disconnect
                    catch (IOException e)
                    {
                        Console.WriteLine("ERROR!: {0}", e.Message);
                        exitProgram = true;
                    }

            }
        }
    }
}