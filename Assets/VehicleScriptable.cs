using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehicles", menuName = "ScriptableObject", order = 1)]
public class VehicleScriptable : ScriptableObject
{
    [HideInInspector] [SerializeField] private List<VehicleObject> _objectVehicles;

    private int now;

    [SerializeField] private VehicleObject objectNow;

    public List<VehicleObject> GetItemsByType(Vehicle type) {

        var list = new List<VehicleObject>();

        foreach (var item in _objectVehicles)
        {
            if (item.vehicle == type)
            {
                list.Add(item);
            }
        }

        return list;
    }

    #region SoInit
    public void New()
    {
        if (_objectVehicles == null)
        {
            _objectVehicles = new List<VehicleObject>();
        }

        var item = new VehicleObject();
        
        _objectVehicles.Add(item);
        //item.ID = _items.Count;
        objectNow = item;
        now = _objectVehicles.Count - 1;
    }

    public void Old()
    {
        _objectVehicles.Remove(objectNow);
        if (_objectVehicles.Count > 0)
            objectNow = _objectVehicles[0];
        else New();
        now = 0;
    }

    public void UpObject()
    {
        if (now + 1 < _objectVehicles.Count)
        {
            now++;
            objectNow = _objectVehicles[now];
        }
    }
    public void DownObject()
    {
        if (now > 0)
        {
            now--;
            objectNow = _objectVehicles[now];
        }
    }
    #endregion
}



[System.Serializable]
public class VehicleObject {
    public Vehicle vehicle;
    public int number;
    public string vehicleName;
    public Sprite vehiclePhoto;
    public string vehicleInfo;
}

public enum Vehicle {
    TANKS, AERIAL
}
