using System;
using StrawberryJam.Shared;

namespace StrawberryJam.Windows
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new StrawberryGame())
                game.Run();
        }
    }
#endif
}
