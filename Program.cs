using System;
using static System.Console;
using Model;

namespace CSGyak
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserModelCollection IAmUserCollection = new UserModelCollection();

            WriteLine("num");
            //IAmUserCollection[1].FirstName = ReadLine();
            WriteLine(IAmUserCollection);
            for (int i = 0; i < 5; i++)
            {
                UserModel IAmUser = new UserModel();
                IAmUser.FirstName = ReadLine();
                IAmUserCollection[i] = IAmUser;
            }
            for (int i = 0; i < 5; i++)
            {   
                WriteLine(IAmUserCollection[i].FirstName);
            }
            WriteLine(IAmUserCollection); 

        }
    }
}