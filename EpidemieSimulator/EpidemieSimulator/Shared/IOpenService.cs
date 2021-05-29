using System;

namespace EpidemieSimulator.Shared
{
    public interface IOpenService
    {
        public void Open();
        public void Close();
        public void Toggle();
        public bool Opened { get; }
        public event EventHandler NotifyComponents;
    }
}
