using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class TechnicalEnquiry: ITechnicalEnquiry
    {
        #region Instance Properties

        private int TechnicalEnquiry_ID;
        private String EnquiryText;
        private int Responded;
        private int Accepted;
        private DateTime DateCreated;
        private int Customer_customer_ID;
        #endregion

        #region Instance Properties
        public int technicalEnquiry_ID
        {
            get { return technicalEnquiry_ID; }
            set { technicalEnquiry_ID = value; }
        }

        public String enquiryText
        {
            get { return enquiryText; }
            set { enquiryText = value; }
        }
        public int responded
        {
            get { return responded; }
            set { responded = value; }
        }

        public int accepted
        {
            get { return accepted; }
            set { accepted = value; }
        }
        public DateTime dateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public int customer_customer_ID
        {
            get { return customer_customer_ID; }
            set { customer_customer_ID = value; }
        }
        #endregion

        #region Constructors
        public TechnicalEnquiry()
        {
            throw new System.NotImplementedException();
        }

        public TechnicalEnquiry(int TE_ID, String EText, int Resp, int Accep, DateTime DCreated, int Cus_cus_ID)
        {
            int TechnicalEnquiry_ID = TE_ID;
            String EnquiryText = EText;
            int Responded = Resp;
            int Accepted = Accep;
            DateTime DateCreated = DCreated;
            int Customer_customer_ID = Cus_cus_ID;

        }
        #endregion
    }

}
