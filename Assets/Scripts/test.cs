using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private GridSystem grid,
        grid2;
    int count = 0;

    private void Start()
    {
        grid = new GridSystem(3, 4, 10f, new Vector3(20, 0, 0));
        grid2 = new GridSystem(5, 6, 5f, new Vector3(-20, 10));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(utils.GetMouseWorldPosition(0), ++count);
            grid2.SetValue(utils.GetMouseWorldPosition(0), ++count);
        }
    }
}
