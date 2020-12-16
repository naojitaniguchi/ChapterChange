using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByButtonPushed : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPushed()
    {
        target.SetActive(true);
    }
}
