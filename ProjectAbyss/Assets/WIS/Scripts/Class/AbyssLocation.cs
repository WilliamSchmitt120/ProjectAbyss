using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Abyss Location", menuName = "Locations/AbyssLocation")]
public class AbyssLocation : ScriptableObject
{
    //La Classe qui gère les différents lieux dans lequel le joueur va pouvoir aller.

    //Donnée générales comme le nom.

    public new string name;



    public Sprite background; //Le fond qui sera mis en arrière plan.

    
    public GameObject levelDesign; //Le dialogue qui sera joué par défaut a l'arrivée dans la scène


}
