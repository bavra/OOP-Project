class CellGridStateWaitingForInput : CellGridState
{
    public CellGridStateWaitingForInput(Game cellGrid) : base(cellGrid)
    {
    }

    public override void OnUnitClicked(SpaceShipUnits unit)
    {
        if(unit.PlayerNumber.Equals(_cellGrid.CurrentPlayerNumber))
            _cellGrid.CellGridState = new CellGridStateUnitSelected(_cellGrid, unit); 
    }
}
