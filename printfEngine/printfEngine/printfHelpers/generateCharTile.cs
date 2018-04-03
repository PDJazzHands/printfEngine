using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace printfEngine.printfHelpers
{
    class generateCharTile
    {
        public static Texture2D CharacterTile(char Char, Color foreground, Color background)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        {
            Texture2D cropTexture = new Texture2D(monogameClass.graphics.GraphicsDevice, monogameClass.fontSize.X, monogameClass.fontSize.Y);   
            Color[] data = new Color[monogameClass.fontSize.X * monogameClass.fontSize.Y];                                                      
            monogameClass.FontSheet.GetData(0, charConvertor.rawChartoChar(Char), data, 0, data.Length);                                        
            cropTexture.SetData(data);                                                                                                          
            Texture2D charTileOut = new Texture2D(monogameClass.graphics.GraphicsDevice, monogameClass.fontSize.X, monogameClass.fontSize.Y);   
            uint[] pixelColors = new uint[monogameClass.fontSize.X * monogameClass.fontSize.Y];                                                 
            for (int i = 0; i < pixelColors.Length; i++)                                                                                        
            {
                pixelColors[i] = foregroundBackground(data[i] ,foreground, background);                                                         
            }
            charTileOut.SetData<uint>(pixelColors);
            cropTexture = null;
            data = null;
            pixelColors = null;
            return charTileOut;

        }
        private static uint foregroundBackground(Color cropColor, Color foreground, Color background)
        {
            int r = (foreground.R * cropColor.A / 255) + (background.R * background.A * (255 - cropColor.A) / (255 * 255));
            int g = (foreground.G * cropColor.A / 255) + (background.G * background.A * (255 - cropColor.A) / (255 * 255));
            int b = (foreground.B * cropColor.A / 255) + (background.B * background.A * (255 - cropColor.A) / (255 * 255));
            return (uint)((255 << 24) | (b << 16) | (g << 8) | (r << 0));
        }
    }
}
