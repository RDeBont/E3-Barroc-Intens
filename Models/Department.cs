using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace E3_Barroc_Intens.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<User> Users { get; set; } = new();
    }
}
