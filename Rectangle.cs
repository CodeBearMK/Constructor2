using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    internal class Rectangle
    {

        public int Length { get; set; }
        public int Wide { get; set; }

        public Rectangle()
        {
            Length = 10; Wide = 10; 
            Console.WriteLine("矩形一 採 Rectangle()預設建構函式");
            Console.WriteLine("長度:{0}, 寬度:{1}, 面積:{2}", Length, Wide, GetArea());
        }
        public Rectangle(int L)
        {
            Length = L; Wide = 10;
            Console.WriteLine("矩形二 採 Rectangle({0})建構函式", L);
            Console.WriteLine("長度:{0}, 寬度:{1}, 面積:{2}", L, Wide, GetArea());

        }
        public Rectangle(int L, int W)
        {
            Length = L;
            Wide = W;
            Console.WriteLine("矩形三 採 Rectangle({0},{1})建構函式", L, W);
            Console.WriteLine("長度:{0}, 寬度:{1}, 面積:{2}", L, W, GetArea());
        }
        public int GetArea()
        {
            return Length * Wide;
        }
    }
}
