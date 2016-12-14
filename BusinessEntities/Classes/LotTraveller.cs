using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LotTraveller : ILotTraveller
    {
        #region Instance Properties
        private int lotTravellerID;
        private string productionProcess;
        #endregion

        #region Instance Properties
        public int LotTavellerID
        {
            get { return lotTravellerID; }
            set { lotTravellerID = value; }
        }

        public string ProductionProcess
        {
            get { return productionProcess; }
            set { productionProcess = value; }
        }
        #endregion

        #region Constructors
        public LotTraveller()
        {
            throw new System.NotImplementedException();
        }

        public LotTraveller(int lotTravID, string prodProcess)
        {
            this.lotTravellerID = lotTravID;
            this.productionProcess = prodProcess;
        }
        #endregion
    }
}
