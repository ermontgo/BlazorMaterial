using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorMaterial
{
    public class BlazorMaterialComponent : BlazorComponent
    {
        [Parameter]
        protected string Class { get; set; }

        [Parameter]
        protected int? Elevation { get; set; }
    }
}
