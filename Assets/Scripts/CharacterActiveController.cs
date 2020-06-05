﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CharacterState {
        // attacking a target
        Attacking,
        // see a nearby enemy and walking towards
        Homing,
        // walking forwards
        Walking
}

public class CharacterActiveController : MonoBehaviour
{
    CharacterController characterController;

    CharacterState currentState;
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentState = CharacterState.Walking;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState) {
            case CharacterState.Walking:
            characterController.SimpleMove(transform.TransformDirection(Vector3.forward) * speed);
                break;
            case CharacterState.Homing:
                break;
            case CharacterState.Attacking:
                break;
            default:
                break;
        }
    }
}
