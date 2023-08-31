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
        public class UncookedRamenEggPot : CustomItemGroup
        {
            public override string UniqueNameID => "UncookedRamenEggPot";

            public override GameObject Prefab => TestCubeManager.GetPrefab("UncookedRamenEggPot", 0.5f, 0.5f, 0.5f, MaterialUtils.GetExistingMaterial("Soy Sauce"), false);
            public override string ColourBlindTag => "ReP";
            public override List<ItemSet> Sets => new List<ItemSet>
            {
            new ItemSet
            {
            Max = 2,
            Min = 2,
            Items = new List<Item>
            {
                (Item)GDOUtils.GetCustomGameDataObject<ShoyuBrothPot>().GameDataObject,
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg)

            },
            IsMandatory = true
            }
            };

            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook),
                Result = (Item)GDOUtils.GetCustomGameDataObject<RamenEggPot>().GameDataObject
            }
            };
        }
    }
}
