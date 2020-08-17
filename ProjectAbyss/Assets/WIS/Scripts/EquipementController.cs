using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipementController : MonoBehaviour
{

    public static EquipementController instance;

    private StatController statController;

    //Liste des Emplacements d'Equipements

    public Item weapon;
    public Item wetSuit;
    public Item respirator;
    public Item boots;
    public Item gloves;

    //Liste des Bonus Actuels Apportés par les équipements.

    [HideInInspector] public int equipementStatAttackBaseBonus;
    [HideInInspector] public float equipementStatAttackMultiplicatorBonus;
    [HideInInspector] public int equipementStatAttackFlatBonus;

    [HideInInspector] public int equipementStatDefenseBaseBonus;
    [HideInInspector] public float equipementStatDefenseMultiplicatorBonus;
    [HideInInspector] public int equipementStatDefenseFlatBonus;

    [HideInInspector] public int equipementStatSpeedBaseBonus;
    [HideInInspector] public float equipementStatSpeedMultiplicatorBonus;
    [HideInInspector] public int equipementStatSpeedFlatBonus;

    [HideInInspector] public int equipementStatAirBaseBonus;
    [HideInInspector] public float equipementStatAirMultiplicatorBonus;
    [HideInInspector] public int equipementStatAirFlatBonus;

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



    // Start is called before the first frame update
    void Start()
    {
        statController = StatController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EquipItem(Item item)
    {

        if (!item.isEquipement)
        {

            Debug.Log("Trying to add an Item witch is not a equipement !");
            return;

        }

        switch (item.equipementType)
        {
            case Item.EquipementType.Weapon:
                weapon = item;
                break;
            case Item.EquipementType.WetSuit:
                wetSuit = item;
                break;
            case Item.EquipementType.Respirator:
                respirator = item;
                break;
            case Item.EquipementType.Boots:
                boots = item;
                break;
            case Item.EquipementType.Gloves:
                gloves = item;
                break;
            default:
                break;
        }



    }

    private void ActualiseEquipementBonus()
    {

        equipementStatAttackBaseBonus = weapon.statAttackBaseBonus + wetSuit.statAttackBaseBonus + respirator.statAttackBaseBonus + boots.statAttackBaseBonus + gloves.statAttackBaseBonus;
        equipementStatAttackMultiplicatorBonus = weapon.statAttackMultiplicatorBonus + wetSuit.statAttackMultiplicatorBonus + respirator.statAttackMultiplicatorBonus + boots.statAttackBaseBonus + gloves.statAttackMultiplicatorBonus;
        equipementStatAttackFlatBonus = weapon.statAttackFlatBonus + wetSuit.statAttackFlatBonus + respirator.statAttackFlatBonus + boots.statAttackFlatBonus + gloves.statAttackFlatBonus;

        equipementStatDefenseBaseBonus = weapon.statDefenseBaseBonus + wetSuit.statDefenseBaseBonus + respirator.statDefenseBaseBonus + boots.statDefenseBaseBonus + gloves.statDefenseBaseBonus;
        equipementStatDefenseMultiplicatorBonus = weapon.statDefenseMultiplicatorBonus + wetSuit.statDefenseMultiplicatorBonus + respirator.statDefenseMultiplicatorBonus + boots.statDefenseMultiplicatorBonus + gloves.statDefenseMultiplicatorBonus;
        equipementStatDefenseFlatBonus = weapon.statDefenseFlatBonus + wetSuit.statDefenseFlatBonus + respirator.statDefenseFlatBonus + boots.statDefenseFlatBonus + gloves.statDefenseFlatBonus;

        equipementStatSpeedBaseBonus = weapon.statSpeedBaseBonus + wetSuit.statSpeedBaseBonus + respirator.statSpeedBaseBonus + boots.statSpeedBaseBonus + gloves.statSpeedBaseBonus;
        equipementStatSpeedMultiplicatorBonus = weapon.statSpeedMultiplicatorBonus + wetSuit.statSpeedMultiplicatorBonus + respirator.statSpeedMultiplicatorBonus + boots.statSpeedMultiplicatorBonus + gloves.statSpeedMultiplicatorBonus;
        equipementStatSpeedFlatBonus = weapon.statSpeedFlatBonus + wetSuit.statSpeedFlatBonus + respirator.statSpeedFlatBonus + boots.statSpeedFlatBonus + gloves.statSpeedFlatBonus;

        equipementStatAirBaseBonus = weapon.statAirBaseBonus + wetSuit.statAirBaseBonus + respirator.statAirBaseBonus + boots.statAirBaseBonus + gloves.statAirBaseBonus;
        equipementStatAirMultiplicatorBonus = weapon.statAirMultiplicatorBonus + wetSuit.statAirMultiplicatorBonus + respirator.statAirMultiplicatorBonus + boots.statAirMultiplicatorBonus + gloves.statAirMultiplicatorBonus;
        equipementStatAirFlatBonus = weapon.statAirFlatBonus + wetSuit.statAirFlatBonus + respirator.statAirFlatBonus + boots.statAirFlatBonus + gloves.statAirFlatBonus;

    }


}
