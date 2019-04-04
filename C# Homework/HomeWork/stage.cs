using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class Stage
    {
        public bool hasReachedGoal = false;

        int playerPosX = 1;
        int playerPosY = 1;

        char[,] stage = new char[,] { { '*', '*', '*', '*', '*', '*', '*', '*' },
                                      { '*', ' ', '#', ' ', ' ', ' ', ' ', '*' },
                                      { '*', ' ', '#', ' ', ' ', ' ', ' ', '*' },
                                      { '*', ' ', '#', '#', ' ', '#', ' ', '*' },
                                      { '*', ' ', ' ', '#', ' ', ' ', '#', '*' },
                                      { '*', ' ', ' ', '#', ' ', ' ', '#', '*' },
                                      { '*', ' ', ' ', ' ', ' ', ' ', 'o', '*' },
                                      { '*', '*', '*', '*', '*', '*', '*', '*' }
                                     };

        public void PlayerMoveLeft()
        {
            if(playerPosX > 0)
            {
                SetPlayPos(playerPosX - 1, playerPosY);
            }
        }

        public void PlayerMoveRight()
        {
            if(playerPosX < 7)
            {
                SetPlayPos(playerPosX + 1, playerPosY);
            }
        }

        public void PlayerMoveUp()
        {
            if (playerPosY > 0)
            {
                SetPlayPos(playerPosX, playerPosY - 1);
            }
        }

        public void PlayerMoveDown()
        {
            if (playerPosY < 7)
            {
                SetPlayPos(playerPosX, playerPosY + 1);
            }
        }

        public void SetPlayPos(int x, int y)
        {
            if(IsMovablePos(x,y))
            {
                stage[playerPosY, playerPosX] = ' ';

                playerPosX = x;
                playerPosY = y;

                if (stage[playerPosY, playerPosX] == 'o')
                {
                    hasReachedGoal = true;
                }
                stage[playerPosY, playerPosX] = 'p';
            }
        }

        public bool IsMovablePos(int x, int y)
        {
            if(stage[y,x]  == ' ' || stage[y,x] == 'o')
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public void DrawStage()
        {
            for(int y = 0; y < 8; y++)
            {
                for(int x = 0; x < 8; x++)
                {
                    Console.Write(stage[y, x]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }

            if(hasReachedGoal)
            {
                Console.WriteLine("你赢了");
            }
        }
    }
}
