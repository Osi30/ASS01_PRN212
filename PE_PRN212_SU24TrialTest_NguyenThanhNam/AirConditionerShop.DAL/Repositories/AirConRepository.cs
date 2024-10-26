using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConRepository
    {
        private AirConditionerShop2024DbContext _context;

        public List<AirConditioner> GetAll()
        {
            _context = new();   
            return _context.AirConditioners.Include("Supplier").ToList();
        }

        public void Add(AirConditioner airConditioner)
        {
            _context = new();
            // save to RAM
            _context.AirConditioners.Add(airConditioner);
            // save to DB
            _context.SaveChanges();
        }

        public void Update(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Update(airConditioner);
            _context.SaveChanges();
        }

        public void Delete(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Remove(airConditioner);
            _context.SaveChanges();
        }
    }
}
