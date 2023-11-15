using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManagerScript : MonoBehaviour
{

    public GameObject manCloneTemplate;

    int numberOfMan = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfMan; i++) 
        {
            Vector3 poaition = new Vector3(
            Random.Range(-50f, 50f),
            0f,
            Random.Range(-50f, 50f));

            Instantiate(manCloneTemplate,poaition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(manCloneTemplate);
        }  
    }
}
