public class UnitStateNormal : UnitState
{
    public UnitStateNormal(SpaceShipUnits unit) : base(unit)
    {       
    }

    public override void Apply()
    {
        _unit.UnMark();
    }

    public override void MakeTransition(UnitState state)
    {
        state.Apply();
        _unit.UnitState = state;
    }
}

