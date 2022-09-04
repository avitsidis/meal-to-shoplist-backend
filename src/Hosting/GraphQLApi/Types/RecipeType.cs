using GraphQL.Types;

using MealToShopList.Models;

namespace MealToShopList.GraphQLApi.Types
{
    public class RecipeType : ObjectGraphType<Recipe>
    {
        public RecipeType()
        {
            Name = nameof(Recipe);

            Field(h => h.Id);
            Field(h => h.Name);
            Field<ListGraphType<IngredientType>,List<Ingredient>>(nameof(Recipe.Ingredients).ToLowerInvariant())
                .Resolve(ctx =>
                {
                    return ctx.Source.Ingredients;
                });
            Field(h => h.CreatedAt);
        }
    }
}
