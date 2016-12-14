using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void OpenConnection();
        void CloseConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        List<string[]> GetTableData(string table);
        List<string[]> GetTableData(string table, string[] columns);
        List<string[]> GetTableData(string table, string table2, string[] columns);
        void AddRow(string table, string[] columns, string[] values);
        void DeleteRowByKey(string table);
        void SetJoin(string thisTable, string joinedTable, string thisTableColumn, string joinedTableColumn);
        void SetCriteria(string column, string criteria);
        void SetCriteria(string column, int criteria);
        void SetCriteria(string column, bool criteria);
        void RemoveCriteria();
        void RemoveJoins();
        string GetMax(string table, string column);
        void UpdateRowsByKey(string table, string[] columns, string[] values);
    }
}
