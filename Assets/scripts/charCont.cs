using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[ RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class charCont : MonoBehaviour
{
    private Movement1 _input;
    [SerializeField] private float fraction;
    private CharacterController _controller;
    private void Start() 
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<Movement1>();
    }

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
        _controller.Move(new Vector3(_input.moveVal.x * _input.moveSpeed/fraction, 0f, _input.moveVal.y * _input.moveSpeed/fraction));
    }
}
