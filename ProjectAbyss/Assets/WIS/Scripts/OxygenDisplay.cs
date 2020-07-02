using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenDisplay : MonoBehaviour
{

    public float oxygen = 100f;
    public Text oxygenText;

    private void Update()
    {

        oxygenText.text = "Oxygen : " + oxygen + "%";

        


    }


}
