using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
    public Animator anim;
    public Vector3 movDir;
    private CharacterController _charC;
    public float speed = 5f, gravity = 20f, crouch = 2.5f, walk = 5f, run = 10f;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("isCrouching", 0);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("vertical", Input.GetAxis("Veritcal"));
        if (Input.GetAxis("Horizontal")>0.1||Input.GetAxis("Veritcal")>0.1)
        {
            
        }
        else
        {
            anim.SetFloat("moveSpeed", 0);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetFloat("isCrouching", 1);
        }
        else
        {
            anim.SetFloat("isCrouching", 0);
        }
        anim.SetFloat("moveSpeed", walk);

    }
}
