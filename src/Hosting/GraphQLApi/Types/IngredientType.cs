using GraphQL.Types;

using MealToShopList.Models;

namespace MealToShopList.GraphQLApi.Types
{
    public class IngredientType : ObjectGraphType<Ingredient>
    {
        public IngredientType()
        {
            Name = "Ingredient";

            Field(h => h.Id).Description("The id of the human.");
            Field(h => h.Name).Description("The name of the human.");

        }
    }
}
