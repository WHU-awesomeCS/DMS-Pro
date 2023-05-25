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
    public partial class FrameworkOrderBatchVM : BaseBatchVM<FrameworkOrder, FrameworkOrder_BatchEdit>
    {
        public FrameworkOrderBatchVM()
        {
            ListVM = new FrameworkOrderListVM();
            LinkedVM = new FrameworkOrder_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class FrameworkOrder_BatchEdit : BaseVM
    {
        [Display(Name = "订单编号")]
        public String FProductionCode { get; set; }
        [Display(Name = "货号Id")]
        public String FProductItemId { get; set; }
        [Display(Name = "订单状态")]
        public FOrderStatus? FOrderStatus { get; set; }
        [Display(Name = "计划生产数量")]
        public Int32? FPlanNumber { get; set; }
        [Display(Name = "计划时间")]
        public DateTime? FPlanTime { get; set; }
        [Display(Name = "完成时间")]
        public DateTime? FFinishTime { get; set; }
        [Display(Name = "OK数量")]
        public Int32? FOkNumber { get; set; }
        [Display(Name = "NG数量")]
        public Int32? FNgNumber { get; set; }
        [Display(Name = "在制品数量")]
        public Int32? FWorkingNumber { get; set; }
        [Display(Name = "报废品数量")]
        public Int32? FScrapNumber { get; set; }

        protected override void InitVM()
        {
        }

    }

}
