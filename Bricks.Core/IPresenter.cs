using System;
using System.Collections.Generic;
using System.Text;
using Bricks.Core;
using Bricks.Core.Shapes;

namespace Bricks.Core
{
    public interface IPresenter
    {
        void HighlightCompletedRow(int row);
        void UpdateBoardView(string ArrayString, IBrick[,] brickArray, int width, int height);
        void UpdateScoreView(int score, int hiScore, int lines, int level, IShape next);
        IView View { get; set; }
        int Level { get; }
        void InitializeBoard(string shape);
        void GameOver();
        void Tick();
    }
}
