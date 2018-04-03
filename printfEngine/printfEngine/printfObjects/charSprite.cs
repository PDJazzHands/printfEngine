using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace printfEngine.printfObjects
{
    class charSprite
    {
        public List<charFrame> Frames;
        public Point Location;
        public int CurrentFrame;
        public charSprite(List<charFrame> frames, Point location, int currentFrame)
        {
            Location = (location * monogameClass.fontSize);
            foreach (charFrame cFrame in frames)
            {
                foreach (character c in cFrame.CharacterList)
                {
                    c.location.Location += Location;
                }
            }
            CurrentFrame = currentFrame;
            Frames = frames;
        }
        public charSprite(List<charFrame> frames, int X, int Y, int currentFrame)
        {
            Location = new Point(X * monogameClass.fontSize.X, Y * monogameClass.fontSize.Y);
            foreach (charFrame cFrame in frames)
            {
                foreach (character c in cFrame.CharacterList)
                {
                    c.location.Location += Location;
                }
            }
            CurrentFrame = currentFrame;
            Frames = frames;
        }
    }
}
