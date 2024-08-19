using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas;

public class Bacalao : CustomDish
{
    public sealed override DishType Type => DishType.Main;
    public override string UniqueNameID => "cata.Bacalao.dish";
    public sealed override List<string> StartingNameSet =>
    [
        "The dry fish",
        "Port Royal"
    ];
    
    // MinimumIngredients is used to decide which Items ( And providers ) will spawn when selecting this Dish.
    public override HashSet<Item> MinimumIngredients => new HashSet<Item>
    {
        (Item)GDOUtils.GetExistingGDO(ItemReferences.TomatoChopped),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.PotatoChopped),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.FishFilletRaw)
    };

    // RequiredProcesses is used to decide which Appliances to spawn when selecting this Dish.
    public override HashSet<Process> RequiredProcesses => new HashSet<Process>
    {
        (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
        (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook),   
    };
    
    // ResultingMenuItems is used to decide what Items Customers can order when this Dish is selected.
    // public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
    // {
    //     new Dish.MenuItem
    //     {
    //         Item = ,
    //         Phase = MenuPhase.Main,
    //         Weight = 0.5f,
    //         DynamicMenuType = DynamicMenuType.Static,
    //         DynamicMenuIngredient = (Item)GDOUtils.GetExistingGDO(ItemReferences.Apple)
    //     }
    // };
    
    // InfoList is used to add localisation to the Appliance.
    public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
    {
        (Locale.English, new UnlockInfo(
        {
            Name = "Bacalao",
            Description = "Portuguese dried cod in tomato soup, with potatoes.",
            FlavourText = "Looks tasty... yum."
        })
    };
    
    // Recipe is used to display the Recipe text when selecting this Dish.
    public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
    {
        {
            Locale.English,
            "Chop potatoes and tomatoes, Add fish, Boil in water, Serve!"
        }
    };

    // RequiredDishItem is used to decide what this Dish uses as a permanent Item ( ie. Plates )
    public override Item RequiredDishItem => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);

    // ColourOverride is used to override the pre-defined Colour in CardType.
    public override Color ColourOverride => Color.red;
}