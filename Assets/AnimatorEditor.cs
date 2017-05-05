using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEditor : MonoBehaviour {
    [SerializeField]
    Animator controller;

	void Update ()
    {
		if(Input.GetKey(KeyCode.Space))
        {
            controller.SetInteger("state", 2);
        }
        else
        {
            controller.SetInteger("state", 0);
        }
    }
}
