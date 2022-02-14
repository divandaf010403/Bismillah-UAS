using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public GameObject gelasUkur;
    public GameObject spirtus;

    // Start is called before the first frame update
    void Start()
    {
        gelasUkur.SetActive(false);
        spirtus.SetActive(false);
    }

    public void ukur()
    {
        gelasUkur.SetActive(true);
        spirtus.SetActive(false);
    }

    public void kakiTiga()
    {
        gelasUkur.SetActive(false);
        spirtus.SetActive(true);
    }


}
