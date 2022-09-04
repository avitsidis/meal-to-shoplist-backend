using GraphQL;
using GraphQL.Types;

using MealToShopList.Data;
using MealToShopList.GraphQLApi.Types;

using Microsoft.EntityFrameworkCore;

namespace MealToShopList.GraphQLApi
{

    public class MealToShopListQuery : ObjectGraphType<object>
    {

        private MealToShopListDbContext GetDb<T>(IResolveFieldContext<T> context)
        {
            return context.RequestServices.GetService<MealToShopListDbContext>();
        }

        //probably some improvement needed (like using async)
        public MealToShopListQuery()
        {
            Name = "Query";
            Field<IngredientType>("ingredient")
                .Argument<IdGraphType>("id")
                .Resolve(context =>
                {
                    var id = context.GetArgument<long>("id");
                    return GetDb(context).Ingredients.Find(id);
                });

            Field<ListGraphType<IngredientType>>("ingredients")
                .Resolve(context => GetDb(context).Ingredients.ToList());

            Field<ListGraphType<RecipeType>>("recipes")
                            .Resolve(context => GetDb(context).Recipes.Include(r => r.Ingredients).ToList());

            Field<ListGraphType<MealType>>("meals")
                            .Resolve(context => GetDb(context).Meals.Include(m => m.Recipe).Include(m=> m.Recipe.Ingredients).ToList());

            Field<ListGraphType<MealType>>("meal")
                .Argument<IdGraphType>("id")
                            .Resolve(context =>
                            {
                                var id = context.GetArgument<long>("id");
                                return GetDb(context).Meals.Find(id);
                            });


        }
    }
}
