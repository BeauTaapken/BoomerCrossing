using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class PlayerList : ScriptableObject
{
    public List<Player> players = new List<Player>();
    public Player CurrentLoggedInPlayer;
}
