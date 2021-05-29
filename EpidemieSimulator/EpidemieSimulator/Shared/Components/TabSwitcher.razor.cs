using Microsoft.AspNetCore.Components;

namespace EpidemieSimulator.Components
{
    public partial class TabSwitcher
    {
        private const string TabHeaderActiveCSS = "border-yellow-500";
        private const string TabHeaderInactiveCSS = "border-transparent";

        [Parameter]
        public string CSS { get; set; }

        [Parameter]
        public string TabHeaderCSS { get; set; }

        [Parameter]
        public string[] TabNames { get; set; }

        [Parameter]
        public int HighlightThickness { get; set; } = 2;

        [Parameter]
        public EventCallback<int> OnTabChanged { get; set; }

        private int SelectedIndex { get; set; }

    }
}
