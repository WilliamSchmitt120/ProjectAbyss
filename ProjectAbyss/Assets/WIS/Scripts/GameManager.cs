using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    
    
    
    //C'est le script qui va permettre de gérer le jeu. 

    //Les variables de positions pour savoir ou le joueur est en permanence et charger les bonnes scène et les bonnes informations.
    public enum PlayerGlobalPos { Abyss, Island}
    public PlayerGlobalPos playerCurrentGlobalPos;

    public IslandLocation PlayerCurrentPos;
    public AbyssLocation PlayerCurrentAbyssPos;


    public Interupteur[] Interupteurs;
   




    private void Awake()
    {
        
        if(instance != null)
        {

            Destroy(gameObject);

        } else
        {

            instance = this;
            DontDestroyOnLoad(gameObject);

        }

    }

    private void Start()
    {
        





    }


}
