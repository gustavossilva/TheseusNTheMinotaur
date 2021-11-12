using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    public bool CanMove(string position)
    {
        if (position == "up")
        {
            return (GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y] != Movements.Top &&
            GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y + 1] != Movements.Down);
        }
        if (position == "down")
        {
            return (GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y] != Movements.Down &&
            GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y - 1] != Movements.Top);
        }
        if (position == "left")
        {
            return (GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y] != Movements.Left &&
            GameManager.Instance.actualLevel[(int)transform.position.x - 1, (int)transform.position.y] != Movements.Right);
        }
        if (position == "right")
        {
            return (GameManager.Instance.actualLevel[(int)transform.position.x, (int)transform.position.y] != Movements.Right &&
            GameManager.Instance.actualLevel[(int)transform.position.x + 1, (int)transform.position.y] != Movements.Left);
        }
        return true;
    }
}
