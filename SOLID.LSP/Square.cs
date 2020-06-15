using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
   public class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(int side)
        {
            Width = Height = side;
        }

        public override int Width // nasty side effects
        {
            set => base.Width = base.Height = value;
        }

        public override int Height
        {
            set => base.Width = base.Height = value;
        }

       

    }
}
