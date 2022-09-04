using GraphQL.Types;

using MealToShopList.GraphQLApi.Types;
using MealToShopList.Models;

namespace MealToShopList.GraphQLApi
{
    public class MealToShopListMutation : ObjectGraphType
    {
        public MealToShopListMutation()
        {
            Name = "Mutation";
            Field<IngredientType>(nameof(Ingredient));
        }
    }
}
