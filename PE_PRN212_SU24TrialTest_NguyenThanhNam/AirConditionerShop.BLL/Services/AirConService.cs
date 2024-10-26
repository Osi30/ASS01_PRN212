using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace AirConditionerShop.BLL.Services
{
    public class AirConService
    {
        private AirConRepository _repo = new();

        public List<AirConditioner> GetAllAirConditioners()
        {
            return _repo.GetAll();
        }

        public void AddAirCons(AirConditioner airConditioner)
        {
            _repo.Add(airConditioner);
        }

        public void UpdateAirCon(AirConditioner airConditioner)
        {
            _repo.Update(airConditioner);
        }

        public void DeleteAirCon(AirConditioner airConditioner)
        {
            _repo.Delete(airConditioner);
        }

        public List<AirConditioner> SearchByFeatureAndQuantity(string feature, int? quantity, bool isAnd)
        {
            // TH1: 2 ô trống
            List<AirConditioner> results = _repo.GetAll();
            // THDB: Tìm kiếm and
            if (isAnd)
            {
                // TH2: ô feature có
                results = FilterByFeature(results, feature);
                // TH3: ô quantity có 
                results = FilterByQuantity(results, quantity);
            }
            // THDB: tìm kiếm or
            else {
                results = FilterByQuantityOrFeature(results, feature, quantity);
            }
            return results;
        }

        private List<AirConditioner> FilterByFeature(List<AirConditioner> results, string feature)
        {
            if (!feature.IsNullOrEmpty())
            {
                results = results.Where(x => x.FeatureFunction.ToLower().Contains(feature.ToLower())).ToList();
            }
            return results;
        }

        private List<AirConditioner> FilterByQuantity(List<AirConditioner> results, int? quantity)
        {
            if (quantity.HasValue)
            {
                results = results.Where(x => x.Quantity == quantity).ToList();
            }
            return results;
        }

        private List<AirConditioner> FilterByQuantityOrFeature(List<AirConditioner> results, string feature, int? quantity)
        {
            if (!feature.IsNullOrEmpty() && quantity.HasValue)
            {
                results = results.Where(x => x.FeatureFunction.ToLower().Contains(feature.ToLower())
                    || x.Quantity == quantity).ToList();
            } else
            {
                results = FilterByFeature(results, feature);
                results = FilterByQuantity(results, quantity);
            }
            return results;
        }
    }
}
