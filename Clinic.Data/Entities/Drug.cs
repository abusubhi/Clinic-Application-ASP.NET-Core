using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Entities
{
    public class Drug
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dogage { get; set; }
    }
}
