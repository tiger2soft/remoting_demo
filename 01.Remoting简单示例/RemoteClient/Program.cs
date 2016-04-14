using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteClient
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                RemoteObject.MyObject app = (RemoteObject.MyObject)Activator.GetObject(typeof(RemoteObject.MyObject), System.Configuration.ConfigurationManager.AppSettings["ServiceURL"]);
                int result = app.Add(1, 2);
                Console.WriteLine("1 + 2 = " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
