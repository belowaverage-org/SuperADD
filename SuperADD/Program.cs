using System;
using System.Windows.Forms;

namespace SuperADD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            if(args.Length > 0)
            {
                foreach(string arg in args)
                {
                    if (arg.StartsWith("-?") || arg.StartsWith("/?"))
                    {
                        Application.Run(new Help(0));
                    }
                    if (arg.StartsWith("-autorunindex:") || arg.StartsWith("/autorunindex:"))
                    {
                        int index = 0;
                        if (arg.StartsWith("-"))
                        {
                            index = int.Parse(arg.Replace("-autorunindex:", ""));
                        }
                        if (arg.StartsWith("/"))
                        {
                            index = int.Parse(arg.Replace("/autorunindex:", ""));
                        }
                        Application.Run(new Main(index, true));
                    }
                    if (arg.StartsWith("-autoselectindex:") || arg.StartsWith("/autoselectindex:"))
                    {
                        int index = 0;
                        if (arg.StartsWith("-"))
                        {
                            index = int.Parse(arg.Replace("-autoselectindex:", ""));
                        }
                        if (arg.StartsWith("/"))
                        {
                            index = int.Parse(arg.Replace("/autoselectindex:", ""));
                        }
                        Application.Run(new Main(index, false));
                    }
                    if (arg.StartsWith("-dump") || arg.StartsWith("/dump"))
                    {
                        Application.Run(new Help(1));
                    }
                }
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}
