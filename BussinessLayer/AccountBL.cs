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
        public List<Account> GetAllAccount()
        {
            try
            {
                return accountDL.GetAllAccount();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Account account)
        {
            try
            {
                return accountDL.Add(account);
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
                accountDL.Del(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Edit(string id, Account account)
        {
            try
            {
                accountDL.Edit(id, account);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
