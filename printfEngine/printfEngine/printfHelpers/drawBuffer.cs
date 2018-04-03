using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfObjects;

namespace printfEngine.printfHelpers
{
    class drawBuffer : DrawableGameComponent
    {
        public drawBuffer(Game game) : base(game) { }

        SpriteBatch sb= new SpriteBatch(monogameClass.graphics.GraphicsDevice);
        public static List<character> charBuffer = new List<character>();

        protected override void LoadContent()
        {
            sb = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            sb.Begin();
            foreach (character c in charBuffer)
            {
                sb.Draw(c.glyph, c.location, Color.White);
            }
            sb.End();
            base.Draw(gameTime);
        }

        public static void drawChar(character Char)
        {
            bool duplicate = false;
            for (int i = 0; i < charBuffer.Count; i++)
            {
                if (Char.location == charBuffer[i].location)
                {
                    duplicate = true;
                    charBuffer[i] = Char;
                }
            }
            if (!duplicate)
            {
                charBuffer.Add(Char);
            }
            Char = null;
        }
        public static void drawChar(character Char, Point location)
        {
            bool duplicate = false;
            for (int i = 0; i < charBuffer.Count; i++)
            {
                if (Char.location == charBuffer[i].location)
                {
                    duplicate = true;
                    charBuffer.Add(new character(Char.Char, location * Char.location.Location, Char.foregroundColor, Char.backgroundColor, Char.glyph));
                }
            }
            if (!duplicate)
            {
                charBuffer.Add(new character(Char.Char, location * Char.location.Location, Char.foregroundColor, Char.backgroundColor, Char.glyph));
            }
            Char = null;
        }
        public static void drawChar(Point WorldTransform, character Char) //overload for the sprite draw functions
        {
            Rectangle location = new Rectangle((Char.location.X / monogameClass.fontSize.X) + WorldTransform.X, (Char.location.Y / monogameClass.fontSize.Y) + WorldTransform.Y, Char.location.Width, Char.location.Height);
            bool duplicate = false;
            for (int i = 0; i < charBuffer.Count; i++)
            {
                if (location == charBuffer[i].location)
                {
                    duplicate = true;
                    charBuffer[i] = Char;
                }
            }
            if (!duplicate) //this is a new char decleration, so divide the location of the char passed in otherwise it will expand by fontsize
            {
                charBuffer.Add(new character(Char.Char, location.X, location.Y, Char.foregroundColor, Char.backgroundColor, Char.glyph));
            }
            Char = null;
        }
        public static void drawFrame(charFrame Frame, Point location)
        {
            foreach (character c in Frame.CharacterList)
            {
                drawChar(location, c);
            }
        }
        public static void drawString(charString String)
        {
            foreach (character c in String.CharacterList)
            {
                drawChar(c);
            }
        }
        public static void drawSprite(charSprite Sprite, int Frame, Point location)
        {
            drawFrame(Sprite.Frames[Frame], location);
        }
        public static void drawMultiString(multiString MultiString, int Frame)
        {
            drawString(MultiString.Strings[Frame]);
        }
    }
}
