using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;
using System.Collections.Generic;
using static KitchenData.Item;
using KitchenLib.References;

namespace RamenShop
{
    namespace Customs
    {
        public class HardBoiledEgg : CustomItem
        {
            public override string UniqueNameID => "HardBoiledEgg";

            public override GameObject Prefab => TestCubeManager.GetPrefab("HardBoiledEgg", 0.1f, 0.1f, 0.1f, MaterialUtils.GetExistingMaterial("Egg"), false);

            public override ItemValue ItemValue => ItemValue.Small;

            public override string ColourBlindTag => "HbE";

            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<HardBoiledEggShelled>().GameDataObject
            }
            };
        }
    }
}
