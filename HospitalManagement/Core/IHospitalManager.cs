using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Core
{
    public interface IHospitalManager
    {
        Task<Hospital> AddNewHospital(Hospital newHospital);
        Task<List<Hospital>> GetAllHospitals();
    }
}
