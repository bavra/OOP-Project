using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomUnitGenerator : MonoBehaviour, IUnitGenerator
{
    public Transform UnitsParent;
    public Transform CellsParent;

    public List<SpaceShipUnits> SpawnUnits(List<Cell> cells)
    {
        List<SpaceShipUnits> ret = new List<SpaceShipUnits>();
        for (int i = 0; i < UnitsParent.childCount; i++)
        {
            var unit = UnitsParent.GetChild(i).GetComponent<SpaceShipUnits>();
            if(unit !=null)
            {
                var cell = cells.OrderBy(h => Math.Abs((h.transform.position - unit.transform.position).magnitude)).First();
                if (!cell.IsTaken)
                {
                    cell.IsTaken = true;
                    unit.Cell = cell;
                    unit.transform.position = cell.transform.position;
                    unit.Initialize();
                    ret.Add(unit);
                }
                else
                {
                    Destroy(unit.gameObject);
                }
            }
            else
            {
                Debug.LogError("Invalid object in Units Parent game object");
            }
            
        }
        return ret;
    }

    public void SnapToGrid()
    {
        List<Transform> cells = new List<Transform>();

        foreach(Transform cell in CellsParent)
        {
            cells.Add(cell);
        }

        foreach(Transform unit in UnitsParent)
        {
            var closestCell = cells.OrderBy(h => Math.Abs((h.transform.position - unit.transform.position).magnitude)).First();
            if (!closestCell.GetComponent<Cell>().IsTaken)
            {
                Vector3 offset = new Vector3(0,0, closestCell.GetComponent<Cell>().GetCellDimensions().z);
                unit.position = closestCell.transform.position - offset;
            }
        }
    }
}

