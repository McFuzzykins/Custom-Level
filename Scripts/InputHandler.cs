using UnityEngine;


public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private PlayerMovement _playerController;
    private Command _buttonA, _buttonD, _buttonS, _buttonW, _buttonSpace;

    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _playerController = FindObjectOfType<PlayerMovement>();

        _buttonA = new MoveLeft(_playerController);
        _buttonD = new MoveRight(_playerController);
        _buttonS = new MoveBackward(_playerController);
        _buttonW = new MoveForward(_playerController);
        _buttonSpace = new MoveUp(_playerController);
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            _invoker.ExecuteCommand(_buttonA);
        }

        if (Input.GetKey("d"))
        {
            _invoker.ExecuteCommand(_buttonD);
        }

        if (Input.GetKey("w"))
        {
            _invoker.ExecuteCommand(_buttonW);
        }

        if (Input.GetKey("s"))
        {
            _invoker.ExecuteCommand(_buttonS);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _invoker.ExecuteCommand(_buttonSpace);
        }
    }
}