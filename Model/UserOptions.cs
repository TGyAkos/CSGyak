

namespace Model
{
    internal interface IUserOptions
    {
        private protected string[] AllUserOptions { get; }
        private protected int UserInput { get; set; }
    }
    internal class UserOptions : IUserOptions
    {
        private readonly string[] userOptions = { "Add user", "View user" }; //why is it greyed out
        public string[] AllUserOptions
        {
            get => userOptions; //wont work, probably
        }
        public int UserInput { get; set; }

    }

}