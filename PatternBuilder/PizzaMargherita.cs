namespace Builder
{
    /*
     * ConcreteBuilder
     * 
     * Il ConcreteBuilder assembla le parti del Product implementando
     * l'interfaccia Builder.
     */
    class PizzaMargherita : PizzaBuilder
    {
        public override void BuildDough()
        {
            _pizza.Dough = "Soft";
        }

        public override void BuildSauce()
        {
            _pizza.Sauce = "Tomato";
        }

        public override void BuildTopping()
        {
            _pizza.Topping = "Mozzarella Cheese";
        }
    }
}
