using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
    public void getAnimatorDefalt(){
        this.GetComponent<Animator>().Play("Angry");
    }

    public void getAnimatorWalk(){
        this.GetComponent<Animator>().Play("Catwalk Idle To Walk Forward");
    }
}
