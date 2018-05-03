using Abp.Web.Mvc.Views;

namespace ZheXian.Web.Views
{
    public abstract class ZheXianWebViewPageBase : ZheXianWebViewPageBase<dynamic>
    {

    }

    public abstract class ZheXianWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ZheXianWebViewPageBase()
        {
            LocalizationSourceName = ZheXianConsts.LocalizationSourceName;
        }
    }
}