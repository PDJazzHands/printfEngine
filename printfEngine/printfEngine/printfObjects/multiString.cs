using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfHelpers;

namespace printfEngine.printfObjects
{
    class multiString
    {
        public List<charString> Strings;
        public Point Location;
        public int CurrentString;
        public multiString(List<charString> strings, Point location, int currentString)
        {
            foreach (charString str in strings)
            {
                foreach (character ch in str.CharacterList)
                {
                    ch.location = new Rectangle((location * monogameClass.fontSize) + ch.location.Location, monogameClass.fontSize);
                }
            }
            CurrentString = currentString;
            Location = location;
            Strings = strings;
        }
        public multiString(List<charString> strings, int X, int Y, int currentString)
        {
            foreach (charString str in strings)
            {
                foreach (character ch in str.CharacterList)
                {
                    ch.location = new Rectangle((X * monogameClass.fontSize.X) + ch.location.X, (Y * monogameClass.fontSize.Y) + ch.location.Y, monogameClass.fontSize.X, monogameClass.fontSize.Y);
                }
            }
            CurrentString = currentString;
            Location = new Point(X, Y);
            Strings = strings;
        }
    }
}
