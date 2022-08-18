using StaticAndExtension.Extensions;
using StaticAndExtension.Models;
using System;

namespace StaticAndExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1

            //Console.WriteLine(25.IsOdd());
            //Console.WriteLine(25.IsEven());
            //Console.WriteLine("ssm45asdsad".IsContainsDigit());
            //Console.WriteLine("saLasm".ToCapitalize());

            //int[] Arr = "salam".GetValueIndexes('a');
            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion





            #region Task-2

            string fullname, groupNo;
            int age;
            do
            {
                Console.Write("Fullname: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.Write("Group No: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));


            do
            {
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age <= 0 || age > 170);

            Student st = new Student(fullname, groupNo, age);

            #endregion
        }
    }
}
