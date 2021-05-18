﻿using BepInEx;
using WeylandMod.Core;

namespace WeylandMod.ExtendedServerPassword
{
    [BepInPlugin("WeylandMod.ExtendedServerPassword", "WeylandMod.ExtendedServerPassword", "1.5.0")]
    internal class ExtendedServerPasswordPlugin : BaseWeylandModPlugin
    {
        protected override IFeature CreateFeature() => new ExtendedServerPassword(Logger, Config);
    }
}