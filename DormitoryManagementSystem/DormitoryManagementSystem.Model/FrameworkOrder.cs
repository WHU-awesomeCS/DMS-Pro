using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace DormitoryManagementSystem.Model
{
    public enum FOrderStatus
    {
        初始状态 = 0,
        生产状态 = 1,
        暂停状态 = 2,
        清料状态 = 3,
        返修状态 = 4,
    }


    public class FrameworkOrder : BasePoco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public new int ID { get; set; }

        [Display(Name = "订单编号")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string FProductionCode { get; set; }
        [Display(Name = "货号Id")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string FProductItemId { get; set; }
        [Display(Name = "订单状态")]
        [Required(ErrorMessage = "{0}是必填项")]
        public FOrderStatus FOrderStatus { get; set; }
        [Display(Name = "计划生产数量")]
        [Required(ErrorMessage = "{0}是必填项")]
        public int FPlanNumber { get; set; }
        [Display(Name = "计划时间")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime FPlanTime { get; set; }
        [Display(Name = "完成时间")]
        public DateTime FFinishTime { get; set; }
        [Display(Name = "OK数量")]
        public int FOkNumber { get; set; }
        [Display(Name = "NG数量")]
        public int FNgNumber { get; set; }
        [Display(Name = "在制品数量")]
        public int FWorkingNumber { get; set; }
        [Display(Name = "报废品数量")]
        public int FScrapNumber { get; set; }


    }
}
