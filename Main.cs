using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using BRI_Role.Roles;

namespace BRI_Role
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "MONCEF50G";
        public override string Name { get; } = "BRI Role";
        public override string Prefix { get; } = "bri_role";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(9, 4, 0);

        public static Plugin Instance;
        public BRIRole BriRole { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            BriRole = new BRIRole();
            BriRole.Register();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            BriRole?.Unregister();
            Instance = null;
            base.OnDisabled();
        }
    }
}