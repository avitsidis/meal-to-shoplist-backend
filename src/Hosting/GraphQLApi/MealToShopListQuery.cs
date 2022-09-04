using GraphQL.Types;

using MealToShopList.Data;
using MealToShopList.GraphQLApi.Types;

namespace MealToShopList.GraphQLApi
{

    public class MealToShopListQuery : ObjectGraphType<object>
    {
        //probably some improvement needed (like using async)
        public MealToShopListQuery()
        {
            Name = "Query";
            Field<IngredientType>("ingredient")
                .Resolve(context =>
                {
                    var dbContext = context.RequestServices.GetService<MealToShopListDbContext>();
                    return dbContext.Ingredients.Find(1L);
                });



        }
    }
}
