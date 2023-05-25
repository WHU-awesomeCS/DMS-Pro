using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model;


namespace DormitoryManagementSystem.ViewModel._Product.FrameworkProductItemVMs
{
    public partial class FrameworkProductItemTemplateVM : BaseTemplateVM
    {
        [Display(Name = "货号名称")]
        public ExcelPropety FName_Excel = ExcelPropety.CreateProperty<FrameworkProductItem>(x => x.FName);
        [Display(Name = "货号编码")]
        public ExcelPropety FCode_Excel = ExcelPropety.CreateProperty<FrameworkProductItem>(x => x.FCode);
        [Display(Name = "产品型号")]
        public ExcelPropety FProductTypeId_Excel = ExcelPropety.CreateProperty<FrameworkProductItem>(x => x.FProductTypeId);
        [Display(Name = "工艺路线")]
        public ExcelPropety FWorkLineId_Excel = ExcelPropety.CreateProperty<FrameworkProductItem>(x => x.FWorkLineId);

	    protected override void InitVM()
        {
        }

    }

    public class FrameworkProductItemImportVM : BaseImportVM<FrameworkProductItemTemplateVM, FrameworkProductItem>
    {

    }

}
