using SchoolPlan.Data;
using SchoolPlan.DataAccess.Interface;
using System.Linq;
using SchoolPlan.DataAccess.Repositories;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolPlanContext _context;

        public UnitOfWork() : this(new SchoolPlanContext()) { }

        public UnitOfWork(SchoolPlanContext context)
        {
            _context = context;
        }

        public SchoolPlanContext Context => _context;

        private ISchoolPlanRepository<Class> _classRepository;
        private ISchoolPlanRepository<Student> _studentRepository;
        private ISchoolPlanRepository<Location> _locationRepository;
        private ISchoolPlanRepository<Teacher> _teacherRepository;
        private ISchoolPlanRepository<StudentClass> _studentClassRepository;

        public ISchoolPlanRepository<Class> ClassRepository => _classRepository ?? (_classRepository = new ClassRepository(this));
        public ISchoolPlanRepository<Student> StudentRepository => _studentRepository ?? (_studentRepository = new StudentRepository(this));
        public ISchoolPlanRepository<Location> LocationRepository => _locationRepository ?? (_locationRepository = new LocationRepository(this));
        public ISchoolPlanRepository<Teacher> TeacherRepository => _teacherRepository ?? (_teacherRepository = new TeacherRepository(this));
        public ISchoolPlanRepository<StudentClass> StudentClassRepository => _studentClassRepository ?? (_studentClassRepository = new StudentClassRepository(this));

        public void Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
