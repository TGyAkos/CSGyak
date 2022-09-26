using static System.Console;

namespace View
{
    internal class UserView
    {
        internal int DrawUI(string[] InputOptions)
        {
            DrawOptions(InputOptions);
            return InputByUser();
        }
        private static void DrawOptions(string[] InputOptions)
        {
            for(int i = 0; i < InputOptions.Lenght; i++)
            {
                WriteLine("{0}. - {1}", i + 1, InputOptions[i]);
            }
        }
        private int InputByUser()
        {
            WriteLine("Enter your choice: ");
            return Read();
        }
    }
}