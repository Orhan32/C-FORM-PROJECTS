using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;


namespace MtaTrigger
{
    class AutoIt
    {
        AutoItX3 auto = new AutoItX3();

        public void mouseClick(string clickSide, int x, int y, int clickCount, int speed)
        {
            auto.MouseClick(clickSide, x, y, clickCount, speed);
        }
    }
}
