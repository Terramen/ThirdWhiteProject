using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(VehicleScriptable))]
public class VehicleEditor : Editor {
    private VehicleScriptable _itemBase;
    private void Awake()
    {
        _itemBase = (VehicleScriptable)target;
    }
    public override void OnInspectorGUI()
    {

        if (GUILayout.Button("+"))
        {
            _itemBase.New();
        }
        if (GUILayout.Button("-"))
        {
            _itemBase.Old();
        }
        if (GUILayout.Button("Done"))
        {
            if (_itemBase != null)
            {
                EditorUtility.SetDirty(_itemBase);
                AssetDatabase.SaveAssets();
            }
        }
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Prev"))
        {
            _itemBase.DownObject();
        }
        if (GUILayout.Button("Next"))
        {
            _itemBase.UpObject();
        }
        GUILayout.EndHorizontal();

        base.OnInspectorGUI();
    }
}
