using System.Threading.Tasks;
using Abp.Application.Services;
using ZheXian.Configuration.Dto;

namespace ZheXian.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}