namespace DotNetCoreKata.DomainModels.Overcooked.DuplicatedCode;

public class Pork
{
    public PorkCutlet Fry()
    {
        return new PorkCutlet(this);
    }
}

public class PorkCutlet(Pork pork)
{ }