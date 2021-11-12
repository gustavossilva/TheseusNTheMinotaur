using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridMovement))]
public class PlayerMovement : MonoBehaviour
{

    private GridMovement _gridMovement;

    private void Start()
    {
        _gridMovement = GetComponent<GridMovement>();
    }

    private void Update()
    {
        if (!GameManager.Instance.playerMove) return;
        // Temporary for debug this should be removed (to use the new input system)
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_gridMovement.CanMove("up"))
            {
                transform.position += Vector3.up;
                GameManager.Instance.PlayerMovement();
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (_gridMovement.CanMove("down"))
            {
                transform.position += Vector3.down;
                GameManager.Instance.PlayerMovement();
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (_gridMovement.CanMove("left"))
            {
                transform.position += Vector3.left;
                GameManager.Instance.PlayerMovement();
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (_gridMovement.CanMove("right"))
            {
                transform.position += Vector3.right;
                GameManager.Instance.PlayerMovement();
            }
        }
    }
}
