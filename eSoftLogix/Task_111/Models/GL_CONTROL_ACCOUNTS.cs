using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_111.Models
{
    public class GL_CONTROL_ACCOUNTS
    {
        [Key]
        public int CHART_OF_ACCOUNT_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string CHART_OF_ACCOUNT_CODE { get; set; }
        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }
        [ForeignKey("CHART_OF_ACCOUNT_ID")]
        public int? PARENT_CONTROL_ACCOUNT_ID { get; set; }
        [Required]
        public int CREATED_BY { get; set; }
        [Required]
        public DateTime CREATION_DATE { get; set; }
        public int? LAST_UPDATED_BY   { get; set; }
        public DateTime? LAST_UPDATE_DATE { get; set; }
        [StringLength(250)]
        public string SEGMENT1 { get; set; }
        [StringLength(50)]
        public string FOR_COST_CENTER { get; set; }
        [StringLength(50)]
        public string SUB_ACCOUNT_CODE { get; set; }
        [StringLength(50)]
        public string FOR_PROJECTS { get; set; }
        [MaxLength(16)]
        public int? NOTES { get; set; }
        [MaxLength(16)]
        public int? BS_DR_ACC_ID { get; set; }
        [MaxLength(16)]
        public int? BS_CR_ACC_ID { get; set; }
        [MaxLength(1)]
        public int? IN_ACTIVE { get; set; }        
        public int? Lavel { get; set;}
        

    }
}
