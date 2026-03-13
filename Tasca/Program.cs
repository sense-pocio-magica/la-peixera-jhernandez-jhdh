using System;
using System.Collections.Generic;

namespace Tasca;

internal class Program
{
    
    static void Main(string[] args)
    {
        int NumPeixNormal = 100;
        int NumTortugues = 6;
        int NumTaurons = 20;
        int NumPops = 15;
        
        Random rnd = new Random();
        List<Animal> animals = [];

        for (var i = 0; i < NumPeixNormal; i++)
        {
            animals.Add(new PeixNormal(Animal.Sexe.Mascle,rnd.Next(0,20),rnd.Next(0,20)));
            animals.Add(new PeixNormal(Animal.Sexe.Famella,rnd.Next(0,20),rnd.Next(0,20)));
        }
        
        for (var i = 0; i < NumTortugues; i++)
        {
            animals.Add(new Tortuga(Animal.Sexe.Mascle,rnd.Next(0,20),rnd.Next(0,20)));
            animals.Add(new Tortuga(Animal.Sexe.Famella,rnd.Next(0,20),rnd.Next(0,20)));
        }
        
        for (var i = 0; i < NumTaurons; i++)
        {
            animals.Add(new Tauro(Animal.Sexe.Mascle,rnd.Next(0,20),rnd.Next(0,20)));
            animals.Add(new Tauro(Animal.Sexe.Famella,rnd.Next(0,20),rnd.Next(0,20)));
        }
        
        for (var i = 0; i < NumPops; i++)
        {
            animals.Add(new Pop(Animal.Sexe.SolSexe,0,0));
        }
        
        var tauler = new Tauler(animals);
        tauler.ExecutaRondes();
        tauler.MostraResultats();
    }


    
}