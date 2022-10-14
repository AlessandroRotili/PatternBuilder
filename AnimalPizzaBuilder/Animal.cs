using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace BuilderPattern.Models
{
    /*
     * Product
     * 
     * La classe product rappresenta l'oggetto finale che si vuole costruire.
     */
    public class Animal
    {
        public enum Gender
        {
            MALE, FEMALE
        }

        public string Name { get; set; }

        public Gender Sex { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }
        public int Legs { get; set; }

        public bool Wings { get; set; }

        public bool Fins { get; set; }


        //COSTRUTTORE COMPLETO
        public Animal(string name, Gender sex, double height, double weight, int legs, bool wings, bool fins)
        {
            Name = name;
            Sex = sex;
            Height = height;
            Weight = weight;
            Legs = legs;
            Wings = wings;
            Fins = fins;
        }

        //COSTRUTTORE BASE
        public Animal(string name, Gender sex, double height, double weight)
        {
            Name = name;
            Sex = sex;
            Height = height;
            Weight = weight;
        }


        //COSTRUTTORE PESCI
        public Animal(string name, Gender sex, double height, double weight, bool fins)
        {
            Name = name;
            Sex = sex;
            Height = height;
            Weight = weight;
            Fins = fins;
        }

        //COSTRUTTORE UCCELLI
        public Animal(string name, Gender sex, double height, double weight, int legs, bool wings)
        {
            Name = name;
            Sex = sex;
            Height = height;
            Weight = weight;
            Legs = legs;
            Wings = wings;
        }

        //COSTRUTTORE CON ZAMPE
        public Animal(string name, Gender sex, double height, double weight, int legs)
        {
            Name = name;
            Sex = sex;
            Height = height;
            Weight = weight;
            Legs = legs;
        }

        public override string? ToString()
        {
            return $" Name = {Name}, Sex = {Sex}, Height = {Height}, Weight = {Weight}, Legs = {Legs}, Wings = {Wings}, Fins = {Fins};";
        }
    }
}
