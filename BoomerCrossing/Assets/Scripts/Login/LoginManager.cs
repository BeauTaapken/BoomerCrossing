using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{

    public PlayerList playerList;

    public Player player;

    public TMP_InputField userNameText;

    public SceneSelector selector;

    private void Start()
    {
        if(playerList.players.Count > 0)
        {
            if (playerList.players[0] == null)
            {
                playerList.players.Clear();
            }
        }
      

        player = Instantiate(player);
    }

    public void login()
    {
        string Name = userNameText.text;

        Player currentPlayer = playerList.players.Find(u => u.Name == Name);

        if (currentPlayer != null)
        {
            Debug.Log(currentPlayer.Skill);
            playerList.CurrentLoggedInPlayer = currentPlayer;
            selector.MainMenu();
        }
        else
        {
            player.Name = Name;
            playerList.CurrentLoggedInPlayer = player;
            playerList.players.Add(Instantiate(player));
            selector.SkillSelector(); 
        }
    }
}
