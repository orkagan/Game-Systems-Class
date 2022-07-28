using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barf : MonoBehaviour
{
    public GameObject particle;
    public float cooldown = 5;

    private GameObject barf;
    private bool barfing;

    
    // Start is called before the first frame update
    void Start()
    {
        barfing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!barfing)
            {
                barfing = true;
            }
            else
            {
                barfing = false;
            }
        }

        if (barfing)
        {
            barf = Instantiate(particle, transform.position, Quaternion.identity);
            barf.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.2f, 1);
        }
    }
}
