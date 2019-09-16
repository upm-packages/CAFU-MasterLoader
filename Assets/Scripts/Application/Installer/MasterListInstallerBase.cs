using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace CAFU.MasterLoader.Application.Installer
{
    public abstract class MasterListInstallerBase<T> : ScriptableObjectInstaller<MasterListInstallerBase<T>>
    {
        [SerializeField] private List<T> masters = default;
        [UsedImplicitly] public IEnumerable<T> Masters => masters;

        public override void InstallBindings()
        {
            Container.BindInstance(Masters).AsCached();
        }
    }
}