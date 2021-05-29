using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EpidemieSimulator.Components
{
    public partial class ComboBox
    {
        [Parameter]
        public List<string> Options { get; set; }

        [Parameter]
        public string InitValue { get; set; }

        protected override void OnInitialized()
        {
            if (!string.IsNullOrEmpty(InitValue))
            {
                SelectedItem = InitValue;
            }
            else
            {
                SelectedItem = Options[0];
            }
        }

        public int SelectedIndex
        {
            get => Options.IndexOf(SelectedItem);
        }

        public string SelectedItem { get; private set; }
        public bool DropDownState { get; set; } = false;

        public void ChangeDropDownState()
        {
            DropDownState = !DropDownState;
        }

        public async Task ChangeValue(string item)
        {
            SelectedItem = item;
            ChangeDropDownState();
            await InvokeAsync(StateHasChanged);
        }
    }
}