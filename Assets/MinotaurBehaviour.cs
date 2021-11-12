using UnityEngine;

[RequireComponent(typeof(GridMovement))]
public class MinotaurBehaviour : MonoBehaviour
{
    private GridMovement _gridMovement;
    // Add a player manager to get the references.
    [SerializeField] private GameObject _player;
    private int movementQtd = 2;

    private void Start()
    {
        _gridMovement = GetComponent<GridMovement>();
        GameManager.Instance.onPlayerMovementCallback += StartMovement;
    }

    private void StartMovement()
    {
        InvokeRepeating("MoveMinotaur", 0.5f, 0.5f);
    }

    private void MoveMinotaur()
    {
        if (transform.position.x > _player.transform.position.x && _gridMovement.CanMove("left"))
        {
            transform.position += Vector3.left;
        }
        else if (transform.position.x < _player.transform.position.x && _gridMovement.CanMove("right"))
        {
            transform.position += Vector3.right;
        }
        else if (transform.position.y < _player.transform.position.y && _gridMovement.CanMove("up"))
        {
            transform.position += Vector3.up;
        }
        else if (transform.position.y > _player.transform.position.y && _gridMovement.CanMove("down"))
        {
            transform.position += Vector3.down;
        }
        movementQtd--;
        if (movementQtd <= 0)
        {
            CancelInvoke();
            movementQtd = 2;
            GameManager.Instance.MinotaurMove();
        }
    }


}

