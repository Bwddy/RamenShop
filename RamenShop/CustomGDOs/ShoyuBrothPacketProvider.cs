using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using TestCubes;
using UnityEngine;

namespace RamenShop
{
    namespace Customs
    {
        public class ShoyuBrothPacketProvider : CustomAppliance
        {
            public override string UniqueNameID => "ShoyuBrothPacketProvider";

            public override GameObject Prefab => TestCubeManager.GetPrefab("ShoyuBrothPacketProvider", 1, 1, 1, MaterialUtils.GetExistingMaterial("Soy Sauce"));

            public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)> { ((Locale)1, new ApplianceInfo
            {
            Name = "Shoyu Broth Packets",
            Description = "Provides Shoyu Broth Packets",
            }) };

            public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { (IApplianceProperty)(object)KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<ShoyuBrothPacket>().GameDataObject.ID) };
        }
    }
}
