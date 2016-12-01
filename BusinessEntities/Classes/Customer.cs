using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class Customer : ICustomer
    {
        #region Instance Properties

        private int customer_ID;
        private String custFirstName;
        private String custLastName;
        private String custCompanyName;
        private String custPhoneNum;
        private String custAddress;

        #endregion

        #region Instance Properties
        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        public String CustFirstName
        {
            get { return custFirstName; }
            set { custFirstName = value; }
        }

        public String CustLastName
        {
            get { return custLastName; }
            set { custLastName = value; }
        }

        public String CustCompanyName
        {
            get { return custCompanyName; }
            set { custCompanyName = value; }
        }

        public String CustPhoneNum
        {
            get { return custPhoneNum; }
            set { custPhoneNum = value; }
        }

        public String CustAddress
        {
            get { return custAddress; }
            set { custAddress = value; }
        }



        #endregion

        #region Constructors
        public Customer()
        {
            throw new System.NotFiniteNumberException();
        }

        public Customer(int id, String firstName, String lastName, String companyName, String phoneNum, String Address)
        {
            Customer_ID = id;
            CustFirstName = firstName;
            CustLastName = lastName;
            CustCompanyName = companyName;
            CustPhoneNum = phoneNum;
            CustAddress = Address;

        }

        #endregion



    }
}
