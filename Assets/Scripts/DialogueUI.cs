using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Following tutorial https://www.youtube.com/watch?v=RfLCzDzkvb0&t=426s

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text titleLabel;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private GameObject dialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        CloseDialogueBox();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowDialogue(DialogueObject dialogue)
    {
        if (dialogueBox.activeSelf)
        {
            CloseDialogueBox();
        } else { 
            titleLabel.text = dialogue.Title;
            textLabel.text = dialogue.Dialogue;
            dialogueBox.SetActive(true);
        }
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
        titleLabel.text = string.Empty;
    }
}
