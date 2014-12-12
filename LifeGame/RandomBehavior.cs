using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
    public class CellBehavior
    {
        public List<int> codes = new List<int>();

        public CellBehavior()
        {
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                codes.Add(random.Next(3));
            }
        }

        public byte updateCell(byte cell, int count)
        {
            int code = codes[count];
            if (code == 0)
            {
                return 0;
            }
            if (code == 1)
            {
                return cell;
            }
            if (code == 2)
            {
                return 1;
            }

            return 0;
        }
    }
}
