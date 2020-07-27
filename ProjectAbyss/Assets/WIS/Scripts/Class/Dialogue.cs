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
    [Header("End Choices")]

    public bool active01;
    public string choice01Name;
    public Dialogue choice01Dialogue;

    [Space()]
    public bool active02;
    public string choice02Name;
    public Dialogue choice02Dialogue;

    [Space()]
    public bool active03;
    public string choice03Name;
    public Dialogue choice03Dialogue;





}

