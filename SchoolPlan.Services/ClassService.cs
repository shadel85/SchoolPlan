using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Repositories;
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
            var classRepo = _unitOfWork.GetRepository<IClassRepository>();
            return null;
        }
    }
}
