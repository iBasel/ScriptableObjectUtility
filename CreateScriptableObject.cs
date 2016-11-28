using UnityEngine;
using UnityEditor;

public class CreateScriptableObject : EditorWindow {

    public Object source;

    [MenuItem("Assets/Create Scriptable Object")]
    public static void CreateYourScriptableObjectWindow() {
        CreateScriptableObject window = new CreateScriptableObject();
        window.ShowUtility();
    }

    void OnGUI()
    {
        source = EditorGUILayout.ObjectField(source, typeof(MonoScript), false);

        if (GUILayout.Button("Create!"))
            CreateYourScriptableObject();

    }

    public void CreateYourScriptableObject()
    {
        ScriptableObjectUtility.CreateAsset(source.name);
    }
}
