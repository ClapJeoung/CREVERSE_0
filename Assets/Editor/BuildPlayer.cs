using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;
using UnityEngine.UIElements;

// Output the build size or a failure depending on BuildPlayer.

public class BuildPlayer : MonoBehaviour
{
    static string SceneName = "Scenes/TestSceneName.unity";
    static string[] SCENES = FindEnabledEditorScenes();

    static void PerformBuild()
    {
        BuildPlayerOptions _option = new BuildPlayerOptions();
        _option.scenes = new string[] { SceneName };
        _option.locationPathName = "Builds/LehuFoler/LehuGame.exe";
        _option.target=BuildTarget.StandaloneWindows;
        _option.options = BuildOptions.None;

        List<string> scenes = new List<string>();
        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            scenes.Add(scene.path);
        }
    출처: https://upbo.tistory.com/120 [메모장:티스토리]
        BuildPipeline.BuildPlayer(scenes.ToArray(),"Builds/LehuFolder/LehuGame.exe",BuildTarget.StandaloneWindows,BuildOptions.None);
    }
    static void Techa()
    {
        Debug.Log("테챠앗");
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