using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatController : MonoBehaviour
{

    public static StatController instance;

    private EquipementController equipementController;

    //Les différentes statistiques du joueur.

    public float statDefense;

    public int statDefenseBase;
    public float statDefenseMultiplicator;
    public int statDefenseFlat;

    public float statAttack;

    public int statAttackBase;
    public float statAttackMultiplicator;
    public int statAttackFlat;

    public float statSpeed;

    public int statSpeedBase;
    public float statSpeedMultiplicator;
    public int statSpeedFlat;

    public float statAir;

    public int statAirBase;
    public float statAirMultiplicator;
    public int statAirFlat;

    private void Awake()
    {
        if (instance != null)
        {

            Destroy(gameObject);

        }
        else
        {

            instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }

    private void Start()
    {
        equipementController = EquipementController.instance;


        ActualiseStats();




    }



    //Fonction qui fait le calcul des statististiques en fonction des différents bonus appelée a chaque fois que l'inventaire est modifié.
    public void ActualiseStats()
    {

        statDefense = (statDefenseBase * statDefenseMultiplicator) + statDefenseFlat;

        statAttack = (statAttackBase * statAttackMultiplicator) + statAttackFlat;

        statSpeed = (statSpeedBase * statSpeedMultiplicator) + statSpeedFlat;

        statAir = (statAirBase * statAirMultiplicator) + statAirFlat;

    }

    public void ActualiseStatsBonus()
    {


        statAttackBase = equipementController.equipementStatAttackBaseBonus;
        statAttackMultiplicator = equipementController.equipementStatAttackMultiplicatorBonus;
        statAttackFlat = equipementController.equipementStatAttackFlatBonus;

        statDefenseBase = equipementController.equipementStatDefenseBaseBonus;
        statDefenseMultiplicator = equipementController.equipementStatDefenseMultiplicatorBonus;
        statDefenseFlat = equipementController.equipementStatDefenseFlatBonus;

        statSpeedBase = equipementController.equipementStatSpeedBaseBonus;
        statSpeedMultiplicator = equipementController.equipementStatSpeedMultiplicatorBonus;
        statSpeedFlat = equipementController.equipementStatSpeedFlatBonus;

        statAirBase = equipementController.equipementStatAirBaseBonus;
        statAirMultiplicator = equipementController.equipementStatAirMultiplicatorBonus;
        statAirFlat = equipementController.equipementStatAirFlatBonus;

    }



}
