using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public enum EPosition
    {
        OWNER = 0,
        DRIVER = 1,
        INTERN = 2,
        RECEPTIONIST = 3,
        TOUR_GUIDE = 4
    }
    public enum ESalary
    {
        OWNER_SALARY = 100000,
        DRIVER_SALARY = 85000,
        INTERN_SALARY = 50000,
        RECEPTIONIST_SALARY = 70000,
        TOUR_GUIDE_SALARY = 60000
    }
    public enum EUserRole
    {
        ADMIN = 0,
        STAFF = 1
    }
}
