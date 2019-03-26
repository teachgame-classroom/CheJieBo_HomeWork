using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLoop mainLoop = new MainLoop();
            mainLoop.isRunning = true;

            while(mainLoop.isRunning)
            {
                mainLoop.Loop();
            }
        }
    }
}
