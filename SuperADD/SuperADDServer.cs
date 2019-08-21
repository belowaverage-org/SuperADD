using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;

namespace SuperADD
{
    class SuperADDServer
    {
        public static bool ServerStarted = false;
        private static Process Server = new Process();
        public static Task Start()
        {
            return Task.Run(async () => {
                await Extract();
                Server.StartInfo.FileName = "php.exe";
                Server.StartInfo.WorkingDirectory = "SuperADDServer";
                Server.StartInfo.Arguments = "-S 127.0.0.1:2234 -t SuperADDServer";
                Server.Start();
                ServerStarted = true;
            });
        }
        public static Task Stop()
        {
            return Task.Run(async () => {
                Server.Kill();
                await Task.Delay(100);
                await Cleanup();
                ServerStarted = false;
            });
        }
        private static Task Extract()
        {
            return Task.Run(() => {
                if (Directory.Exists("SuperADDServer"))
                {
                    Directory.Delete("SuperADDServer", true);
                }
                if (File.Exists("SuperADDServer.zip"))
                {
                    File.Delete("SuperADDServer.zip");
                }
                FileStream ServerZip = File.OpenWrite("SuperADDServer.zip");
                ServerZip.Write(Properties.Resources.SuperADDServer, 0, Properties.Resources.SuperADDServer.Length);
                ServerZip.Close();
                ZipFile.ExtractToDirectory("SuperADDServer.zip", "SuperADDServer");
                if (File.Exists("SuperADDServer.zip"))
                {
                    File.Delete("SuperADDServer.zip");
                }
            });
        }
        private static Task Cleanup()
        {
            return Task.Run(() =>
            {
                if (Directory.Exists("SuperADDServer"))
                {
                    Directory.Delete("SuperADDServer", true);
                }
            });
        }
    }
}
