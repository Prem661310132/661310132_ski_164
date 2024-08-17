using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text notiText;
    public static MainUI instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
}
