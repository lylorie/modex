using ModexEdu.universityModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModexEdu.modexfunction
{
    internal class Database
    {
        public static List<ModexUser> registeredUsers = new List<ModexUser>();
        public static ModexUser currentUser;

        public static List<ModexUniversity> modexUniversities = new List<ModexUniversity>();
        public static ModexUniversity modexUniversity;

        public static ModexUser getCurrentUser()
        {
            if(currentUser== null)
            { return new ModexUser(); }
            return currentUser;
        }

        public static ModexUniversity getCurrentUniversity()
        {
            return modexUniversity;
        }
    }
}
