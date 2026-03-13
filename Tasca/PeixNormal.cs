using System;

namespace Tasca;

public class PeixNormal : Animal
{
    public PeixNormal(Sexe sexe, int x, int y) : base(sexe, x, y)
    {
    }


    public override Animal? DosAnimalsEsTroben(Animal altre)
    {
        if (altre is Tauro)
        {
            Mata();
        }
        else if (altre is PeixNormal)
        {
            if(genereSexe() == altre.genereSexe() )
                {
                Mata();
                altre.Mata();
                }
            else
            {
                Sexe sexeFill;
                if (random.Next(2) == 0)
                {
                    sexeFill = Sexe.Mascle;
                }
                else
                {
                    sexeFill = Sexe.Famella;
                }
                return new PeixNormal(sexeFill, X, Y);
            }
        }

        return null;
    }
}