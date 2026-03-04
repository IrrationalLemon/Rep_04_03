using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Models;

namespace WpfApp5.Classes
{
    internal class DB
    {
        public static DemDbContext db = new DemDbContext();
        public DB() { }
    }
}
