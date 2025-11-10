using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    List<InventoryItem> inventory;

    private void Start()
    {
        inventory = new List<InventoryItem>()
        {
            new InventoryItem("Sword"),
            new InventoryItem("Shield"),
            new InventoryItem("Axe"),
            new InventoryItem("Cloth Rags"),
            new InventoryItem("Steel Helmet"),
            new InventoryItem("MIRV Launcher"),
            new InventoryItem("Staff of Banishment"),
            new InventoryItem("Energy Sword"),
            new InventoryItem("Alpha Boost"),
            new InventoryItem("Suzu")
        };
    }

    //search by name
    InventoryItem LinearSearchByName(string itemName)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].Name == itemName) return inventory[i];
        }
        return null;
    }

    //search by id, must sort items by id first
    InventoryItem BinarySearchByID(int ID)
    {
        return null;
    }

    //sort inventory by value
    void QuickSortByValue()
    {

    }

    

}
