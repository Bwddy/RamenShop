using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace RamenShop
{
    namespace Customs
    {
        public class RamenNoodles : CustomItem
        {
            public override string UniqueNameID => "RamenNoodles";

            public override GameObject Prefab => TestCubeManager.GetPrefab("RamenNoodles", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Wood - Default"), false);

            public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<RamenProvider>().GameDataObject;
        }
    }
}
