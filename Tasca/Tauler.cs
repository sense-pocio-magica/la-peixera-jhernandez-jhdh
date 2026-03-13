using System.Collections.Generic;

namespace Tasca;

public class Tauler
{
    private List<Animal> LlistaAnimals;
    private List<Animal> LlistaFills = [];
    private int Rondes;
    
    public Tauler(List<Animal> llistaPeixos)
    {
        LlistaAnimals = llistaPeixos;
    }
    
    public void ExecutaRondes()
    {
        while (Rondes < 100)
        {
            Rondes++;
            
            foreach (var animal in LlistaAnimals)
            {
                animal.Mou();
            }
            
            for (int i = 0; i < LlistaAnimals.Count; i++)
            {
                for (int j = i + 1; j < LlistaAnimals.Count; j++)
                {
                    if (LlistaAnimals[i].X == LlistaAnimals[j].X && LlistaAnimals[i].Y == LlistaAnimals[j].Y)
                    {
                        Animal? fill = LlistaAnimals[i].DosAnimalsEsTroben(LlistaAnimals[j]);
                        if (fill != null)
                        {
                            LlistaFills.Add(fill);
                        }
                    }
                }
            }
            
            foreach (var fill in LlistaFills)
            {
                LlistaAnimals.Add(fill);
            }
            LlistaFills = [];
            
            foreach (var animal in LlistaAnimals)
            {
                if (animal is Tauro tauro)
                {
                    tauro.PassaRonda();
                }
            }
            
            LlistaAnimals.RemoveAll(animal => !animal.EstaViu());
        }
    }

    public void MostraResultats()
    {
        int peixos = 0, taurons = 0, pops = 0, tortugues = 0;
        foreach (var animal in LlistaAnimals)
        {
            if (animal is PeixNormal)
            {
                peixos++;
            }
            else if (animal is Tauro)
            {
                taurons++;
            }
            else if (animal is Pop)
            {
                pops++;
            }
            else if (animal is Tortuga)
            {
                tortugues++;
            }
        }
        Console.WriteLine($"Peixos normals: {peixos}");
        Console.WriteLine($"Taurons: {taurons}");
        Console.WriteLine($"Pops: {pops}");
        Console.WriteLine($"Tortugues: {tortugues}");
    }
}