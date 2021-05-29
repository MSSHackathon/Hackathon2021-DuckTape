using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;

namespace EpidemieSimulator.Components
{
    public partial class InputField
    {
        private const string LiveSearchCSS = "pr-10";
        private const string ConfirmationSearchCSS = "pr-2";

        [Parameter]
        public string ButtonCaption { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public InputType Type { get; set; }

        [Parameter]
        public ButtonTypes ButtonType { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        private string _value;
        [Parameter]
        public string Value { get; set; }

        public string CSS
        {
            get
            {
                return Type switch
                {
                    InputType.LiveSearch => LiveSearchCSS,
                    InputType.ConfirmationSearch => ConfirmationSearchCSS,
                    InputType.Basic => "",
                    _ => throw new InvalidEnumArgumentException("Invalid InputType")
                };
            }
        }

        private void OnValueChanged(ChangeEventArgs e)
        {
            _value = e.Value.ToString();
            ValueChanged.InvokeAsync(_value);
        }
    }
}