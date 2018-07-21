using System;
namespace Bricks.Core
{
    interface IBricksArray
    {
        string GetStringFromShapeArray();
        void InitializeArray(string shape);
        int Height { get; }
        IBrick[,] ShapeArray { get; }
        string ShapeString { get; }
        int Width { get; }
    }
}
