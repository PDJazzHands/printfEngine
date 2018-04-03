using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printfEngine.printf.GameClasses
{
    class Ghost
    {
        string[,] frames = new string[,]
{
            {"▐██▌",      //left
             "█▐▐█",
             "████",
             "▌▌▐▐" },

            {"▐██▌",
             "█▐▐█",
             "████",
             "▐▐▌▌" },

            {"▐██▌",
             "█▌▌█",
             "████",
             "▌▌▐▐" },

            {"▐██▌",
             "█▌▌█",
             "████",
             "▐▐▌▌" }
        };
    }
}
