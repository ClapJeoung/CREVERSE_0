using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lehuscript : MonoBehaviour
{
    //Å×Ã­¾Æ¾Ñ


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
