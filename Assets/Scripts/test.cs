using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    private HeatMapVisual heatMapVisual;

    private GridSystem grid;

    private void Start()
    {
        grid = new GridSystem(20, 10, 10f, Vector3.zero);
        heatMapVisual.SetGrid(grid);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = utils.GetMouseWorldPosition(0);
            int value = grid.GetValue(position);
            grid.SetValue(position, value + 5);
        }
    }
}
