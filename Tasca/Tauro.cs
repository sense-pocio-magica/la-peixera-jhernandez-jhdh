namespace Tasca;

public class Tauro : Animal
{
    private int Rondes = 0;

    public Tauro(Sexe sexe, int x, int y) : base(sexe, x, y) { }


    public void PassaRonda()
    {
        Rondes++;          
        if (Rondes >= 75)
        {
            Mata();
        }
    }
    public override Animal? DosAnimalsEsTroben(Animal altre)
    {
        if (altre is Tortuga)
        {
            CanviaDireccio();
        }
        else if (altre is Tauro)
        {
            if (genereSexe() == altre.genereSexe())
            {
                Mata();
                altre.Mata();
            }
            else
            {
                Sexe sexeFill = random.Next(2) == 0 ? Sexe.Mascle : Sexe.Famella;
                return new Tauro(sexeFill, X, Y);
            }
        }
        else
        {
            altre.Mata();
        }

        return null;
    }
}