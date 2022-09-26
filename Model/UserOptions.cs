

namespace Model
{
    internal interface IUserOptions
    {
        private protected string[] UserOptions { get; }
        private protected int UserInput { get; set; }
    }
    internal class UserOptions : IUserOptions
    {
        private readonly string[] userOptions = { "Add user", "View user" }; //why is it greyed out
        public string[] UserOptions
        {
            get => userOptions; //wont work, probably
        }

    }

}