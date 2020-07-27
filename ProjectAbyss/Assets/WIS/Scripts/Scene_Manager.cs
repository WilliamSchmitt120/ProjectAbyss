using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Manager : MonoBehaviour
{
    //Script qui gère la scène pour savoir ou es ce que l'on est et ce qu'il faut afficher ou non sur la scène.
    //Le Manager de la Scene.

    //Les Différents Etats dans laquelle on peut être dans la scène
    //Savoir ou l'on est, dans le dialogue de début, dans un des dialogue seoncdaires (tout les autres) et si l'on est entrain de choisir.

    

    public DialogueManager dialogueManager;

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {

        dialogueManager.StartDialogue(GameManager.instance.PlayerCurrentPos.defaultDialogue);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
