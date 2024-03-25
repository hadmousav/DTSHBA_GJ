using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    [SerializeField] GameObject acid;
    [SerializeField] GameObject real;

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
        if (Input.GetKeyDown(KeyCode.F))
        {
             realbool= !realbool;
             acidbool= !acidbool;
            real.SetActive(realbool);
            acid.SetActive(acidbool);

        }
    }
}
