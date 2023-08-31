using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace RamenShop
{
    namespace Customs
    {
        public class ShoyuBroth : CustomItem
        {
            public override string UniqueNameID => "ShoyuBroth";

            public override GameObject Prefab => TestCubeManager.GetPrefab("ShoyuBrothPacket", 0.15f, 0.15f, 0.15f, MaterialUtils.GetExistingMaterial("Soy Sauce"), false);
        }
    }
}
