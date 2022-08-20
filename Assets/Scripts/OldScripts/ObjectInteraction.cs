using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject player;
    public float minDist = 2.0f;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - player.transform.position.x < minDist)
        {
            if (transform.position.y - player.transform.position.y < minDist)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                }
            }
        }
    }
}
