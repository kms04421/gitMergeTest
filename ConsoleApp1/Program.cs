﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        // { 2023.07.03. Add usetr input / Beat
        static void Main(string[] args)
        {
            Console.WriteLine("Hell     o Wor ld Wor ldWor ld");
            Console.WriteLine("Hell     o Wor ld");
            Console.WriteLine("Hello World");
        }
        // { 2023.07.03. Add usetr input / Beat
    }

    public class Ruar
    {
        private const float ONE_INCE = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float INCh
        {
            get { return Centimeter*ONE_INCE; }
            //{2023.07.03. Add private setInch function . Gamma
            private set { this._setInch(value); }
        }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.INCh}입니다");
        }

        private void _setInch(float inchValue)
        {
            Centimeter = (int)(inchValue/ONE_INCE);
        }
        //{2023.07.03. Add private setInch function . Gamma
    }


}
