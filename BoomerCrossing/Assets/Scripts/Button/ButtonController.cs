using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public ScriptableButton scriptableButton;
    public Text text;
    public Image image;
    void Start()
    {
        ChangeUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(text.text != scriptableButton.name)
        {
            ChangeUI();
        }
    }
    private void ChangeUI()
    {
        text.text = scriptableButton.name;
        image.sprite = scriptableButton.image; 
    }
}
