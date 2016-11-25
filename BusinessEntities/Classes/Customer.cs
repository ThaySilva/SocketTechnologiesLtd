using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Interfaces;
namespace BusinessEntities.Classes
{
    public class Customer : ICustomer
    {
        #region Fields

        String _id;
        String _name;
        String _contactName;
        String _contactSurname;
        String _address1;
        String _address2;
        String _address3;
        String _phone;
        String _email;

        #endregion

        #region Properties
        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string ContactName
        {
            get
            {
                return _contactName;
            }

            set
            {
                _contactName = value;
            }
        }

        public string ContactSurname
        {
            get
            {
                return _contactSurname;
            }

            set
            {
                _contactSurname = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Address1
        {
            get
            {
                return _address1;
            }

            set
            {
                _address1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return _address2;
            }

            set
            {
                _address2 = value;
            }
        }

        public string Address3
        {
            get
            {
                return _address3;
            }

            set
            {
                _address3 = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        #endregion

        public Customer(String id, String name, String contactName, String contactSurname, String add1, String add2, String add3, String phone, String email)
        {
            _id = id;
            _name = name;
            _contactName = contactName;
            _contactSurname = contactSurname;
            _address1 = add1;
            _address2 = add2;
            _address3 = add3;
            _email = email;
            _phone = phone;

        }

        public string[] ToStringArray()
        {
            return new String[] { _id, _name, _contactName, _contactSurname, _address1, _address2, _address3, _phone, _email };
        }
    }
}
