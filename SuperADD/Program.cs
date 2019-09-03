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
                        MainForm = new Main(index, true);
                        Application.Run(MainForm);
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
                        MainForm = new Main(index, false);
                        Application.Run(MainForm);
                    }
                    if (arg.StartsWith("-dump") || arg.StartsWith("/dump"))
                    {
                        Application.Run(new Help(1));
                    }
                }
            }
            else
            {
                MainForm = new Main();
                Application.Run(MainForm);
            }
        }
        public static Main MainForm;
    }
}
