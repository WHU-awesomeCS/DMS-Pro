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
    public partial class FrameworkProductItemBatchVM : BaseBatchVM<FrameworkProductItem, FrameworkProductItem_BatchEdit>
    {
        public FrameworkProductItemBatchVM()
        {
            ListVM = new FrameworkProductItemListVM();
            LinkedVM = new FrameworkProductItem_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class FrameworkProductItem_BatchEdit : BaseVM
    {
        [Display(Name = "货号名称")]
        public String FName { get; set; }
        [Display(Name = "货号编码")]
        public String FCode { get; set; }
        [Display(Name = "产品型号")]
        public Int32? FProductTypeId { get; set; }
        [Display(Name = "工艺路线")]
        public Int32? FWorkLineId { get; set; }

        protected override void InitVM()
        {
        }

    }

}
