using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterial.Layout.Cards
{
    public class MDCCardActionComponent : BlazorMaterialComponent
    {
        private static readonly ClassBuilder<MDCCardActionComponent> _classNameBuilder;

        [Parameter]
        protected MDCCardActionType ActionType { get; set; }

        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        protected string ClassString { get; private set; }

        static MDCCardActionComponent()
        {
            _classNameBuilder = new ClassBuilder<MDCCardActionComponent>("mdc", "card", "action")
                .DefineClass("button", c => c.ActionType == MDCCardActionType.Button, PrefixSeparators.Modifier)
                .DefineClass("icon", c => c.ActionType == MDCCardActionType.Icon, PrefixSeparators.Modifier);
        }

        protected override void OnInit()
        {
            string additionalClassses = "mdc-button";

            if (this.ActionType == MDCCardActionType.Icon)
            {
                additionalClassses = "material-icons mdc-icon-button";
            }

            this.ClassString = $"{additionalClassses} {_classNameBuilder.Build(this, this.Class)}";
        }
    }
}
