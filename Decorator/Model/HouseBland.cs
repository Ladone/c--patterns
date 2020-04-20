namespace Decorator.Model
{
    public class HouseBland: Beverage
    {
        public HouseBland()
        {
            description = "House Blend Coffee";
        }
        
        public override double Cost()
        {
            return .89;
        }
    }
}