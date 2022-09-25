using System;
using System.Security.Cryptography;

namespace Model
{
    internal interface IUserModel
    {
        protected internal int this[int _id]
        {
            get;
            set;
        }
        protected internal string? FirstName { get; set; }
        protected internal string? SurName { get; set; }

    }
    internal class UserModel : IUserModel
    {
        public string? FirstName { get; set; }
        public string? SurName { get; set; }

        private int[] idArray = new int[100];
        public int this[int _id] 
        { 
            get => idArray[_id];
            set => idArray[_id] = value;
        }
    }
}
