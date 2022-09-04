using GraphQL.Types;

using MealToShopList.Models;

using System.Xml.Linq;

namespace MealToShopList.GraphQLApi.Types
{
    public class MealType : ObjectGraphType<Meal>
    {
        public MealType()
        {
            Name = nameof(Meal);

            Field(h => h.Id);
            Field(h => h.MealTime);
            Field(h => h.DayOfWeek);
            Field<RecipeType,Recipe>("recipe").Resolve(ctx => ctx.Source.Recipe);
        }
    }
}
