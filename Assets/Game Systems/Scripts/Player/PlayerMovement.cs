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
    public Animator anim;

    [Header("Character Speeds")]
    public float jumpSpeed = 4f;
    public float speed = 20f, gravity = 20f, crouch = 2.5f, walk = 5f, run = 10f;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _charC = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GameManagerInstance.gameState == GameStates.GameState)
        {
            if (_charC.isGrounded)
            {
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                //inputs to change the speed
                anim.SetFloat("isCrouched", 0); //jank and stupid place for this lol
                if (Input.GetButton("Sprint"))
                {
                    speed = run;
                }
                else if (Input.GetButton("Crouch"))
                {
                    speed = crouch;
                    anim.SetFloat("isCrouched", 1); //if crouched it will override the jank
                }
                else
                {
                    speed = walk;
                }

                anim.SetFloat("horizontal", moveDir.x);
                anim.SetFloat("vertical", moveDir.y);
                anim.SetFloat("moveSpeed", _charC.velocity.magnitude);

                if (Input.GetButtonDown("Jump"))
                {
                    moveDir.y += jumpSpeed;
                }
            }
            moveDir.y -= gravity*Time.deltaTime;
            _charC.Move(transform.TransformDirection(moveDir) * speed * Time.deltaTime);
        }
    }
}
