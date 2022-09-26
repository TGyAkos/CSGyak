using System;
using System.Security.Cryptography;

namespace Model
{
    internal interface IUserModel
    {
        /*private protected int this[int _id]
        {
            get;
            set;
        }*/
        private protected string? FirstName { get; set; }
        private protected string? SurName { get; set; }

    }
    internal class UserModel : IUserModel
    {
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
    }
    internal class UserModelCollection : UserModel
    {
        private UserModel[] userModelCollection = new UserModel[10];

        public UserModel this[int _id]
        {
            get => userModelCollection[_id];
            set => userModelCollection[_id] = value;    
        }

    }
}
