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
    public partial class FrameworkOrderTemplateVM : BaseTemplateVM
    {
        [Display(Name = "订单编号")]
        public ExcelPropety FProductionCode_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FProductionCode);
        [Display(Name = "货号Id")]
        public ExcelPropety FProductItemId_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FProductItemId);
        [Display(Name = "订单状态")]
        public ExcelPropety FOrderStatus_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FOrderStatus);
        [Display(Name = "计划生产数量")]
        public ExcelPropety FPlanNumber_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FPlanNumber);
        [Display(Name = "计划时间")]
        public ExcelPropety FPlanTime_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FPlanTime);
        [Display(Name = "完成时间")]
        public ExcelPropety FFinishTime_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FFinishTime);
        [Display(Name = "OK数量")]
        public ExcelPropety FOkNumber_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FOkNumber);
        [Display(Name = "NG数量")]
        public ExcelPropety FNgNumber_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FNgNumber);
        [Display(Name = "在制品数量")]
        public ExcelPropety FWorkingNumber_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FWorkingNumber);
        [Display(Name = "报废品数量")]
        public ExcelPropety FScrapNumber_Excel = ExcelPropety.CreateProperty<FrameworkOrder>(x => x.FScrapNumber);

	    protected override void InitVM()
        {
        }

    }

    public class FrameworkOrderImportVM : BaseImportVM<FrameworkOrderTemplateVM, FrameworkOrder>
    {

    }

}
