namespace Builder
{
    /*
     * Director
     * 
     * Il Director costruisce l'oggetto utilizzando l'interfaccia Builder.
     */
    class Cook
    {
        private PizzaBuilder _pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza Pizza
        {
            get => _pizzaBuilder.Pizza;
        }

        public void ConstructPizza()
        {

            _pizzaBuilder.CreateNewPizzaProduct();

            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();

        }
    }
}
