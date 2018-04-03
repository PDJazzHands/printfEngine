using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfHelpers;

namespace printfEngine.printfObjects
{
    class character
    {
        public Color foregroundColor;
        public Color backgroundColor;
        public Texture2D glyph;
        public Rectangle location;
        public char Char;
        public character(char Char, Point location, Color foreground, Color background)
        {
            foregroundColor = foreground;
            backgroundColor = background;
            glyph = generateCharTile.CharacterTile(Char, foreground, background);
            this.location = new Rectangle(location * monogameClass.fontSize, monogameClass.fontSize);
            this.Char = Char;
        }
        public character(char Char, int X, int Y, Color foreground, Color background)
        {
            foregroundColor = foreground;
            backgroundColor = background;
            glyph = generateCharTile.CharacterTile(Char, foreground, background);
            this.location = new Rectangle(X * monogameClass.fontSize.X, Y * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
            this.Char = Char;
        }

        //reserved overloads for drawbuffer.cs
        public character(char Char, Point location, Color foreground, Color background, Texture2D Glyph)
        {
            foregroundColor = foreground;
            backgroundColor = background;
            glyph = Glyph;
            this.location = new Rectangle(location * monogameClass.fontSize, monogameClass.fontSize);
            this.Char = Char;
        }
        public character(char Char, int X, int Y, Color foreground, Color background, Texture2D Glyph)
        {
            foregroundColor = foreground;
            backgroundColor = background;
            glyph = Glyph;
            this.location = new Rectangle(X * monogameClass.fontSize.X, Y * monogameClass.fontSize.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
            this.Char = Char;
        }
    }
}
