using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    
    
    
    //C'est le script qui va permettre de gérer le jeu. 

    //Les variables de positions pour savoir ou le joueur est en permanence
    
    public IslandLocation PlayerCurrentPos;

    //On stock les ojets qui affiche le fond et les perso afin de pouvoir les modifier a partir d'autre scripts.






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
