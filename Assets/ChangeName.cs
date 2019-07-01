using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
            textmeshPro.SetText("Hello World from Zach!");
        }
    }
}
