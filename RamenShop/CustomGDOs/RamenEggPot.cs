using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenLib.References;
using UnityEngine;
using TestCubes;
using System.Collections.Generic;
using static KitchenData.ItemGroup;
using IngredientLib.Ingredient.Items;
using static KitchenData.Item;

namespace RamenShop
{
    namespace Customs
    {
        public class RamenEggPot : CustomItem
        {
            public override string UniqueNameID => "RamenEggPot";

            public override GameObject Prefab => TestCubeManager.GetPrefab("RamenEggPot", 0.5f, 0.5f, 0.5f, MaterialUtils.GetExistingMaterial("Soy Sauce"), false);

            public override Item SplitSubItem => (Item)GDOUtils.GetCustomGameDataObject<RamenEgg>().GameDataObject;

            public new int SplitCount = 1;

            public override List<Item> SplitDepletedItems => new List<Item> { (Item)GDOUtils.GetCustomGameDataObject<ShoyuBrothPot>().GameDataObject };
        }
    }
}
