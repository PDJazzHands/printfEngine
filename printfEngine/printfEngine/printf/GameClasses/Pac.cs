using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using printfEngine.printfHelpers;
using printfEngine.printf;
using printfEngine.printfObjects;
using System.Collections.Generic;

namespace printfEngine.printf.GameClasses
{
    class Pac
    {
        public static charSprite sprite;
        string[,] frames = new string[,]
        {
            {"▄██▄",      //right
             "█▄▀ ",
             "██▄ ",
             "▀██▀" },

            {"▄██▄",
             "█▄██",
             "██▄▄",
             "▀██▀" },

            {"▄██▄",
             "█▄██",
             "████",
             "▀██▀" },

            {"▄██▄",
             "█▄██",
             "██▄▄",
             "▀██▀" },

            {"▄██▄",      //down
             "██▌█",
             "█▌▐█",
             "▐  ▌" },    //hes fine dont worry.

            {"▄██▄",
             "██▌█",
             "█▌██",
             "▀▌█▀" },

            {"▄██▄",
             "██▌█",
             "████",
             "▀██▀" },

            {"▄██▄",
             "██▌█",
             "█▌██",
             "▀▌█▀" },

            {"▄██▄",      //left
             " ▀▄█",
             " ▄██",
             "▀██▀" },

            {"▄██▄",
             "██▄█",
             "▄▄██",
             "▀██▀" },

            {"▄██▄",
             "██▄█",
             "████",
             "▀██▀" },

            {"▄██▄",
             "██▄█",
             "▄▄██",
             "▀██▀" },

            {"▐  ▌",      //up
             "█▌▐█",
             "██▌█",
             "▀██▀" },    //hes fine dont worry.

            {"▄▌█▄",
             "█▌██",
             "██▌█",
             "▀██▀" },

            {"▄██▄",
             "████",
             "██▌█",
             "▀██▀" },

            {"▄▌█▄",
             "█▌██",
             "██▌█",
             "▀██▀" } 
        };
        public Pac(Point Location)
        {
            List<charFrame> framesList = new List<charFrame>();
            List<character> characList = new List<character>();
            for (int y = 0; y < frames.GetLength(0); y++) //frame
            {
                    characList = new List<character>();
                for (int z = 0; z < frames.GetLength(1); z++) //string
                {
                    for (int a = 0; a < frames[y, z].Length; a++) //char of string
                    {
                        characList.Add(new character(frames[y, z][a], a, z, Color.Yellow, Color.DarkBlue));
                    }
                }
                framesList.Add(new charFrame(characList, 0, 0));
            }
            sprite = new charSprite(framesList, 0, 0, 0);
            framesList = null;
            characList = null;
        }

        public void draw(Point location, int frame, int direction)
        {
            Printf.Draw(sprite, frame + (direction * 4), location);
        }
        public void draw(int X, int Y, int frame, int direction)
        {
            Printf.Draw(sprite, frame + (direction * 4), new Point(X, Y));
        }
    }
}
