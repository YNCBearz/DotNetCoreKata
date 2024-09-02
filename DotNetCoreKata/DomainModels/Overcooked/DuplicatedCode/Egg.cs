namespace DotNetCoreKata.DomainModels.Overcooked.DuplicatedCode;

public class Egg
{
    public FiredEgg Fry()
    {
        return new FiredEgg(this);
    }
}

public class FiredEgg(Egg egg)
{ }