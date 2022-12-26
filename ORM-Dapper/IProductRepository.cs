using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IProductRepository
    {
        public IEnumerable<Department> GetAllDepartments();

        public void CreateProduct(string name, double price, int categoryID);
    }
}
