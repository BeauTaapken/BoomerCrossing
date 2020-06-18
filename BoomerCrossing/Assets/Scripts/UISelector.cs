using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISelector : MonoBehaviour
{
    public GameObject BoomerUI;
    public GameObject ZoomerUI;
    public PlayerList playerList;
    public JoystickMovement JoystickMovement;

    // Start is called before the first frame update
    void Start()
    {
        if (playerList.CurrentLoggedInPlayer.Skill == PlayerSkill.NEW)
        {
            ZoomerUI.SetActive(false);
            BoomerUI.SetActive(true);
            Debug.Log("OK boomer");
            //TODO setup boomer controls
        }
        else if (playerList.CurrentLoggedInPlayer.Skill == PlayerSkill.EXPERIENCED)
        {
            BoomerUI.SetActive(false);
            ZoomerUI.SetActive(true);
            Debug.Log("Simp");
            JoystickMovement.Setup();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
