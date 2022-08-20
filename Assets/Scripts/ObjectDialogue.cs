using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObjectDialogue : MonoBehaviour
{
    public GameObject player;
    public float minDist = 2.0f;
    public DialogueObject dialogue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform.position.x - player.transform.position.x) < minDist && Math.Abs(transform.position.y - player.transform.position.y) < minDist)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueUI>().ShowDialogue(dialogue);
            }
        }
    }
}
