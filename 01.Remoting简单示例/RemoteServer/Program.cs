using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Text;

namespace RemoteServer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("RemoteServer.exe.config", false);
            Console.WriteLine("服务已启动...");
            Console.ReadLine();
        }
    }
}
