using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using printfEngine.printfObjects;

namespace printfEngine.printfHelpers
{
    class Printf
    {
        public static void Clear()
        {
            drawBuffer.charBuffer.Clear();
        }
        public static void Draw(character Char)
        {
            drawBuffer.drawChar(Char);
        }
        //public static void Draw(charFrame Frame)
       //// {
        //    drawBuffer.drawFrame(Frame);
       // }
        public static void Draw(charFrame Frame, Point location)
        {
            drawBuffer.drawFrame(Frame, location);
        }
        public static void Draw(charString String)
        {
            drawBuffer.drawString(String);
        }
      //  public static void Draw(charSprite Sprite, int Frame)
       // {
      //      drawBuffer.drawSprite(Sprite, Frame);
      //  }
        public static void Draw(charSprite Sprite, int Frame, Point location)
        {
            drawBuffer.drawSprite(Sprite, Frame, location);
        }
        public static void Draw(multiString MultiString, int Frame)
        {
            drawBuffer.drawMultiString(MultiString, Frame);
        }
    }
}
