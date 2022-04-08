using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Tower))]
public class TowerEditor : Editor
{
    Tower tower;


    private void OnEnable()
    {
        tower = target as Tower;
    }

    private void OnSceneGUI()
    {
        Handles.DrawWireDisc(tower.transform.position, Vector3.up, tower.rangeDetection);
    }
}
