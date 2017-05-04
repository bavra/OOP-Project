class HumanPlayer : Player
{
    public override void Play(Game cellGrid)
    {
        cellGrid.CellGridState = new CellGridStateWaitingForInput(cellGrid);
    }
}