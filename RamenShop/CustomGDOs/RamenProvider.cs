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
        public class RamenProvider : CustomAppliance
        {
            public override string UniqueNameID => "RamenProvider";

            public override GameObject Prefab => TestCubeManager.GetPrefab("RamenProvider", 1, 1, 1, MaterialUtils.GetExistingMaterial("Wood - Default"));

            public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)> { ((Locale)1, new ApplianceInfo
            {
            Name = "RamenBox",
            Description = "Provides Ramen Noodles",
            }) };

            public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { (IApplianceProperty)(object)KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<RamenNoodles>().GameDataObject.ID) };
        }
    }
}
