using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoBlock ()
    {
        Animator anim = transform.GetComponent<Animator>();
        anim.SetTrigger("doBlock");
    }
}
