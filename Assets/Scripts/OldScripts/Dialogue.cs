using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Para que aparezca en el Inspector para editar
public class Dialogue 
{
    public string name;
    [TextArea(1, 3)]
    public string[] sentences;
}
