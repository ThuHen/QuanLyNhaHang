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
    public class AccountBL
    {
        private AccountDL accountDL;
        public AccountBL()
        {
            accountDL = new AccountDL();
        }
        public Account Login(string username, string password)
        {
            try
            {
                return (accountDL.Login(username, password));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
