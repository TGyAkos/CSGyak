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
        /*public int _id { get; set; }*/
        protected internal string? FirstName { get; set; }
        protected internal string? SurName { get; set; }

        /*int this[int _id] 
        { 
            get;
            set; 
        }
        public int _id { get; set; }
        string? FirstName { get; set; }
        string? SurName { get; set; }*/

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
        /*internal UserModel(int id)
        {
            _id = id;
        }*/

        /*public string? _FirstName { get; set; }
        public string? _SurName { get; set; }*/
        
        /*private int _id;
        private string? firstName;
        private string? surName;
        /*private string BirthDate;
        private int PostCode;
        private string Address;*/

        /*internal int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }

        }*/
        /*public string? FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string? SurName
        {
            get
            {
                return surName;
            }
            set
            {
                surName = value;
            }
        }

        /*internal int GetId()
        {
            return Id;
        }
        internal string GetFirstName()
        {
            return FirstName;
        }
        internal string GetSurName()
        {
            return SurName;
        }
        internal void SetId(int id)
        {
            Id = id;
        }*/
    }
}
