using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_111.Models
{
    public class GL_CHART_OF_ACCOUNTS
    {
        [Key]
        public int CONTROL_ACCOUNT_ID { get; set; }
        [Required]
        [StringLength(20)]
        public string CONTROL_ACCOUNT_CODE { get; set; }
        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }
        //[ForeignKey("CONTROL_ACCOUNT_ID")]
        //public int? PARENT_CONTROL_ACCOUNT_ID { get; set; }
        [Required]
        [MaxLength(8)]        
        public int CREATED_BY { get; set; }
        [Required]
        public DateTime CREATION_DATE { get; set; }
        [MaxLength(8)]

        public int? LAST_UPDATED_BY{ get; set; }
        public DateTime? LAST_UPDATE_DATE { get; set; }
        [MaxLength(1)]

        public int? RECORD_LEVEL { get; set; }

        [ForeignKey("GL_CONTROL_ACCOUNTS")]
        public int GL_C_ACCOUNT_id { get; set; }
        public virtual GL_CONTROL_ACCOUNTS GL_CONTROL_ACCOUNTS { get; set; }

        
    }
}
