using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Entities
{
    public class VisitTreatment
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public virtual Patient Patients { get; set; }


        [ForeignKey("VisitId")]
        public int VisitId { get; set; }
        public virtual Visit Visits { get; set; }


        [ForeignKey("TreatmentId")]
        public int TreatmentId { get; set; }

        public virtual Treatment Treatments { get; set; }


    }

}
