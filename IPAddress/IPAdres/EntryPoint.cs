using System;

namespace IPAddress
{
    public class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string str = "a123.123.123.123ojhgf";
                var ipAddress = new IPAddress();

                Console.WriteLine(ipAddress.GetIPAddress(str));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}