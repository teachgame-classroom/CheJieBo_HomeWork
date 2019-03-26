using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_190319
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("小明", "男", 18, 80, 70, 75);
            int score = student.Total();
            int score1 = student.Average();

            student.SayHello();
            student.PrintScore();
        }
    }
}
