﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{  
    public class Material : IMaterial
    {
        #region Instance Properties
        private int id;
        private string name;
        private string description;
        private int qty;
        #endregion

        #region Instance Properties
        public int MatId
        {
            get { return id; }
            set { id = value; }
        }
        public string MatName
        {
            get { return name; }
            set { name = value; }

        }
        public string MatDescription
        {
            get { return description; }
            set { description = value; }
        }
        public int MatQuantity
        {
            get { return qty; }
            set { qty = value; }

        }
        #endregion

        #region Instance Constructor
        public Material()
        {
            throw new System.NotImplementedException();
        }

        public Material(int id, string name, string description)
        {
            this.MatId = id;
            this.MatName = name;
            this.MatDescription = description;
        }
        public Material(int id, string name, string description, int qty)
        {
            this.MatId = id;
            this.MatName = name;
            this.MatDescription = description;
            this.MatQuantity = qty;

        }
        #endregion
    }
}
