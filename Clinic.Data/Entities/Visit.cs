using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Entities
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctors { get; set; }
        public DateTime DateOfVisit { get; set; }
    }
}
