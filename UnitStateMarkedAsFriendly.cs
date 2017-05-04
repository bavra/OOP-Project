﻿public class UnitStateMarkedAsFriendly : UnitState
{
    public UnitStateMarkedAsFriendly(SpaceShipUnits unit) : base(unit)
    {
        
    }

    public override void Apply()
    {
        _unit.MarkAsFriendly();
    }

    public override void MakeTransition(UnitState state)
    {
        state.Apply();
        _unit.UnitState = state;
    }
}

