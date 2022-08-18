using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Game Systems/Player/Movement")]

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [Header("Character")]
    public Vector3 moveDir;
    private CharacterController _charC;

    [Header("Character Speeds")]
    public float jumpSpeed = 8f;
    public float speed = 5f, gravity = 20f, crouch = 2.5f, walk = 5, run = 10;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _charC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GameManagerInstance.gameState == GameStates.GameState)
        {
            if (_charC.isGrounded)
            {
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDir = transform.TransformDirection(moveDir);
                moveDir *= speed;

                if (Input.GetButtonDown("Jump"))
                {
                    moveDir.y = jumpSpeed;
                }
            }
            moveDir.y -= gravity*Time.deltaTime;
            _charC.Move(moveDir * Time.deltaTime);
        }
    }
}
