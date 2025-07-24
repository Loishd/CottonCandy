using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class ForceSceneViewRepaint
{
    static ForceSceneViewRepaint()
    {

        EditorApplication.update += RepaintSceneView;
    }

    static void RepaintSceneView()
    {
        if (SceneView.lastActiveSceneView != null)
        {
            SceneView.lastActiveSceneView.Repaint();
        }
    }
}