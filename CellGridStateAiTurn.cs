public class CellGridStateAiTurn : CellGridState
{
    public CellGridStateAiTurn(Game cellGrid) : base(cellGrid)
    {      
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();
        foreach (var cell in _cellGrid.Cells)
        {
            cell.UnMark();
        }
    }
}