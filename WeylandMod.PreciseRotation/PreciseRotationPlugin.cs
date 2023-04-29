﻿using BepInEx;
using WeylandMod.Core;

namespace WeylandMod.PreciseRotation
{
    [BepInPlugin("WeylandMod.PreciseRotation", "WeylandMod.PreciseRotation", "1.6.1")]
    internal class PreciseRotationPlugin : BaseWeylandModPlugin
    {
        protected override IFeature CreateFeature() => new PreciseRotation(Logger, Config);
    }
}