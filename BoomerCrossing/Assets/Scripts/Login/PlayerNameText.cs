using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameText : MonoBehaviour
{
    public PlayerList playerlist;
    public TMP_Text userNameText;

    private void Start()
    {
        userNameText.text = playerlist.CurrentLoggedInPlayer.Name;
    }
}
