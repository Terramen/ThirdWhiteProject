using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VehicleSystem : MonoBehaviour
{
    [SerializeField] private VehicleScriptable _script;

    [SerializeField] private GameObject _content;
    [SerializeField] private GameObject _mm;
    
    
    [SerializeField] private TMP_Text _vehName;
    [SerializeField] private TMP_Text _vehInfo;
    [SerializeField] private Image _vehPhoto;

    private List<VehicleObject> _vehs;
    private int _currentId;

    public void ClickNext() {
        if (_currentId == _vehs.Count - 1) {
            _currentId = 0;
            _content.SetActive(false);
            _mm.SetActive(true);
            return;
        }
        _currentId++;
        SetVehicles();
    }


    
    public void SetVehicles() {
        _vehName.text = _vehs[_currentId].vehicleName;
        _vehPhoto.sprite = _vehs[_currentId].vehiclePhoto;
        _vehInfo.text = _vehs[_currentId].vehicleInfo;
    }
    
    public void SetAllVehicles(int id) {
        _currentId = 0;

        Vehicle type = (Vehicle)id;
        _vehs = _script.GetItemsByType(type);
    }

    public void LeaveGame() {
        Application.Quit();
    }

}
