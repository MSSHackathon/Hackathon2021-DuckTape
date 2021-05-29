using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;

namespace EpidemieSimulator.Components
{
    public partial class CustomButton
    {
        private const string BasicColor = "bg-gray-700 dark:bg-gray-500 " +
                                          "text-gray-200 dark:text-white";
        private const string ConfirmColor = "bg-green-500 hover:bg-green-400 text-gray-200 hover:text-white";
        private const string CancelColor = "bg-red-500 hover:bg-red-400 text-gray-200 hover:text-white";

        private const string DefaultSpacing = "my-3 px-4 py-2";

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public ButtonTypes Type { get; set; }

        [Parameter]
        public string MiscCSS { get; set; }

        [Parameter]
        public string SpacingCSS { get; set; } = DefaultSpacing;

        private string ColorCSS
        {
            get
            {
                return Type switch
                {
                    ButtonTypes.Basic => BasicColor,
                    ButtonTypes.Confirm => ConfirmColor,
                    ButtonTypes.Cancel => CancelColor,
                    _ => throw new InvalidEnumArgumentException("Invalid ButtonType")
                };
            }
        }
    }
}









