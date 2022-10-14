namespace Builder
{
    /*
     * Builder
     * 
     * Il Builder è un'interfaccia oppure una classe astratta che ha il compito
     * di costruire le parti dell'oggetto Product.
     */
    abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public Pizza Pizza
        {
            get => _pizza;
        }

        public void CreateNewPizzaProduct()
        {
            _pizza = new Pizza();
        }

        public abstract void BuildDough();

        public abstract void BuildSauce();

        public abstract void BuildTopping();
    }
}
