using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{ 
    [SerializeField] GameObject realSprite;
    [SerializeField] GameObject acidSprite;

    bool acidbool = false;
    bool realbool = true;

    // Start is called before the first frame update
public void HandlePlayer()
    {
        realbool = !realbool;
        acidbool = !acidbool;
        realSprite.SetActive(realbool);
        acidSprite.SetActive(acidbool);
    }
}
