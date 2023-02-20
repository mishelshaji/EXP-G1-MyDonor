using MyDonor.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Service.Services
{
    public class ManagerService
    {
        private readonly ApplicationDbContext _db;

        public ManagerService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<List<StockViewDto>>> GetStocks(string managerid)
        {
            var Response = new ServiceResponse<List<StockViewDto>>();
            var bloodbank = _db.BloodBanks.Where(m => m.ManagerId == managerid).FirstOrDefault();
            if (bloodbank == null)
            {
                Response.AddError("Bloodbank", "bloodbank is not present");
                return Response;
            }

            Response.Result = _db.Stocks.Where(m => m.BloodBankId == bloodbank.Id).Select(m =>new StockViewDto(m.Quantity,m.BloodGroupId)).ToList();

            return Response;
        }

        public async Task<ServiceResponse<List<CustomerViewDto>>> GetCustomers(string managerid)
        {
            var Response = new ServiceResponse<List<CustomerViewDto>>();
            var manager = _db.ApplicationUsers.Where(m => m.Id == managerid).FirstOrDefault();
            if (manager == null)
            {
                Response.AddError("Manager", "Manager is not present");
                return Response;
            }

            Response.Result = _db.ApplicationUsers.Where(m => m.DistrictId == manager.DistrictId && m.Roles != "Manager").Select(m => new CustomerViewDto(m.Name,m.PhoneNumber,m.BloodId)).ToList();

            return Response;
        }
    }
}
