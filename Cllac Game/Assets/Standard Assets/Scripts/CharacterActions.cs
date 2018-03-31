using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour {


    Animator anim;
	// Use this for initialization
	void Start () {
        anim = transform.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoBlock ()
    {
        anim.SetTrigger("doBlock");
    }

    public void DoDodge ()
    {
        anim.SetTrigger("doDodge");
    }
}
