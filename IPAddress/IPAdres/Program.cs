using System;

namespace IPAdres
{
    class MainClass
    {
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