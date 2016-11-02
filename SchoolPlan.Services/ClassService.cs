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
            var classes = _unitOfWork.ClassRepository.GetAll();
            var serviceClasses = new List<Class>();
            foreach (var item in classes)
            {
                serviceClasses.Add(new Class
                {
                    Name = item.Name,
                    ClassId = item.Id
                });
            }
            return serviceClasses;
        }
    }
}
