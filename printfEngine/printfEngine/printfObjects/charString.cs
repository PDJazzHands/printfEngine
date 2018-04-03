using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfHelpers;

namespace printfEngine.printfObjects
{
    class charString
    {
        public string String;
        public List<character> CharacterList;
        public Point location;
        public charString(string input, Point stringLocation, Color foreground, Color background)
        {
            String = input;
            location = stringLocation;
            List<character> tempCharList = new List<character>();
            string[] lines = input.Split('\n');
            for (int line = 0; line < lines.Length; line++)
            {
                for (int lineChar = 0; lineChar < lines[line].Length; lineChar++)
                {
                    char c = lines[line][lineChar];
                    tempCharList.Add(new character(c, lineChar + stringLocation.X, line + stringLocation.Y, foreground, background));
                }
            }
            CharacterList = tempCharList;
            tempCharList = null;
        }
        public charString(string input, int X, int Y, Color foreground, Color background)
        {
            String = input;
            location = new Point(X, Y);
            List<character> tempCharList = new List<character>();
            string[] lines = input.Split('\n');
            for (int line = 0; line < lines.Length; line++)
            {
                for (int lineChar = 0; lineChar < lines[line].Length; lineChar++)
                {
                    char c = lines[line][lineChar];
                    tempCharList.Add(new character(c, lineChar + X, line + Y, foreground, background));
                }
            }
            CharacterList = tempCharList;
            tempCharList = null;
        }
    }
}
