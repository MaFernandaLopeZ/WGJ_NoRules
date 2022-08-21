using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Siguiendo tutorial https://www.youtube.com/watch?v=_nRzoTzeyxU

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting dialogue with" + dialogue.name);
        sentences.Clear(); // Eliminamos lo que tenga sentences antes de esto
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }

}
