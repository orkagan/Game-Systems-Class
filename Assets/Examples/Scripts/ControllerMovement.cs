using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ControllerMovement : MonoBehaviour
{
    public float speed = 5f;
    public CharacterController charCont;

    void Start()
    {
        charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        charCont.Move(Vector3.forward * speed * Time.deltaTime);
    }
}
