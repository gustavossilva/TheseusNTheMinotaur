using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject blockLeft;
    [SerializeField] private GameObject blockRight;
    [SerializeField] private GameObject blockTop;
    [SerializeField] private GameObject blockDown;


    public void Initialize(Movements blockValue)
    {
        if (blockValue == Movements.Left)
        {
            blockLeft.SetActive(true);
        }
        if (blockValue == Movements.Right)
        {
            blockRight.SetActive(true);
        }
        if (blockValue == Movements.Top)
        {
            blockTop.SetActive(true);
        }
        if (blockValue == Movements.Down)
        {
            blockDown.SetActive(true);
        }
    }
}
