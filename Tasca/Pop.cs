namespace Tasca;

public class Pop : Animal
{
    public Pop(Sexe sexe, int x, int y) : base(sexe, x, y)
    {
        
        int Lateral = random.Next(4);
        
        if (Lateral == 0)
        {
            X = 0;
            Y = random.Next(0, 20);
        }

        if (Lateral == 1)
        {
            X = 19;
            Y = random.Next(0, 20);
        }

        if (Lateral == 2)
        {
            X = random.Next(0, 20);
            Y = 0;
        }

        if (Lateral == 3)
        {
            X = random.Next(0, 20);
            Y = 19;
        }
        
    }
    
    public override Animal? DosAnimalsEsTroben(Animal altre)
    {
        if (altre is not Tauro)
        {
            CanviaDireccio();
        }
        return null;
    }

    public override void Mou()
    {
        base.Mou();
        
        
        if (X == 0 && Y == 19)
        {
            if (random.Next(2) == 0)
            {
                Direccio = new(1, 0);
            }
            else
            {
                Direccio = new(0, -1);
            }
        }

        if (X == 19 && Y == 19)
        {
            if (random.Next(2) == 0)
            {
                Direccio = new(0, -1);
            }
            else
            {
                Direccio = new(-1, 0);
            }
           
        }

        if (X == 19 && Y == 0)
        {
            if (random.Next(2) == 0)
            { 
                Direccio = new(-1, 0);
            }
            else
            {
                Direccio = new(0, 1);
            }
        }

        if (X == 0 && Y == 0)
        {
            if (random.Next(2) == 0)
            {
                Direccio = new(0, 1);

            }
            else
            {
                Direccio = new(1, 0);

            }
        }


    }
}