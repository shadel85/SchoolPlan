using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolPlan.DataAccess.Interface;
using SchoolPlan.Services.Interface;
using SchoolPlan.Services.Interface.Models;

namespace SchoolPlan.Services
{
    public class ClassService : IClassService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClassService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Class> GetClasses()
        {
            //var classRepo = _unitOfWork.GetRepository<ISchoolPlanRepository<DataAccess.Interface.Models.Class>>();
            var classes = _unitOfWork.ClassRepository.GetAll();
            
            //return Mapper.Map<IEnumerable<Class>>(classes);
            return null;
        }
    }
}
