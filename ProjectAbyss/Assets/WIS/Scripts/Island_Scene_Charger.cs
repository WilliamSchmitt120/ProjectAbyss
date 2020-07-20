using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Island_Scene_Charger : MonoBehaviour
{
    //Script qui gère le chargement de la scène

    public Image background;



    
    
    // Start is called before the first frame update
    void Start()
    {
        //On change le fond en fonction du lieu.

        ChangeBackground();





    }


    public void ChangeBackground()
    {

        background.sprite = GameManager.instance.PlayerCurrentPos.background;



    }


}
