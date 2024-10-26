using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionerShop.DAL.Entities;

namespace AirConditionerShop.DAL.Repositories
{
    public class MemberRepository
    {
        private AirConditionerShop2024DbContext _context;

        public StaffMember? GetStaffMember(string email, string password)
        {
            _context = new();
            // return one line or be null
            return _context.StaffMembers.FirstOrDefault(x => 
                x.EmailAddress == email && x.Password == password
            );
        }
    }
}
