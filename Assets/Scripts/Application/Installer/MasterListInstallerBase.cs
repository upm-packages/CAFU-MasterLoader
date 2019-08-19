using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace CAFU.MasterLoader.Application.Installer
{
    public abstract class MasterListInstallerBase<T> : MonoInstaller<MasterListInstallerBase<T>>
    {
        [SerializeField] private List<T> masters = default;
        private IEnumerable<T> Masters => masters;

        public override void InstallBindings()
        {
            Container.BindInstance(Masters).AsCached();
        }
    }
}