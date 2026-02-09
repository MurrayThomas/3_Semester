using System;
using System.Collections.Generic;
using VirtualAbstractSolution.Model;

            // Instantiate

            // Insert animals in list
            List<Animal> animals = new List<Animal>() { dog1, cat1 };

            foreach(Animal ani in animals) {
                Console.WriteLine(ani);
    	Console.WriteLine(ani.PerformTrick());
   	 Console.WriteLine(ani.FeedAnimal());
            }
            Console.ReadLine();
