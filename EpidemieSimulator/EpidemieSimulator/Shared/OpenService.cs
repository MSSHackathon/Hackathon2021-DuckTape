using System;

namespace EpidemieSimulator.Shared
{
    public class OpenService : IOpenService
    {
        public bool Opened
        {
            get => _open;
            private set
            {
                _open = value;
                NotifyComponents.Invoke(this, null);
            }
        }

        public void Close()
        {
            Opened = false;
        }

        public void Open()
        {
            Opened = true;
        }

        public void Toggle()
        {
            Opened = !_open;
        }

        public event EventHandler NotifyComponents;

        protected bool _open = false;
    }
}