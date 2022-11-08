using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EnemyDatabase))]

public class EnemyDBEditor : Editor
{
    private EnemyDatabase database;

    private void Awake()
    {
        database = (EnemyDatabase)target;
    }

    public override void OnInspectorGUI()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("RemoveAll"))
        {
            database.ClearDatabase();
        }
        if (GUILayout.Button("Remove"))
        {
            database.RemoveCurrentElement();
        }
        if (GUILayout.Button("Add"))
        {
            database.addDevice();
        }
        if (GUILayout.Button("<="))
        {
            database.GetPrev();
        }
        if (GUILayout.Button("=>"))
        {
            database.GetNext();
        }
    }
}
