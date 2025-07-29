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
    public class CategoryBL
    {
        private CategoryDL categoryDL;
        public CategoryBL()
        {
            this.categoryDL = new CategoryDL();
        }
        public List<Category> GetAllCategories()
        {
            try
            {
                return categoryDL.GetAllCategories();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Category category)
        {
            try
            {
                return categoryDL.Add(category);
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
                categoryDL.Del(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Edit(string id, Category category)
        {
            try
            {
                categoryDL.Edit(id, category);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
