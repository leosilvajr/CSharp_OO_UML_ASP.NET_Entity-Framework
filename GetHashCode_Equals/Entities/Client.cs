using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode_Equals.Entities
{
     class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //Customizar quando um Cliente é igual ao outro

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }

            //DownCast
            Client orther = obj as Client;
            return Email.Equals(orther.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

    }
}
