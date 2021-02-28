using BepInEx.Configuration;
using UnityEngine;

namespace WeylandMod.Utils
{
    internal static class WeylandConfig
    {
        public static ServerConfig Server { get; private set; }

        public static PlayerConfig Player { get; private set; }

        public static SharedMapConfig SharedMap { get; private set; }

        public static ExtendedStorageConfig ExtendedStorage { get; private set; }

        public static void Init(ConfigFile config)
        {
            Server = new ServerConfig
            {
                SkipPasswordValidation = config.Bind(
                    nameof(Server),
                    "SkipPasswordValidation",
                    true,
                    "Let you launch public server without password."
                ),
                SkipPlayerPasswordOnPermit = config.Bind(
                    nameof(Server),
                    "SkipPlayerPasswordOnPermit",
                    true,
                    "Allow to log in to server without password if player in permittedlist.txt."
                ),
                RemoveSteamPassword = config.Bind(
                    nameof(Server),
                    "RemoveSteamPassword",
                    false,
                    "Remove steam password on login through Steam->View->Servers."
                ),
            };

            Player = new PlayerConfig
            {
                ManageableDeathMarkers = config.Bind(
                    nameof(Player),
                    "ManageableDeathMarkers",
                    true,
                    "Keep track of all your deaths and delete markers using right click."
                ),
            };

            SharedMap = new SharedMapConfig
            {
                SharedExplorationEnabled = config.Bind(
                    nameof(SharedMap),
                    "SharedExplorationEnabled",
                    true,
                    "Enable shared map exploration (implies ForcePublicPosition)."
                ),
                ForcePublicPosition = config.Bind(
                    nameof(SharedMap),
                    "ForcePublicPosition",
                    true,
                    "Force players public positions."
                ),
                SharedPinsEnabled = config.Bind(
                    nameof(SharedMap),
                    "SharedPinsEnabled",
                    true,
                    "Enable shared pins."
                ),
                SharedPinColor = config.Bind(
                    nameof(SharedMap),
                    "SharedPinColor",
                    new Color(0.7f, 0.7f, 1.0f),
                    "Color for shared pins from other players."
                ),
            };

            ExtendedStorage = new ExtendedStorageConfig
            {
                Enabled = config.Bind(
                    nameof(ExtendedStorage),
                    "Enabled",
                    false,
                    "Enable ExtendedStorage mod."
                ),
            };
        }

        public class ServerConfig
        {
            public ConfigEntry<bool> SkipPasswordValidation;
            public ConfigEntry<bool> SkipPlayerPasswordOnPermit;
            public ConfigEntry<bool> RemoveSteamPassword;
        }

        public class PlayerConfig
        {
            public ConfigEntry<bool> ManageableDeathMarkers;
        }

        public class SharedMapConfig
        {
            public ConfigEntry<bool> SharedExplorationEnabled;
            public ConfigEntry<bool> ForcePublicPosition;
            public ConfigEntry<bool> SharedPinsEnabled;
            public ConfigEntry<Color> SharedPinColor;
        }

        public class ExtendedStorageConfig
        {
            public ConfigEntry<bool> Enabled;
        }
    }
}