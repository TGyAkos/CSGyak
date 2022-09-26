using System;
using static System.Console;
using Model;

namespace CSGyak
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserModel IAmUser = new UserModel();

            WriteLine("num");
            IAmUser.FirstName = ReadLine();
            WriteLine(IAmUser);
            for (int i = 0; i < 5; i++)
            {
                IAmUser[i] = ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                WriteLine(IAmUser[i]);
            }
            WriteLine(IAmUser); 

        }
    }
}