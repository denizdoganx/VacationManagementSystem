using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManagementSystem.Context
{
    public class VacationDB
    {
        private static VacationDbContext context;

        private VacationDB()
        {

        }

        public static VacationDbContext GetDatabase()
        {
            if (context == null)
            {
                context = new VacationDbContext();
            }
            return context;
        }

        public static void KillDatabase()
        {
            context = null;
        }

    }
}
