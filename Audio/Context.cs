using System;
namespace RKitchen.Audio
{
    public interface IAudioContext : IDisposable
    {
        string Name { get; }
        IAudioDevice ConnectNew(string desc, params object[] args);
        IAudioDevice ConnectExist(string desc);
        void DestroyDevice(string desc);
    }
}