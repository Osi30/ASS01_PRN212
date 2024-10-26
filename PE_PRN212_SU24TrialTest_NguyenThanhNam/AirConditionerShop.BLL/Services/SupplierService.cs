using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;

namespace AirConditionerShop.BLL.Services
{
    public class SupplierService
    {
        private SupplierRepository _supplierRepository = new();

        public List<SupplierCompany> GetAll()
        {
            return _supplierRepository.GetSupplierCompanies();
        }
    }
}
