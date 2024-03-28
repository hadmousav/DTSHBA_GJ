using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{ 
    [SerializeField] PlayerMovement player;


    // Start is called before the first frame update
public void HandlePlayer()
    {
        player.ChangeAnimation();
    }
}
