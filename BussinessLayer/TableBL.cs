using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;

namespace BussinessLayer
{
    public class TableBL
    {
        private TableDL TableDL;
        public TableBL()
        {
            TableDL = new TableDL();
        }
        public List<Table> GetAllTables()
        {
            try
            {
                return TableDL.GetAllTables();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Table Table)
        {
            try
            {
                return TableDL.Add(Table);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Del(string id)
        {
            try
            {
                TableDL.Del(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Edit(string id, Table table)
        {
            try
            {
                TableDL.Edit(id, table);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
