using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;
using UnityEngine.UIElements;

// Output the build size or a failure depending on BuildPlayer.

public class BuildPlayer : MonoBehaviour
{
    static string SceneName = "TestSceneName";
    static string[] SCENES = FindEnabledEditorScenes();

    static void PerformBuild()
    {
        BuildPipeline.BuildPlayer(new string[] { SceneName }, "Builds/TestFolder/LehuGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
    static void Techa()
    {
        Debug.Log("Å×Ã­¾Ñ");
    }
    private static string[] FindEnabledEditorScenes()
    {
        List<string> EditorScenes = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            EditorScenes.Add(scene.path);
        }
        return EditorScenes.ToArray();
    }
}