﻿using Carra.Carra;
using static Carra.Carra.LZMA_XZ;

namespace Carra
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InitNativeLibrary();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string test = @"D:\Downloads\TestUnit\Kromer NClair.zip";
            Carra.Carra carraInst = new Carra.Carra(test);
            carraInst.CompressLunarMod(@"D:\Downloads\TestUnit\Sinc");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);

        }
        
    }
}   