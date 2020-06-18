using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillSetter : MonoBehaviour
{

    public PlayerList playerList;
    public SceneSelector selector;

    public void SetPlayerSKillToNew()
    {
        playerList.CurrentLoggedInPlayer.Skill = PlayerSkill.NEW;
        selector.MainMenu();
    }

    public void SetPlayerSKillToExperienced()
    {
        playerList.CurrentLoggedInPlayer.Skill = PlayerSkill.EXPERIENCED;
        selector.MainMenu();
    }

}
