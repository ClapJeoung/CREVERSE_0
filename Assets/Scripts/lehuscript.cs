using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;


public class lehuscript : MonoBehaviour
{
    [ContextMenu("·¹ÈÄ")]
    public void ASDF()
    {
        Debug.Log(EditorBuildSettings.scenes[0].path);
    }


    [SerializeField] private Transform LehuTrans = null;
    private Vector3 RandomRot = Vector3.one;
    void Start()
    {
        RandomRot = new Vector3(Random.Range(0, 2) == 0 ? -100.0f: 100.0f, Random.Range(0, 2) == 0 ? -100.0f: 100.0f, Random.Range(0, 2) == 0 ? -100.0f:100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        LehuTrans.Rotate(RandomRot * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Escape))Application.Quit();
    }

}
