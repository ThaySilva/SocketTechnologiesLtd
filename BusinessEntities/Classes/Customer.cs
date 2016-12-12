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
        private string custFirstName;
        private string custLastName;
        private string custCompanyName;
        private string custPhoneNum;
        private string[] custAddress;

        #endregion

        #region Instance Properties
        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        public string CustFirstName
        {
            get { return custFirstName; }
            set { custFirstName = value; }
        }

        public string CustLastName
        {
            get { return custLastName; }
            set { custLastName = value; }
        }

        public string CustCompanyName
        {
            get { return custCompanyName; }
            set { custCompanyName = value; }
        }

        public string CustPhoneNum
        {
            get { return custPhoneNum; }
            set { custPhoneNum = value; }
        }

        public string[] CustAddress
        {
            get { return custAddress; }
            set { custAddress = value; }
        }



        #endregion

        #region Constructors
        public Customer()
        {
            throw new System.NotImplementedException();
        }

        public Customer(int id, string firstName, string lastName, string companyName, string phoneNum, string[] Address)
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
