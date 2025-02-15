/// هذا البلغن محروس وميقن بحقوق الطبع والنشر اي تقليد او سرقة ستتلقى عقوبات مالية او قانونية من المالك moncef50g
/// ايضا تابع لشركة dzarenafixers
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using InventorySystem.Items.Keycards;
using PlayerRoles;

namespace BRI_Role.Roles
{
    public class BRIRole : CustomRole
    {
        public override uint Id { get; set; } = 20; // رقم تعريفي فريد للدور
        public override string Name { get; set; } = "BRI"; /// <سم الدور>
                                                           
        public override string Description { get; set; } = ".ﻯﺮﺧﻷﺍ ﺕﺍﺪﻳﺪﻬﺘﻟﺍﻭ Class-D ﻦﻣ ﺀﺎﻤﻠﻌﻟﺍ ﺔﻳﺎﻤﺣ ﻚﺘﻤﻬﻣ";
        public override string CustomInfo { get; set; }
        public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard; // الدور الأساسي
        public override int MaxHealth { get; set; } = 120; // صحة زائدة قليلاً
        public override bool KeepInventoryOnSpawn { get; set; } = false;
        public bool RemoveRoleOnDeath { get; set; } = true;

        public override List<string> Inventory { get; set; } = new()
        {
            "GunCrossvec",  // مسدس خفيف
            "Keycardguard",  // بطاقة `Guard`
            "ArmorLight",  // درع خفيف
            "SCP500",  // SCP-500 للعلاج السريع
            "Radio",  // راديو للتواصل مع الـ MTF
            "SCP1853", // يادة سرعة الحمل ومزايا اخرى
            "ammo9x19", // يادة سرعة الحمل ومزايا اخرى

        };
 
        protected void OnRoleGiven(Player player)
        {
            base.RoleAdded(player);
            
            player.Broadcast(10, "<color=blue>.ﺕﺍﺪﻳﺪﻬﺘﻟﺍ ﻦﻣ ﺀﺎﻤﻠﻌﻟﺍ ﺔﻳﺎﻤﺣ ﻚﺘﻤﻬﻣ  BRI! ﻥﻵﺍ ﺖﻧﺃ</color>");
            Log.Info($"{player.Nickname} .BRI ـﻛ ﻪﻨﻴﻴﻌﺗ ﻢﺗ");
        }

        protected void OnRoleRemoved(Player player)
        {
            base.RoleRemoved(player);
            player.Broadcast(5, "<color=red>BRI! ﺭﻭﺩ ﺕﺪﻘﻓ ﺪﻘﻟ</color>");
        }
    }
}