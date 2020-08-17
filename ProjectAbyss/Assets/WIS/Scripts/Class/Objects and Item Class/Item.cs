using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{

    public enum EquipementType { Weapon, WetSuit, Respirator, Boots, Gloves }

    public enum ConsumableType { AddOxygen, RemoveState }

    public new string name = "New Item";

    public Sprite icon = null;

    public bool isDefaultItem = false;

    public bool isConsumable;


    [ConditionalHide("isConsumable", true)]
    public ConsumableType consumableType;

    public bool isEquipement;

    [ConditionalHide("isEquipement", true)]
    public EquipementType equipementType;
    [Space()]
    [ConditionalHide("isEquipement", true)]
    public int statAttackBaseBonus;
    [ConditionalHide("isEquipement", true)]
    public float statAttackMultiplicatorBonus;
    [ConditionalHide("isEquipement", true)]
    public int statAttackFlatBonus;
    [ConditionalHide("isEquipement", true)]
    [Space()]
    public int statDefenseBaseBonus;
    [ConditionalHide("isEquipement", true)]
    public float statDefenseMultiplicatorBonus;
    [ConditionalHide("isEquipement", true)]
    public int statDefenseFlatBonus;
    [ConditionalHide("isEquipement", true)]
    [Space()]
    public int statSpeedBaseBonus;
    [ConditionalHide("isEquipement", true)]
    public float statSpeedMultiplicatorBonus;
    [ConditionalHide("isEquipement", true)]
    public int statSpeedFlatBonus;
    [ConditionalHide("isEquipement", true)]
    [Space()]
    public int statAirBaseBonus;
    [ConditionalHide("isEquipement", true)]
    public float statAirMultiplicatorBonus;
    [ConditionalHide("isEquipement", true)]
    public int statAirFlatBonus;

    public bool isQuestObject;



}
