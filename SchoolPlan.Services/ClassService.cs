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
        private readonly IMapper _mapper;

        public ClassService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Class> GetClasses()
        {
            var classes = _unitOfWork.ClassRepository.GetAll();
            return _mapper.Map<IEnumerable<Class>>(classes);
        }
    }
}
