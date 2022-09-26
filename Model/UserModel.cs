using System;
using System.Security.Cryptography;

namespace Model
{
    internal interface IUserModel
    {
        private protected int this[int _id]
        {
            get;
            set;
        }
        private protected string? FirstName { get; set; }
        private protected string? SurName { get; set; }

    }
    internal class UserModel : IUserModel
    {
        public string? FirstName { get; set; }
        public string? SurName { get; set; }

        private int[] idArray = new int[100]; //maybe public
        public int this[int _id] 
        { 
            get => idArray[_id];
            set => idArray[_id] = value;
        }
        public string FirstNameById(int _id)
        {
            get => idArray[_id].FirstName;
        }
    }
}
