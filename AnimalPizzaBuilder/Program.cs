using BuilderPattern.Models;
using BuilderPattern.Builders;
using static BuilderPattern.Models.Animal;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            //INIZIALIZZAZIONE OGGETTO SENZA BUILDER PATTERN

            //VERSIONE 1 (UNICO COMPLESSO COSTRUTTORE CON VALORI DI DEFAULT)

            Animal Verme = new Animal("Worm", 0, 45.8, 25.2, 0, false, false);

            //VERSIONE 2 (MOLTI OVERLOAD DEI COSTRUTTORI)

            Animal Cane = new Animal("Fido", Animal.Gender.MALE, 45.8, 25.2, 4);
            Animal Pesce = new Animal("Nemo", Animal.Gender.MALE, 45.8, 25.2, true);
            Animal Pappagallo = new Animal("Rio", Animal.Gender.MALE, 21.0, 8.00, 2, true);

            //VERSIONE CON BUILDER PATTERN

            //VERSIONE 1

            //istanzio direttamente animale lucertola
            //con il metodo build della classe AnimalBuilder
            //i campi non specificati verranno settati a valore di default
            Animal lucertola = AnimalBuilder.NewBuilder()
                .Name("Mario")
                .Sex(Animal.Gender.MALE)
                .Height(22.8)
                .Weight(18.2)
                .Legs(4)
                .Build();

            //VERSIONE 2

            //istanzio un builder dalla classe AnimalBuilder
            //con caratteristiche comuni a tutte le lucertole
            AnimalBuilder builderLucertola = AnimalBuilder.NewBuilder()
                .Name("Mario")
                .Sex(Animal.Gender.MALE)
                .Height(22.8)
                .Weight(18.2)
                .Legs(4);

            //istanzio un animale lucertola
            //con il metodo build dell'oggetto builderLucertola
            Animal lucertola2 = builderLucertola.Build();
            
            
            //istanzio una variante di lucertola con le ali utilizzando
            //come base il builderLucertola
            Animal lucertolaVolante = builderLucertola
                .Wings(true)
                .Build();

            //stampa
            Console.WriteLine(lucertola);
            Console.WriteLine(lucertolaVolante);



        }
    }
}
