using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
        }
    }

    public class Ruar
    {
        private const float ONE_INCE = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float INCh
        {
            get { return Centimeter*ONE_INCE; }
            private set { Centimeter = (int)(value/ONE_INCE); }
        }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.INCh}입니다");
        }
   }


}
