using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbyssMapButton : MonoBehaviour
{
    //Script qui permet de changer de position sur l'île. En cliquant sur le bouton, on update la position du joueur
    //dans la variable associée au game manager puis on charge la scène.


    public AbyssLocation LocationToGo;

    public void GoToLocation()
    {


        GameManager.instance.PlayerCurrentAbyssPos = LocationToGo;


        SceneManager.LoadScene("Scene_Abyss");




    }

}
