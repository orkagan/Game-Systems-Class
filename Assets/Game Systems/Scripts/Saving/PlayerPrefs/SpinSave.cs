using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSave : ExampleTextSaving
{
    // Start is called before the first frame update
    void Start()
    {
        Read();
        transform.rotation.SetEulerRotation(float.Parse(whatWeAreSaving[0]), float.Parse(whatWeAreSaving[1]), float.Parse(whatWeAreSaving[2]));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        whatWeAreSaving[0] = transform.rotation.x.ToString();
        whatWeAreSaving[1] = transform.rotation.y.ToString();
        whatWeAreSaving[2] = transform.rotation.z.ToString();
    }
}
