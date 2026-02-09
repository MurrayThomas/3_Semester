using System;

namespace VirtualAbstractSolution.Model {
    public abstract class Animal {

        protected Animal(string species, string breed) {
            Species = species;
            Breed = breed;
        }

        public string Species { get; set; }
        public string Breed { get; set; }

        public abstract string PerformTrick();

        public virtual string FeedAnimal()
        {
            return "Yum ";
        }

        public override string ToString() => $"{Species} - {Breed}";
    }
}
