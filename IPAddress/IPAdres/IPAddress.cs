using System;
using System.Text;

namespace IPAddress
{
    /// <summary>
    /// IPA ddress.
    /// </summary>
    public class IPAddress
    {
        /// <summary>
        /// Gets the IPA ddress.
        /// </summary>
        /// <returns>The IP address.</returns>
        /// <param name="str">String.</param>
        public string GetIPAddress(string str)
        {
            StringBuilder ipAddress = new StringBuilder();
            int startIndex = 0;
            int endIndex = 0;
            int countOfPoints = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    continue;
                }

                startIndex = i;

                if (countOfPoints != 3)
                {
                    endIndex = str.IndexOf('.', startIndex);
                    countOfPoints++;
                }
                else
                {
                    endIndex = startIndex;

                    while (char.IsDigit(str[endIndex]))
                    {
                        endIndex++;
                    }

                    endIndex--;
                }


                if (endIndex - startIndex > 3)
                {
                    return GetIPAddress(str.Substring(endIndex));
                }

                ipAddress.Append(str.Substring(startIndex, endIndex - startIndex + 1));
                i = endIndex;
            }

            string resultIpAddress = ipAddress.ToString();

            return IsValid(resultIpAddress) ? resultIpAddress : string.Empty;
        }


        /// <summary>
        /// Ises the valid.
        /// </summary>
        /// <returns><c>true</c>, if valid was ised, <c>false</c> otherwise.</returns>
        /// <param name="ipAddress">Ip address.</param>
        public bool IsValid (string ipAddress)
        {
            string[] numbers = ipAddress.Split('.');

            foreach (var i in numbers)
            {
                int number = Convert.ToInt32(i);

                if (number < 0 || number > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
}