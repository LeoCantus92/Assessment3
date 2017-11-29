using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Adds num1 and num2 together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Add2Int(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Subtracts num2 from num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int SubtractInt(int num1, int num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Concatinates the two given strings into a single string with word1 coming first
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public string Concat2Strings(string word1, string word2)
        {
            return word1 + word2;
        }
        /// <summary>
        /// Checks if the given username and password are equal to the preset username and password
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool Login(string Username, string Password)
        {
            bool loginCorrect = false;
            if(Username == "User" && Password == "Pass123")
            {
                loginCorrect = true;
            }
            return loginCorrect;
        }
    }
}
