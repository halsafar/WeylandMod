using BepInEx;
using WeylandMod.Core;

namespace WeylandMod.ExtendedStorage
{
    [BepInPlugin("WeylandMod.ExtendedStorage", "WeylandMod.ExtendedStorage", "1.6.1")]
    internal class ExtendedStoragePlugin : BaseWeylandModPlugin
    {
        protected override IFeature CreateFeature() => new ExtendedStorage(Logger, Config);
    }
}