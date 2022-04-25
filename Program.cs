using Simulator;
using System;
using Menu_options;

namespace Coursework_Final_draft
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            

            using (var game = new Game1())
                game.Run();
        }
    }
}
