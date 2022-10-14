using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    /*
     * Builder
     * 
     * Il Builder separa la costruzione di un oggetto complesso dalla sua
     * rappresentazione, cosicché il processo di costruzione stesso possa 
     * crearne diverse rappresentazioni.
     */
    public class AnimalBuilder
    {
        private string _name;

        private Animal.Gender _sex;

        private double _height;

        private double _weight;

        private int _legs;

        private bool _wings;

        private bool _fins;

        public static AnimalBuilder NewBuilder()
        {
            return new AnimalBuilder();
        }

        public AnimalBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public AnimalBuilder Sex(Animal.Gender sex)
        {
            _sex = sex;
            return this;
        }

        public AnimalBuilder Height(double height)
        {
            _height = height;
            return this;
        }

        public AnimalBuilder Weight(double weight)
        {
            _weight = weight;
            return this;
        }

        public AnimalBuilder Legs(int legs)
        {
            _legs = legs;
            return this;
        }

        public AnimalBuilder Wings(bool wings)
        {
            _wings = wings;
            return this;
        }

        public AnimalBuilder Fins(bool fins)
        {
            _fins = fins;
            return this;
        }

        public Animal Build()
        {
            return new Animal(_name, _sex, _weight, _height, _legs, _wings, _fins);
        }
    }
}
