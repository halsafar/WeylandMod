﻿using BepInEx;
using WeylandMod.Core;

namespace WeylandMod.ExtendedDeathPins
{
    [BepInPlugin("WeylandMod.ExtendedDeathPins", "WeylandMod.ExtendedDeathPins", "1.5.0")]
    internal class ExtendedDeathPinsPlugin : BaseWeylandModPlugin
    {
        protected override IFeature CreateFeature() => new ExtendedDeathPins(Logger, Config);
    }
}