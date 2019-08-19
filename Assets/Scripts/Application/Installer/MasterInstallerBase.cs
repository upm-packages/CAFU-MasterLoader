using UnityEngine;
using Zenject;

namespace CAFU.MasterLoader.Application.Installer
{
    public abstract class MasterInstallerBase<T> : MonoInstaller<MasterInstallerBase<T>>
    {
        [SerializeField] private T master = default;
        private T Master => master;

        public override void InstallBindings()
        {
            Container.BindInstance(Master).AsCached();
        }
    }
}