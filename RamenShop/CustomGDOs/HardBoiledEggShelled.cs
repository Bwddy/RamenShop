using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace RamenShop
{
    namespace Customs
    {
        public class HardBoiledEggShelled : CustomItem
        {
            public override string UniqueNameID => "HardBoiledEggShelled";

            public override GameObject Prefab => TestCubeManager.GetPrefab("HardBoiledEggShelled", 0.1f, 0.1f, 0.1f, MaterialUtils.GetExistingMaterial("Egg"), false);

            public override ItemValue ItemValue => ItemValue.Small;

            public override string ColourBlindTag => "HbEs";
        }
    }
}
