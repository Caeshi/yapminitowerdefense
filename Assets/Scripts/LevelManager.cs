using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{

    public static LevelManager main;

    public Transform StartPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
