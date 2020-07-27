using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue")]
public class Dialogue : ScriptableObject
{
    //Objet qui stock un dialogue du jeu. Un dialogue est composé de plusieurs éléments.

    //Le nom du PNJ principal du dialogue (autre que le joueur).   
    public new string name;

    //Les Différentes phrases du dialogue, lues les unes aprés les autres;
    [TextArea(3, 10)]
    public string[] sentences;

    //Les différents personnages présents dans la scène et qui doivent être affichés.
    public Character[] characters;


    //Les Différents choix possible a la fin qui permettent de passer a un autre dialogue a spécifier.
    //Pour chaque choix, il faut indiquer s'il est actif (un choix incatif n'aparait pas), le nom affiché sur le bouton du choix (se peut être une petite phrase ou juste un mot) et enfin la dialogue que le choix va lancer.
    [Header("End Choices 01")]

    public bool active01;
    public string choice01Name;
    public Dialogue choice01Dialogue;

    [Space()]
    public bool condition01;
    public int interupteurTrigger01;

    [Header("End Choices 02")]
    public bool active02;
    public string choice02Name;
    public Dialogue choice02Dialogue;

    [Space()]
    public bool condition02;
    public int interupteurTrigger02;

    [Header("End Choices 03")]
    public bool active03;
    public string choice03Name;
    public Dialogue choice03Dialogue;

    [Space()]
    public bool condition03;
    public int interupteurTrigger03;

    public bool checkCondition(int choice)
    {
        switch (choice)
        {
            case 1:
                if (condition01 == false) { return true; }
                if (GameManager.instance.Interupteurs[interupteurTrigger01].state  == true) { return true; }
                break;

            case 2:
                if (condition02 == false) { return true; }
                if (GameManager.instance.Interupteurs[interupteurTrigger02].state == true) { return true; }
                break;

            case 3:
                if (condition03 == false) { return true; }
                if (GameManager.instance.Interupteurs[interupteurTrigger03].state == true) { return true; }
                break;

            default:
                break;
        }


        return false;

    }



}

