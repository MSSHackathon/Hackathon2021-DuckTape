using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemieSimulator.Shared.Components
{
    public partial class Charts
    {
        [Parameter]
        public long MaxPopulation { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
        }
    }
}