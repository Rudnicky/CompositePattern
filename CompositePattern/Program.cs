using CompositePattern.ECigaretteConcept;
using CompositePattern.MotorbikeConcept;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee example
            //Employee employee1 = new TeamMember("Paul", 8000);
            //Employee employee2 = new TeamMember("Jack", 30000);
            //Employee teamLeader = new TeamLeader("Marg", 750000);

            //teamLeader.Add(employee1);
            //teamLeader.Add(employee2);

            //Console.WriteLine(teamLeader.GetData());


            // Motorbike example
            //IMotorbike baseClass = new Motorbike();
            //IMotorbike customObject = baseClass;

            //customObject.StartEngine();
            //customObject = new Triumph(baseClass);
            //customObject.StartEngine();
            //customObject.PowerOnLights();
            //customObject = new HarleyDavidson(baseClass);
            //customObject.PowerOnLights();

            // ECigarette example
            IECigarette eCigarette = new ECigarette();
            Console.WriteLine("Price for regular cig: " + eCigarette.GetPrice().ToString());
            eCigarette = new Ego(eCigarette);
            Console.WriteLine("Price for Ego cig: " + eCigarette.GetPrice().ToString());
            eCigarette = new VapingShelter(eCigarette);
            Console.WriteLine("Price for VapingShelter cig: " + eCigarette.GetPrice().ToString());
            eCigarette = new TheatricalFake(eCigarette);
            Console.WriteLine("Price for TheatricalFake cig: " + eCigarette.GetPrice().ToString());

            Console.Read();
        }
    }
}
