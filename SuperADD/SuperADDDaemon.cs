using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;

namespace SuperADD
{
    class SuperADDDaemon
    {
        public static bool ServerStarted = false;
        private static Process Server = new Process();
        private static bool Stopping = false;
        public static Task Start()
        {
            return Task.Run(async () => {
                if (!File.Exists(@"SuperADDDaemon\php.exe"))
                {
                    await Extract();
                }
                foreach (Process proc in Process.GetProcessesByName("php"))
                {
                    if(proc.MainModule.FileName == new FileInfo(@"SuperADDDaemon\php.exe").FullName)
                    {
                        proc.Kill();
                    }
                }
                Server.StartInfo.FileName = "php.exe";
                Server.StartInfo.WorkingDirectory = "SuperADDDaemon";
                Server.StartInfo.Arguments = "-S 127.0.0.1:2234 -t Daemon";
                Server.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Server.EnableRaisingEvents = true;
                Server.Start();
                Server.Exited += Server_Exited;
                ServerStarted = true;
            });
        }
        private static void Server_Exited(object sender, EventArgs e)
        {
            if(!Stopping)
            {
                Start();
            }
        }
        public static Task Stop()
        {
            Stopping = true;
            return Task.Run(async () => {
                if(!Server.HasExited)
                {
                    Server.Kill();
                }
                await Task.Delay(100);
                ServerStarted = false;
            });
        }
        private static Task Extract()
        {
            return Task.Run(() => {
                if (Directory.Exists("SuperADDDaemon"))
                {
                    Directory.Delete("SuperADDDaemon", true);
                }
                if (File.Exists("SuperADDDaemon.zip"))
                {
                    File.Delete("SuperADDDaemon.zip");
                }
                FileStream ServerZip = File.OpenWrite("SuperADDDaemon.zip");
                ServerZip.Write(Properties.Resources.SuperADDDaemon, 0, Properties.Resources.SuperADDDaemon.Length);
                ServerZip.Close();
                ZipFile.ExtractToDirectory("SuperADDDaemon.zip", "SuperADDDaemon");
                if (File.Exists("SuperADDDaemon.zip"))
                {
                    File.Delete("SuperADDDaemon.zip");
                }
            });
        }
    }
}