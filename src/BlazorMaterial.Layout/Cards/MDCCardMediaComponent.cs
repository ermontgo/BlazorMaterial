using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterial.Layout.Cards
{
    public class MDCCardMediaComponent : BlazorMaterialComponent
    {
        private static readonly ClassBuilder<MDCCardMediaComponent> _classNameBuilder;

        [Parameter]
        protected MDCCardMediaAspectRatio AspectRatio { get; set; }
        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        protected string ClassString { get; private set; }

        static MDCCardMediaComponent()
        {
            _classNameBuilder = new ClassBuilder<MDCCardMediaComponent>("mdc", "card", "media")
                .DefineClass("square", c => c.AspectRatio == MDCCardMediaAspectRatio.Square, PrefixSeparators.Modifier)
                .DefineClass("16-9", c => c.AspectRatio == MDCCardMediaAspectRatio.Square, PrefixSeparators.Modifier);
        }

        protected override void OnInit()
        {
            this.ClassString = _classNameBuilder.Build(this, this.Class);
        }
    }
}
