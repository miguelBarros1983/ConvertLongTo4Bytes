// <summary>
// This clas convert a Long to Byte[4] and the inverted
// </summary>

namespace ConsoleApp1
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Convert From Byte[4] to Long
            byte[] message = new byte[4] { 255, 255, 0, 0 };
            int low = message[0] << 8 | message[1];
            int high = message[2] << 8 | message[3];

            long driverValue = high << 16 | low;

            Console.Write(driverValue);
            Console.Read();

            //-----------------------------------------------------------------          

            // Convert From a Long to byte[4]
            driverValue = 123456789;
            int lo = (int)(driverValue & 0xffffffff);
            int hi = (int)(driverValue >> 16);

            Console.WriteLine(Convert.ToString(lo));
            Console.WriteLine(Convert.ToString(hi));

            byte[] messageResult = new byte[4] { 0, 0, 0, 0 };

            messageResult[0] = (byte)((lo >> 8) & 0xFF);
            messageResult[1] = (byte)(lo & 0xFF);
            messageResult[2] = (byte)((hi >> 8) & 0xFF);
            messageResult[3] = (byte)(hi & 0xFF);

            Console.Write(messageResult[0] + "+" + messageResult[1] + "+" + messageResult[2] + "+" + messageResult[3]);
            Console.Read();
        }
    }
}
