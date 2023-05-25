using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model;


namespace DormitoryManagementSystem.ViewModel._Order.FrameworkOrderVMs
{
    public partial class FrameworkOrderSearcher : BaseSearcher
    {
        [Display(Name = "订单编号")]
        public String FProductionCode { get; set; }
        [Display(Name = "货号Id")]
        public String FProductItemId { get; set; }
        [Display(Name = "订单状态")]
        public FOrderStatus? FOrderStatus { get; set; }
        [Display(Name = "计划时间")]
        public DateRange FPlanTime { get; set; }
        [Display(Name = "完成时间")]
        public DateRange FFinishTime { get; set; }

        protected override void InitVM()
        {
        }

    }
}
