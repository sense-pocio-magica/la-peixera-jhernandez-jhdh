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
    protected  (int X, int Y) Direccio;
    Sexe genere {get; set;}
    protected const int MidaTauler = 20;

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

    public void CanviaDireccio()
    {
        Direccio = Direccions[random.Next(Direccions.Length)];
    }

    public virtual void Mou()
    {
        
        X +=  Direccio.X;
        Y +=  Direccio.Y;
        
        if (X == MidaTauler) X = 0;
        if (Y == MidaTauler) Y = 0;
        if (X == -1) X = MidaTauler-1;
        if (Y == -1) Y = MidaTauler-1;
        
        
    }
}