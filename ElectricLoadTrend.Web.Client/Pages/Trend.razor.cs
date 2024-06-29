using ElectricLoadTrend.Model;
using ElectricLoadTrend.Web.Client.Services;

using Microsoft.AspNetCore.Components;

namespace ElectricLoadTrend.Web.Client.Pages
{
    public partial class Trend :ComponentBase
    {
        private List<GenerationData>? GenerationDataList {get;set;}

        [Inject]
        private ITrendDataService TrendDataService {get;set;} =null!;

        protected override async Task OnInitializedAsync()
        {
            GenerationDataList = await TrendDataService.GetGenerationData();
            Console.WriteLine($"GenerationDataList Count - {GenerationDataList.Count}");
            base.OnInitialized();
        }
    }
}