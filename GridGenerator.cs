using System.Collections.Generic;
using UnityEngine;

public abstract class GridGenerator : MonoBehaviour
{
    public Transform CellsParent;
    public abstract List<Cell> GenerateGrid();
}

