using Microsoft.AspNetCore.Components;

namespace EpidemieSimulator.Components
{
    public partial class CheckBox
    {
        [Parameter]
        public string Caption { get; set; }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Caption))
            {
                Caption = "Caption";
            }
        }

        public bool CheckBoxState { get; set; } = false;

        public void ToggleCheckBoxState()
        {
            CheckBoxState = !CheckBoxState;
        }
    }
}