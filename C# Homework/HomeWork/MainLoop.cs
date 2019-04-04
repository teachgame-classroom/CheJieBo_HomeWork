using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class MainLoop
    {
        ConsoleKeyInfo key;
        string gameTitle = "Hello Maze";
        string keyString;
        Stage stage;

        public bool isRunning = false;

        public MainLoop()
        {
            stage = new Stage();
            stage.SetPlayPos(1, 1);
        }

        public void Loop()
        {
            HandleInput();
            Update();
            Render();
        }

        public void HandleInput()
        {
            key = Console.ReadKey();
        }

        public void Update()
        {
            switch (key.Key)
            {
                case ConsoleKey.W:
                    keyString = "向上";
                    stage.PlayerMoveUp();
                    break;
                case ConsoleKey.A:
                    keyString = "向左";
                    stage.PlayerMoveLeft();
                    break;
                case ConsoleKey.S:
                    keyString = "向下";
                    stage.PlayerMoveDown();
                    break;
                case ConsoleKey.D:
                    keyString = "向右";
                    stage.PlayerMoveRight();
                    break;
                case ConsoleKey.Escape:
                    isRunning = false;
                    break;
                default:
                    break;
            }
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine(gameTitle);
            Console.WriteLine(keyString);
            stage.DrawStage();
        }
    }
}
