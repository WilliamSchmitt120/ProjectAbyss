using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    //Script qui actualise et affiche les objets dans les slots

    public Transform itemsParent;

    Inventory inventory;

    InventorySlot[] slots;

    private void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    private void Update()
    {
        
    }

    void UpdateUI()
    {

        for (int i = 0; i < slots.Length; i++)
        {

            if (i < inventory.items.Count)
            {

                slots[i].AddItem(inventory.items[i]);

            }
            else
            {
                slots[i].ClearSlot();
            }


        }


    }

}
