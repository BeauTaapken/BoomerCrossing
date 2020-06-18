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

    #region reset_on_unity_editor
#if UNITY_EDITOR
    private void OnEnable()
    {
        UnityEditor.EditorApplication.playModeStateChanged += EditorApplication_playModeStateChanged;
    }

    private void OnDisable()
    {
        UnityEditor.EditorApplication.playModeStateChanged -= EditorApplication_playModeStateChanged;
    }

    private void EditorApplication_playModeStateChanged(UnityEditor.PlayModeStateChange state)
    {
        playerList.players.Clear();
    }
#endif
    #endregion
    

    public void login()
    {
        string Name = userNameText.text;

        Player currentPlayer = playerList.players.Find(u => u.Name == Name);

        if (currentPlayer != null)
        {
            Debug.Log(currentPlayer.name + " " + currentPlayer.Skill);
            playerList.CurrentLoggedInPlayer = currentPlayer;
            selector.MainMenu();
        }
        else
        {
            player = Instantiate(player);
            player.Name = Name;
            playerList.CurrentLoggedInPlayer = player;
            playerList.players.Add(Instantiate(player));
            selector.SkillSelector(); 
        }
    }
}
