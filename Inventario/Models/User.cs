using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Inventario.Models
{
    [DataContract (Name = "User")]
    class User
    {
        [DataMember(Name = "id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember(Name = "full_name")]
        public string FullName
        {
            get { return full_name; }
            set { full_name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int CategoryId
        {
            get { return category_id; }
            set { category_id = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        private int id;
        private string full_name;
        private string email;
        private string password;
        private int category_id;
        private Category category;

    }
}
