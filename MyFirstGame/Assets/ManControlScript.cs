using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManControlScript : MonoBehaviour
{
    Control player;
    Animator manAnimator;
    enum ManState { Idle, Follow, Attack }
    ManState currentlyIs = ManState.Idle;
    private float aggroRadius = 10;
    private float walkingSpeed = 0.3f;
    private float meleeDistance = 1;



    // Start is called before the first frame update
    void Start()
    {
        manAnimator = GetComponent<Animator>();
        player = FindObjectOfType<Control>();

    }



    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case ManState.Idle:

                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ManState.Follow;
                    manAnimator.SetBool("isWalking", true);


                }


                break;

            case ManState.Attack:


                break;

            case ManState.Follow:
                transform.LookAt(player.transform.position);
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;


                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)
                {
                    //currentlyIs = ManState.Attack;
                }
                break;
        }


    }
}
