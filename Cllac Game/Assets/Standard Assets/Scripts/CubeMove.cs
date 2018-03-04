using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CubeMove : NetworkBehaviour {

    private void Update()
    {
        transform.GetComponent<ConstantForce>().torque = new Vector3(0, 0, Input.GetAxis("Horizontal"));
    }
}
