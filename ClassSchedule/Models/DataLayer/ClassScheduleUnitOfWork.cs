namespace ClassSchedule.Models
{
    public class ClassScheduleUnitOfWork : IClassScheduleUnitOfWork
    {
        private ClassScheduleContext context { get; set; }

        private Repository<Class> classData { get; set; }
        public Repository<Class> Classes
        { 
            get
            {
                if (classData == null)
                {
                    classData = new Repository<Class>(context);
                }
                return classData;
            }
        }
        private Repository<Teacher> teacherData { get; set; }
        public Repository<Teacher> Teachers
        {
            get
            {
                if (teacherData == null)
                {
                    teacherData = new Repository<Teacher>(context);
                }
                return teacherData;
            }
        }
        private Repository<Day> dayData { get; set; }
        public Repository<Day> Days
        {
            get
            {
                if (dayData == null)
                {
                    dayData = new Repository<Day>(context);
                }
                return dayData;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }


        public ClassScheduleUnitOfWork(ClassScheduleContext ctx)
        {
            this.context = ctx;
        }
    }
}
