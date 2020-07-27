using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Island Location", menuName = "Locations/IslandLocation")]
public class IslandLocation : ScriptableObject
{
    //La Classe qui gère les différents lieux dans lequel le joueur va pouvoir aller.

    //Donnée générales comme le nom.

    public new string name;



    public Sprite background;

    public Dialogue defaultDialogue;


}
