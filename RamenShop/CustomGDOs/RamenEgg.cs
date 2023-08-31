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
        public class RamenEgg : CustomItem
        {
            public override string UniqueNameID => "RamenEgg";

            public override GameObject Prefab => TestCubeManager.GetPrefab("RamenEgg", 0.1f, 0.1f, 0.1f, MaterialUtils.GetExistingMaterial("Egg"), false);

            public override string ColourBlindTag => "RE";

            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<RamenEggCut>().GameDataObject
            }
            };
        }
    }
}
