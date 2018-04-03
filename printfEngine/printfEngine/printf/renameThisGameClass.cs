using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfObjects;
using printfEngine.printfHelpers;
using printfEngine.printf.GameClasses;

namespace printfEngine.printf
{
    class renameThisGameClass
    {
        static int frame, direction;
        /* Do Not Delete */
        public static Point characterSize = new Point(12, 12);
        public static Point screenSize = new Point(20, 20);
        public static int screenScale = 2;
        public static int framesPerSecond = 16;
        /* Do Not Delete */
        static Pac pacman;
        static Map map;
        static Point location;

        public static void Initialise() //initialise all objects here.
        {
            pacman = new Pac(new Point(10, 10));
            map = new Map();
            frame = 0;
        }
        public static void Unload()
        {
            pacman = null;
        }
        public static void Update(GameTime gameTime)
        {
            KeyboardState k = Keyboard.GetState();
            if (k.IsKeyDown(Keys.Right))
            {
                direction = 0;
            }
            else if (k.IsKeyDown(Keys.Down))
            {
                direction = 1;
            }
            else if (k.IsKeyDown(Keys.Left))
            {
                direction = 2;
            }
            else if (k.IsKeyDown(Keys.Up))
            {
                direction = 3;
            }
            
            

        }

        //use the printf.GameClasses to define objects, use that space to create things to draw, like a player with a sprite;

        public static void Draw()//call Printf.Draw(//) to draw any supported objects
        {
            Printf.Clear();
            frame++;
            if (frame > 3)
            {
                frame = 0;
            }

            if (direction == 0)
            {
                location.X += 1;
            }
            else if (direction == 1)
            {
                location.Y += 1;
            }
            else if (direction == 2)
            {
                location.X -= 1;
            }
            else if (direction == 3)
            {
                location.Y -= 1;
            }
            map.draw();
            pacman.draw(location, frame, direction);
        }
    }
}
