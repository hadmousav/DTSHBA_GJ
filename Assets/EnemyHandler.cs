using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] GameObject realSprite;
    [SerializeField] GameObject acidSprite;
    [SerializeField] Enemy enemy;
    [SerializeField] float enemyAcidSpeed;
    [SerializeField] float enemyRealSpeed;
    bool acidbool = false;
    bool realbool = true;

    // Start is called before the first frame update
    public void HandleEnemy()
    {
        realbool = !realbool;
        acidbool = !acidbool;
        realSprite.SetActive(realbool);
        acidSprite.SetActive(acidbool);
    }
}
