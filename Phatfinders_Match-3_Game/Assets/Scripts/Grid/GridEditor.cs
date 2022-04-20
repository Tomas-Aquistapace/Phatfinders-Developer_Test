using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridManager))]
public class GridEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GridManager generator = (GridManager)target;

        if(GUILayout.Button("Create Grid"))
        {
            generator.GenerateGrid();
        }
        
        if(GUILayout.Button("Delete Grid"))
        {
            generator.DeleteGrid();
        }
    }
}
