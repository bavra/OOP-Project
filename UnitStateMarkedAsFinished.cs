﻿public class UnitStateMarkedAsFinished : UnitState
{
    public UnitStateMarkedAsFinished(SpaceShipUnits unit) : base(unit)
    {      
    }

    public override void Apply()
    {
        _unit.MarkAsFinished();
    }

    public override void MakeTransition(UnitState state)
    {
        if(state is UnitStateNormal)
        {
            state.Apply();
            _unit.UnitState = state;
        }
    }
}
