// WTM默认页面 Wtm buidin page
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;

namespace WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkGroupVMs
{
    public class FrameworkGroupListVM : BasePagedListVM<FrameworkGroup, FrameworkGroupSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.Create, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.Edit, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.Delete, "", "管理",dialogWidth: 800),
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.BatchDelete, "","管理", dialogWidth: 800),
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.Import, "","管理", dialogWidth: 800),
                this.MakeAction("FrameworkGroup","DataFunction",Localizer["DataPrivilege"],Localizer["管理.DataPrivilege"], GridActionParameterTypesEnum.SingleId,"管理",800,null,null,x=>x.GroupCode).SetShowInRow(),
                this.MakeStandardAction("FrameworkGroup", GridActionStandardTypesEnum.ExportExcel, "","管理"),
            };
        }

        protected override IEnumerable<IGridColumn<FrameworkGroup>> InitGridHeader()
        {
            return new List<GridColumn<FrameworkGroup>>{
                this.MakeGridHeader(x => x.GroupCode, 120),
                this.MakeGridHeader(x => x.GroupName, 120),
                this.MakeGridHeader(x => x.GroupRemark),
                this.MakeGridHeaderAction(width: 300)
            };
        }

        public override IOrderedQueryable<FrameworkGroup> GetSearchQuery()
        {
            var query = DC.Set<FrameworkGroup>()
                .CheckContain(Searcher.GroupCode, x=>x.GroupCode)
                .CheckContain(Searcher.GroupName, x=>x.GroupName)
                .OrderBy(x => x.GroupCode);
            return query;
        }

    }
}
