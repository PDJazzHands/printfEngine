using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfHelpers;

namespace printfEngine.printfObjects
{
    class charFrame
    {
        public List<character> CharacterList;
        public Point layerOffset;
        public charFrame(List<character> characterList, Point offset)
        {
            layerOffset = (offset * monogameClass.fontSize);
            foreach (character c in characterList)
            {
                c.location.Location += layerOffset;
            }
            CharacterList = characterList;
        }
        public charFrame(List<character> characterList, int X, int Y)
        {
            layerOffset = new Point(X * monogameClass.fontSize.X, Y * monogameClass.fontSize.Y);
            foreach (character c in characterList)
            {
                c.location.Location += layerOffset;
            }
            CharacterList = characterList;
        }
    }
}
