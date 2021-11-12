using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make it erase the rendered grid and renders the new one

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _tile;

    public void GenerateBaseGrid(Movements[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                GameObject instantiatedTile = (GameObject)Instantiate(_tile, new Vector3(i, j), Quaternion.identity);
                instantiatedTile.GetComponent<Tile>().Initialize(grid[i, j]);
                instantiatedTile.name = "Tile X:" + i + " Y:" + j;
            }
        }
    }
}
