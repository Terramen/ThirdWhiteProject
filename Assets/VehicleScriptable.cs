using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ContentBlock", menuName = "ScriptableObject", order = 1)]
public class VehicleScriptable : ScriptableObject
{
    [HideInInspector] [SerializeField] private List<ItemModel> _items;
    [SerializeField] private ItemModel currentItem;

    private int currentIndex;

    public List<ItemModel> Items => _items;

    public List<ItemModel> GetItemsByType(Vehicle type) {

        var list = new List<ItemModel>();

        foreach (var item in _items)
        {
            if (item.vehicle == type)
            {
                list.Add(item);
            }
        }

        return list;
    }

    #region SoInit
    public void CreateItem()
    {
        if (_items == null)
        {
            _items = new List<ItemModel>();
        }

        var item = new ItemModel();
        
        _items.Add(item);
        //item.ID = _items.Count;
        currentItem = item;
        currentIndex = _items.Count - 1;
    }

    public void RemoveItem()
    {
        _items.Remove(currentItem);
        if (_items.Count > 0)
            currentItem = _items[0];
        else CreateItem();
        currentIndex = 0;
    }

    public void NextItem()
    {
        if (currentIndex + 1 < _items.Count)
        {
            currentIndex++;
            currentItem = _items[currentIndex];
        }
    }
    public void PrevItem()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            currentItem = _items[currentIndex];
        }
    }
    #endregion
}



[System.Serializable]
public class ItemModel {
    public Vehicle vehicle;
    public int id;
    public string playerName;
    public string playerInfo;
    public Sprite playerPhoto;
}

public enum Vehicle {
    TANKS, AERIAL
}
