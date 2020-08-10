using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Sentence 
{
    public enum Emplacement {Gauche, Droite, CentreGauche, CentreDroit }


    [Header("Les personnages présents")]
    [Tooltip("Le personnage principal, celui qui parle.")]
    public Character mainCharacter;
    [Tooltip("L'emplacement du personnage")]
    public Emplacement emplacementMain;

    //Les Autres personnages et leur emplacements. 

    [Space()]
    [Tooltip("Personnage secondaire, laisser vide si non utilisé.")]
    public Character character1;
    [Tooltip("L'emplacement du personnage")]
    public Emplacement emplacement1;

    [Space()]
    [Tooltip("Personnage secondaire, laisser vide si non utilisé.")]
    public Character character2;
    [Tooltip("L'emplacement du personnage")]
    public Emplacement emplacement2;

    [Space()]
    [Tooltip("Personnage secondaire, laisser vide si non utilisé.")]
    public Character character3;
    [Tooltip("L'emplacement du personnage")]
    public Emplacement emplacement3;

    [TextArea(3, 10)]
    public string phrase;




}
