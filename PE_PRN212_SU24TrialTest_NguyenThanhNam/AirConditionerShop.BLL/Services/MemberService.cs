using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;

namespace AirConditionerShop.BLL.Services
{
    public class MemberService
    {
        private MemberRepository _repo = new();

        public StaffMember? Authenticate(string email, string password)
        {
            return _repo.GetStaffMember(email, password);
        }

    }
}
