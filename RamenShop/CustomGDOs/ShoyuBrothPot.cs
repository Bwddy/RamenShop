using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;
using System.Collections.Generic;
using KitchenLib.References;

namespace RamenShop
{
    namespace Customs
    {
        public class ShoyuBrothPot : CustomItem
        {
            public override string UniqueNameID => "ShoyuBrothPot";

            public override GameObject Prefab => TestCubeManager.GetPrefab("ShoyuBrothPot", 0.5f, 0.5f, 0.5f, MaterialUtils.GetExistingMaterial("Soy Sauce"), false);

            public override List<Item> SplitDepletedItems => new List<Item> { (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot) };
            public override Item SplitSubItem => (Item)GDOUtils.GetCustomGameDataObject<ShoyuBroth>().GameDataObject;

            public new int SplitCount = 8;
        }
    }
}
