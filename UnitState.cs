
public abstract class UnitState
{
    protected SpaceShipUnits _unit;

    public UnitState(SpaceShipUnits unit)
    {
        _unit = unit;
    }

    public abstract void Apply();
    public abstract void MakeTransition(UnitState state);
}

