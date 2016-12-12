using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class Stores_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        #region Stores functions

        public static List<string[]> GetMaterials()
        {
            var data = from mat in model.MaterialsList select new String[] { mat.MatId.ToString(), mat.MatName, mat.MatDescription, mat.MatQuantity.ToString() };
            return data.ToList<String[]>();
        }

        public static void AddMaterial(int MatID, string MatName, string MatDescription)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<IMaterial>.Register(uid, () => new Material(MatID, MatName, MatDescription));
            IMaterial mat = GenericFactory<IMaterial>.Create(uid);
            _data.AddRow("RawMaterial", new string[] {"RawMaterial_ID", "materialName", "materialDescription"}, new string[] {MatID.ToString(), MatName, MatDescription });
            model.FillMaterialsList();

        }

        public static void UpdateStock(int matID,  int matQty)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("RawMaterial_ID", matID.ToString());
            _data.UpdateRowsByKey("RawMaterial", new string[] { "inStock" }, new string[] { matQty.ToString() });

            var mats = model.MaterialsList.First();
            mats.MatQuantity = matQty;
        }
        #endregion




    }
}
