using KitchenData;
using KitchenLib.Customs;

namespace Bacaklavas;

public class Baklava : CustomDish
{
    public sealed override DishType Type { get; protected set; } = DishType.Dessert;
    public override string UniqueNameID { get; } = "cata.Baklava.dessert";
    public sealed override List<string> StartingNameSet { get; protected set; } =
    [
        "Delights and pastries"
    ];
}