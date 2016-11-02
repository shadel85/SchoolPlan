using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlan.Services.Interface.Models;

namespace SchoolPlan.Services.Interface
{
    public interface IClassService
    {
        IEnumerable<Class> GetClasses();
    }
}
