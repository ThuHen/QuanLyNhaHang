using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BussinessLayer
{
    public class TableStatusBL
    {
        private TableStatusDL tableStatusDL;
        public TableStatusBL()
        {
            tableStatusDL = new TableStatusDL();
        }
        public List<TableStatus> GetAllTableStatuses()
        {
            try
            {
                return tableStatusDL.GetAllTableStatuses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
