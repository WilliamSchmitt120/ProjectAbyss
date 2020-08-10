using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Character", menuName = "Other/Character")]
public class Character : ScriptableObject
{
    //Class qui sert a définir les personnages pour qu'ils soient chargeables plus facilement a n'importe quel moment du jeu avec leur graphs, leur nom
    //et d'autres informations qui seraient nésséssaires


    public new string name;

    public Sprite image;



}
