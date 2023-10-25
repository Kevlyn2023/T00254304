using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManControlScript : MonoBehaviour
{
    Animator manAnimator;
    enum ManState { Idle, Follow, Attack}
    ManState currentlyIs;
    // Start is called before the first frame update
    void Start()
    {
     manAnimator = GetComponent<Animator>();

       
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case ManState.Idle:
                break;
                
            case ManState.Follow:
                break;
            case ManState.Attack:
                break;
        }



        manAnimator.SetBool("isWalking",true);
    }
}
