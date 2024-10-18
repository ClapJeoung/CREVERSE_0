using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;
using UnityEngine.UIElements;

// Output the build size or a failure depending on BuildPlayer.

public class BuildPlayer : MonoBehaviour
{
    [MenuItem("Build/Build AOS")]
    public static void MyBuild_AOS()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scene1.unity", "Assets/Scene2.unity" };
        buildPlayerOptions.locationPathName = $"Builds/AOS_{PlayerSettings.bundleVersion}.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }
    }

    [SerializeField] private Transform Dummy = null;
    private Vector3 RandomRot= Vector3.zero;
    private void Awake()
    {
        RandomRot = new Vector3(Random.Range(0, 2) == 0 ? -100.0f : 100.0f, Random.Range(0, 2) == 0 ? -100.0f : 100.0f, Random.Range(0, 2) == 0 ? -100.0f : 100.0f);
    }
    private void Update()
    {
        Dummy.Rotate(RandomRot * Time.deltaTime, Space.Self);
    }
}