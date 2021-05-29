using Microsoft.AspNetCore.Components;
using System;

namespace EpidemieSimulator.Components
{
    public partial class Dialog
    {
        [Parameter]
        public RenderFragment Caption { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Action { get; set; }

        [Parameter]
        public DialogTypes DialogType { get; set; }

        public enum DialogTypes
        {
            Custom
        }

        protected override void OnInitialized()
        {
            DialogState.NotifyComponents += OnNotifyComponent;
        }

        private void OnNotifyComponent(object sender, EventArgs e)
        {
            StateHasChanged();
        }
    }
}
