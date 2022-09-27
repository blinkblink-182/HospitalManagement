using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Core
{
    public class HospitalManager : IHospitalManager
    {
        public AppDbContext appDbContext;
        public HospitalManager(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Hospital> AddNewHospital(Hospital newHospital)
        {
            try
            {
                var addedHos = await appDbContext.Hospitals.AddAsync(newHospital);
                await appDbContext.SaveChangesAsync();
                return addedHos.Entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Hospital>> GetAllHospitals()
        {
            try
            {
                var listHos = await appDbContext.Hospitals.ToListAsync();
                return listHos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
