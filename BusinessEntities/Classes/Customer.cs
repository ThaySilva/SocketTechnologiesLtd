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

        private int Customer_ID;
        private String CustFirstName;
        private String CustLastName;
        private String CustCompanyName;
        private String CustPhoneNum;
        private String CustAddress;
        private String CustAddLine2;
        private String CustCounty;
        #endregion

        #region Instance Properties
        public int customer_ID
        {
            get { return customer_ID; }
            set { Customer_ID = value; }
        }

        public String custFirstName
        {
            get { return custFirstName; }
            set { custFirstName = value; }
        }

        public String custLastName
        {
            get { return custLastName; }
            set { custLastName = value; }
        }

        public String custCompanyName
        {
            get { return custCompanyName; }
            set { custCompanyName = value; }
        }

        public String custPhoneNum
        {
            get { return custPhoneNum; }
            set { custPhoneNum = value; }
        }
        public String custAddress
        {
            get { return custAddress; }
            set { custAddress = value; }
        }
        public String custAddLine2
        {
            get { return custAddLine2; }
            set { custAddLine2 = value; }
        }
        public String custCounty
        {
            get { return custCounty; }
            set { custCounty = value; }
        }



        #endregion

        #region Constructors
        public Customer()
        {
            throw new System.NotImplementedException();
        }

        public Customer(int id, String firstName, String lastName, String companyName, String phoneNum, String Address, String Address2, String Address3)
        {
            Customer_ID = id;
            CustFirstName = firstName;
            CustLastName = lastName;
            CustCompanyName = companyName;
            CustPhoneNum = phoneNum;
            CustAddress = Address;
            CustAddLine2 = Address2;
            CustCounty = Address3;

        }

        #endregion

    }
}
