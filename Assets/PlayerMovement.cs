using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody _myRigidbody;
    [SerializeField] float _speed = 2f;
    [SerializeField] InputProvider _inputs;

    Vector3 _movementVector;

    private void Awake()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputs.Inputs.Movement.HorizontalMovement.performed += MovementHandler;
        _inputs.Inputs.Movement.HorizontalMovement.canceled += MovementHandler;
    }

    private void MovementHandler(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            _movementVector = Vector3.zero;
        }
        else
        {
            _movementVector = context.ReadValue<Vector2>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector3 velocity = _myRigidbody.linearVelocity;
        velocity.x = _movementVector.x * _speed;
        velocity.z = _movementVector.y * _speed;
        _myRigidbody.linearVelocity = velocity;
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }
}
