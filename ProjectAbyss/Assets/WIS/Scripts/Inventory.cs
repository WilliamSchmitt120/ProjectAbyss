using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;

    public static Inventory instance;

    public List<Item> items = new List<Item>();

    public int space = 20;

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

    public void Add(Item item)
    {



        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                return;
            }



            items.Add(item);

            if (onItemChangedCallBack != null)
            {

                onItemChangedCallBack.Invoke();

            }


        }

    }

    public void Remove(Item item)
    {

        items.Remove(item);

        if (onItemChangedCallBack != null)
        {

            onItemChangedCallBack.Invoke();

        }

    }

}
