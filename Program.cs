// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using Model;

namespace CSGyak
{
    class Program
    {
        public static void Main(string[] args)
        {
            IUserModel IAmUser = new UserModel();

            string a;
            WriteLine("num");
            //a = Convert.ToInt32(ReadLine());;
            IAmUser.FirstName = ReadLine();
            WriteLine(IAmUser);
            for (int i = 0; i < 5; i++)
            {
                /*IAmUser[i] = Convert.ToInt32(ReadLine());*/
                IAmUser.FirstName = ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                /*WriteLine(IAmUser[i]);*/
                WriteLine(IAmUser.FirstName);
            }
            WriteLine(IAmUser); 

        }
    }
}