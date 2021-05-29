using Microsoft.AspNetCore.Components;
using System.Timers;

namespace EpidemieSimulator.Components
{
    public partial class Sidebar
    {
        [Parameter]
        public RenderFragment Content { get; set; }

        private Timer _animationTimer = new();

        private double AnimationDuration
        {
            get
            {
                return !SidebarState.Opened ? 800 : 1;
            }
        }

        private bool _contentHidden;

        protected override void OnInitialized()
        {
            _animationTimer.Elapsed += OnAnimationTimerComplete;
            _contentHidden = !SidebarState.Opened;
            SidebarState.NotifyComponents += OnNotifyComponents;
        }

        private void OnNotifyComponents(object sender, System.EventArgs e)
        {
            StateHasChanged();
        }

        private void ToggleSidebar()
        {
            SidebarState.Toggle();
            _animationTimer.Interval = AnimationDuration;
            _animationTimer.Start();
        }

        private void OnAnimationTimerComplete(object source, ElapsedEventArgs e)
        {
            _contentHidden = !SidebarState.Opened;
            _animationTimer.Stop();
            InvokeAsync(StateHasChanged);
        }
    }
}