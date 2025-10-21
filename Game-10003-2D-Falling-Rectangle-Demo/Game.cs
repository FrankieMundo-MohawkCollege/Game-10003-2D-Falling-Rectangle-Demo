// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2 rectposition;
        Vector2 rectsize = new Vector2(40,60);
        Vector2 gravity = new Vector2 (0, 5000);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize (800, 600);
            Window.SetTitle ("collisuons Demo");
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            DrawMajorGridLines();
            DrawMinorGridLines();
            DrawRectangle();
        }

        void DrawMajorGridLines()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.LightGray;
            
            //Draw Vertical Lines
            for (int x = 0; x < Window.Width; x += 100)
            {
                Draw.Line (x, 0, x, Window.Height);
            }

            for (int y = 0; y < Window.Height; y += 100)
            {
                Draw.Line (0, y, Window.Width, y);
            }
        }

        void DrawMinorGridLines()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.LightGray;

            //Draw Vertical Lines
            for (int x = 0; x < Window.Width; x += 100)
            {
                Draw.Line(x, 0, x, Window.Height);
            }

            for (int y = 0; y < Window.Height; y += 100)
            {
                Draw.Line(0, y, Window.Width, y);
            }

            
        }

        void DrawRectangle()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(rectposition, rectsize);
        }
    }

}
