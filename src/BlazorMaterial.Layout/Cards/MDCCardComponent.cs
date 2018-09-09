using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterial.Layout.Cards
{
    public class MDCCardComponent : BlazorMaterialComponent
    {
        private static readonly ClassBuilder<MDCCardComponent> _classNameBuilder;
        [Parameter]
        protected bool Outlined { get; set; }
        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        protected string ClassString { get; private set; }

        static MDCCardComponent()
        {
            _classNameBuilder = new ClassBuilder<MDCCardComponent>("mdc", "card")
                .DefineClass("outlined", c => c.Outlined, PrefixSeparators.Modifier);
        }

        protected override void OnInit()
        {
            this.ClassString = _classNameBuilder.Build(this, this.Class);
        }
    }
}
