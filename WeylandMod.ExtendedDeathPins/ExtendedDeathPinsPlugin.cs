﻿using BepInEx;
using WeylandMod.Core;

namespace WeylandMod.ExtendedDeathPins
{
    [BepInPlugin("WeylandMod.ExtendedDeathPins", "WeylandMod.ExtendedDeathPins", "1.6.1")]
    internal class ExtendedDeathPinsPlugin : BaseWeylandModPlugin
    {
        protected override IFeature CreateFeature() => new ExtendedDeathPins(Logger, Config);
    }
}