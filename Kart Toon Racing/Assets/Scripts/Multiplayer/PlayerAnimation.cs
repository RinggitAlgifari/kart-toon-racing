using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    private Animator anim;

	void Awake () {
        anim = GetComponent<Animator>();
	}
	
    public void Walk(bool walk) {
        anim.SetBool("Walk", walk);
    }

    public void Fall() {
        anim.SetTrigger("Fall");
    }

    public void Celeb() {
        anim.SetTrigger("Celeb");
    }

    public void Attack() {
        anim.SetTrigger("Attack");
    }


} // class






















