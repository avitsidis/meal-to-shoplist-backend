using GraphQL.Types;

using MealToShopList.Models;

namespace MealToShopList.GraphQLApi.Types
{
    public class IngredientType : ObjectGraphType<Ingredient>
    {
        public IngredientType()
        {
            Name = "Ingredient";

            Field(h => h.Id).Description("The id of the ingredient");
            Field(h => h.Name);
            Field(h => h.Category);
        }
    }
}
