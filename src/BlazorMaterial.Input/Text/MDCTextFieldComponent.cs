using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterial.Input.Text
{
    public class MDCTextFieldComponent : BlazorMaterialComponent
    {
        private static readonly ClassBuilder<MDCTextFieldComponent> _classNameBuilder;
        private const string ATTACH_FUNCTION = "BlazorMaterial.TextField.AttachTo";

        [Parameter]
        protected bool FullWidth { get; set; }

        [Parameter]
        protected bool Textarea { get; set; }

        [Parameter]
        protected bool Outlined { get; set; }

        [Parameter]
        protected bool Disabled { get; set; }

        [Parameter]
        protected bool Required { get; set; }

        [Parameter]
        protected string HelperText { get; set; }

        [Parameter]
        protected string Label { get; set; }

        [Parameter]
        protected string Watermark { get; set; }

        [Parameter]
        protected string IdPrefix { get; set; }

        [Parameter]
        protected string Value { get; set; }

        [Parameter]
        protected Action<string> ValueChanged { get; set; }

        protected string ClassString { get; private set; }
        protected ElementRef _MDCTextField;
        private bool _isFirstRender = true;

        static MDCTextFieldComponent()
        {
            _classNameBuilder = new ClassBuilder<MDCTextFieldComponent>("mdc", "text-field")
                .DefineClass("outlined", c => c.Outlined, PrefixSeparators.Modifier)
                .DefineClass("disabled", c => c.Disabled, PrefixSeparators.Modifier)
                .DefineClass("fullwidth", c => c.FullWidth, PrefixSeparators.Modifier);
        }

        protected string GetHelperAttributes()
        {
            if (!string.IsNullOrEmpty(this.HelperText))
            {
                return "textbox-helper-text";
            }
            else return null;
        }

        protected override void OnInit()
        {
            this.ClassString = _classNameBuilder.Build(this, this.Class);
        }

        protected void HandleValueChange(UIChangeEventArgs e)
        {
            string value = e.Value.ToString();
            this.ValueChanged?.Invoke(value);
        }

        protected override async void OnAfterRender()
        {
            if (this._isFirstRender)
            {
                this._isFirstRender = false;
                await JSRuntime.Current.InvokeAsync<bool>(ATTACH_FUNCTION, this._MDCTextField);
            }
        }
    }
}
