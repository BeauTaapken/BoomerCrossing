using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillSetter : MonoBehaviour
{

    public PlayerList playerList;
    public SceneSelector selector;

    public void SetPlayerSKillToNew()
    {
        selector.MainMenu();
    }

    public void SetPlayerSKillToExperienced()
    {
        selector.MainMenu();
    }

}
