using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_190319
{
    class Student
    {
        public string name;
        public string sex;
        public int age;
        public int yuwen;
        public int math;
        public int english;

        public Student(string var_name, string var_sex, int var_age, int var_yuwen, int var_math, int var_english)
        {
            name = var_name;
            sex = var_sex;
            age = var_age;
            yuwen = var_yuwen;
            math = var_math;
            english = var_english;
        }

        public void SayHello()
        {
            Console.WriteLine("我叫" + name + ",今年" + age + "岁了,是" + sex + "同学");
        }

        public int Total()
        {
            int toalScore = yuwen + math + english;
            return toalScore;
        }

        public int Average()
        {
            int AverageScore = Total() / 3;
            return AverageScore;
        }

        public string Grade()
        {
            int avg = Average();

            //评价
            string Grade = "不及格";

            if(avg >= 90)      //优
            {
                Grade = "优";  
            }
            else if(avg >= 80) //良
            {
                Grade = "良";
            }
            else if(avg >= 60) //中
            {
                Grade = "中";
            }
            else
            {
                Grade = "不及格";
            }

            return Grade;
        }

        public void PrintScore()
        {
            Console.WriteLine("我叫" + name + ",这次考试总成绩为" + Total() + "分,平均成绩为" + Average() + "分,评价是" + Grade());
        }
    }
}
