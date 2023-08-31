using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace RamenShop
{
    namespace Customs
    {
        public class ShoyuBrothPacket : CustomItem
        {
            public override string UniqueNameID => "ShoyuBrothPacket";

            public override GameObject Prefab => TestCubeManager.GetPrefab("ShoyuBrothPacket", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Soy Sauce"), false);

            public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<ShoyuBrothPacketProvider>().GameDataObject;
        }
    }
}
