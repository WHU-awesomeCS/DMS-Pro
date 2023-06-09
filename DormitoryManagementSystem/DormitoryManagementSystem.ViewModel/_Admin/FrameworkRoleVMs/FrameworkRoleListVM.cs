// WTM默认页面 Wtm buidin page
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;

namespace WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkRoleVMs
{
    public class FrameworkRoleListVM : BasePagedListVM<FrameworkRole, FrameworkRoleSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.Create, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.Edit, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.Delete, "", "管理",dialogWidth: 800),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.Details, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.BatchDelete, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.Import, "","管理", dialogWidth: 800),
                this.MakeAction("FrameworkRole","PageFunction",Localizer["管理.PageFunction"],Localizer["管理.PageFunction"], GridActionParameterTypesEnum.SingleId,"管理",800).SetShowInRow(),
                this.MakeStandardAction("FrameworkRole", GridActionStandardTypesEnum.ExportExcel, "","管理"),
            };
        }

        protected override IEnumerable<IGridColumn<FrameworkRole>> InitGridHeader()
        {
            return new List<GridColumn<FrameworkRole>>{
                this.MakeGridHeader(x => x.RoleCode, 120),
                this.MakeGridHeader(x => x.RoleName, 120),
                this.MakeGridHeader(x => x.RoleRemark),
                this.MakeGridHeaderAction(width: 300)
            };
        }

        public override IOrderedQueryable<FrameworkRole> GetSearchQuery()
        {
            var query = DC.Set<FrameworkRole>()
                .CheckContain(Searcher.RoleCode,x=>x.RoleCode)
                .CheckContain(Searcher.RoleName,x=>x.RoleName)
                .OrderBy(x => x.RoleCode);
            return query;
        }

    }
}
