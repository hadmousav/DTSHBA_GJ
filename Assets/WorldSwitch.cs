using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    [SerializeField] GameObject acid;
    [SerializeField] GameObject real;
    [SerializeField] PlayerHandler playerHandler;
    [SerializeField] EnemyHandler enemyHandler;

    bool acidbool = false;
    bool realbool = true;
    // Start is called before the first frame update
    void Start()
    {
        real.SetActive(realbool);
        acid.SetActive(acidbool);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeWorld();
    }

    private  void ChangeWorld()
    {
        HandleEnvoirement();
        HandleEnemy();
        playerHandler.HandlePlayer();
        enemyHandler.HandleEnemy();
    }
    private void HandleEnvoirement()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            realbool = !realbool;
            acidbool = !acidbool;
            real.SetActive(realbool);
            acid.SetActive(acidbool);

        }
    }
    private void HandleEnemy()
    {
        
    }

}
