using System;

namespace Tasca;

public abstract class Animal
{
   
    public enum Sexe
    {
        Mascle,
        Famella,
        SolSexe
    }
    
    protected (int X, int Y)[] Direccions =
    {
        new(-1, 0),
        new(1,  0),
        new(0, -1),
        new(0,  1)
    };

    protected static readonly Random random = new();

    protected int X;
    protected int Y;
    protected bool Viu = true;
    private  (int X, int Y) Direccio;
    Sexe genere {get; set;}

    public Animal(Sexe sexe, int x, int y)
    {
        genere = sexe;
        X = x;
        Y = y;
        Direccio = Direccions[random.Next(Direccions.Length)];
    }

    public void Mata()
    {
        Viu = false;
    }

    public Sexe genereSexe()
    {
        return genere;
    }
    
    public abstract Animal? DosAnimalsEsTroben(Animal altre);
    

    public virtual void Mou()
    {
        if (X == 20) X = 0;
        if (Y == 20) Y = 0;
        if (X == -1) X = 19;
        if (Y == -1) Y = 19;
        
        
        X +=  Direccio.X;
        Y +=  Direccio.Y;
        
    }
}