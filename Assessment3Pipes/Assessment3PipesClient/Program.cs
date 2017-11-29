using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;

namespace Assessment3PipesClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            using (NamedPipeClientStream client = new NamedPipeClientStream(".", "As3Pipe", PipeDirection.In))
            {
                //Connect to the server
                Console.WriteLine("Attempting to connect to server...");
                client.Connect();

                Console.WriteLine("Connected to server.");
                Console.WriteLine("Type Exit in the server to close the program");

                using (StreamReader reader = new StreamReader(client))
                {
                    while (exitProgram == false)
                    {
                        //Display the text received
                        string receivedText;
                        while ((receivedText = reader.ReadLine()) != null)
                        {
                            Console.WriteLine("Text from server: " + receivedText);
                            if (receivedText == "Exit")
                            {
                                exitProgram = true;
                            }
                        }

                        
                    }
                }
            }
        }
    }
}
