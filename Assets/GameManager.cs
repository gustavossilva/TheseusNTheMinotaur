using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridGenerator))]
public class GameManager : Singleton<GameManager>
{
    private GridGenerator gridGenerator;

    private Movements[,] gridLevelProof = {
        { Movements.Free, Movements.Right, Movements.Right, Movements.Right, Movements.Free },
        { Movements.Top, Movements.Free, Movements.Free, Movements.Top, Movements.Free },
        { Movements.Top, Movements.Top, Movements.Top, Movements.Top, Movements.Free },
        { Movements.Top, Movements.Right, Movements.Left, Movements.Top, Movements.Free },
        { Movements.Free, Movements.Top, Movements.Top, Movements.Left, Movements.Free },
        { Movements.Free, Movements.Free, Movements.Free, Movements.Free, Movements.Free }};


    //Make this features better
    public bool playerMove = true;
    public Movements[,] actualLevel;

    public delegate void OnPlayerMovement();
    public OnPlayerMovement onPlayerMovementCallback;

    // Start is called before the first frame update
    void Start()
    {
        gridGenerator = GetComponent<GridGenerator>();
        gridGenerator.GenerateBaseGrid(gridLevelProof);
        actualLevel = gridLevelProof;
    }

    public void MinotaurMove()
    {
        playerMove = true;
    }

    public void PlayerMovement()
    {
        playerMove = false;
        if (onPlayerMovementCallback != null)
        {
            onPlayerMovementCallback();
        }
    }
}
