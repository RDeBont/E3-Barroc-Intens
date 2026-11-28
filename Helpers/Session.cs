using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models;

namespace E3_Barroc_Intens.Helpers
{
    public static class Session
    {
        public static Medewerker? CurrentUser { get; private set; }

        public static void Login(Medewerker medewerker) => CurrentUser = medewerker;

        public static void Logout() => CurrentUser = null;
    }
}
