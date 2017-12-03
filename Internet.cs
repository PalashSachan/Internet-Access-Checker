/// <summary>
/// very small tool to check the internet connectivity.
/// </summary>
namespace InternetAvailablityChecker
{
    /// <summary>
    /// class to check the internet access
    /// </summary>
    class Internet
    {
        /// <summary>
        /// default variables
        /// </summary>
        static string defaultIP = "23.76.156.57";
        static int defaultTimeout = 4000;

        /// <summary>
        /// Checks the Internet access with default ip = "23.76.156.57" or "http://www.msftncsi.com/ncsi.txt" 
        /// and default timeout of 4000 Milliseconds.
        /// </summary>
        /// <seealso cref="http://www.msftncsi.com/ncsi.txt"/>
        /// <see cref=""/>
        public static bool isAvailable()
        {
            return checkIt(defaultIP, defaultTimeout);
        }

        /// <summary>
        /// Checks the Internet access with IP address and default timeout.
        /// </summary>
        /// <param name="ip">IP address to check the Internet access</param>
        public static bool isAvailable(string ip)
        {
            return checkIt(ip, defaultTimeout);
        }
        
        /// <summary>
        /// Checks the Internet access with default ip and timeout in Milliseconds.
        /// </summary>
        /// <param name="timeout">timeout to check and wait for the response</param>
        public static bool isAvailable(int timeout)
        {
            return checkIt(defaultIP, timeout);
        }

        /// <summary>
        /// Checks the Internet access with IP and Timeout in Milliseconds.
        /// </summary>
        /// <param name="ip">IP address to check the Internet access</param>
        /// <param name="timeout">timeout to check and wait for the response</param>
        public static bool isAvailable(string ip, int timeout)
        {
            return checkIt(ip, timeout);
        }

        /// <summary>
        /// Checks the Internet access with IP and Timeout in Milliseconds.
        /// </summary>
        /// <param name="ip">IP address to check the Internet access</param>
        /// <param name="timeout">timeout to check and wait for the response</param>
        private static bool checkIt(string ip, int timeout)
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send(ip, timeout).Status == System.Net.NetworkInformation.IPStatus.Success ? true : false;
            }

            catch (System.Exception)
            {
                return false;
            }
        }
    }
}