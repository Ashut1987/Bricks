using System;
using System.Collections.Generic;
using System.Text;
using Bricks.Core.Shapes;

namespace Bricks.Core
{
    public interface IView
    {
        void DisplayBoard(string arrayString, IBrick[,] brickArray, int width, int height);
        void DisplayScore(int score, int hiScore, int lines, int level, IShape next);
        void GameOver();
        void HighlightCompletedRow(int row);
    }
}
