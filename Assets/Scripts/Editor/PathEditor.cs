using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Path))]
public class PathEditor : Editor
{ 
    Path path;

    private void OnEnable()
    {
        path = target as Path;
    }

    void OnSceneGUI()
    {
        for (int i = 0; i < path.points.Length; i++)
        {
            path.points[i] = Handles.DoPositionHandle(path.points[i], Quaternion.identity);
            Handles.color = Color.blue;
            Handles.DrawSolidDisc(path.points[i], Vector3.up, path.minDistance);
            if(i > 0)
            {
                Handles.DrawLine(path.points[i], path.points[i - 1]);
            }
            Handles.Label(path.points[i], i.ToString());
        }
    }
}
