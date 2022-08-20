using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Dialogue/DialogueObject")] // Para que aparezca al hacer click derecho > Create sobre el Project window

public class DialogueObject : ScriptableObject
{
    [SerializeField] private string title;
    [SerializeField] [TextArea] private string dialogue;
    public string Title => title;
    public string Dialogue => dialogue; // Para que el script DialogueUI pueda acceder a él sin editarlo (manteniendolo privado)
}
