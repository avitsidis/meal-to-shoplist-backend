using GraphQL.Instrumentation;
using GraphQL.Types;

namespace MealToShopList.GraphQLApi
{
    public class MealToShopListSchema : Schema
    {
        public MealToShopListSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = new MealToShopListQuery();
            Mutation = serviceProvider.GetService(typeof(MealToShopListMutation)) as MealToShopListMutation ?? throw new InvalidOperationException();

            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
