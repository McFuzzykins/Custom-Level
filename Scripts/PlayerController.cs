using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Subject
{
    private CameraController _camCont;
    public bool flip
    {
        get; private set;
    }

    public bool obs
    {
        get; private set;
    }

    void Awake()
    {
        _camCont = (CameraController)FindObjectOfType(typeof(CameraController));
    }

    void OnEnable()
    {
        if (_camCont)
        {
            Attach(_camCont);
        }
    }

    void OnDisable()
    {
        if (_camCont)
        {
            Detach(_camCont);
        }
    }

    public void SpawnObs()
    {
        obs = !obs;
        NotifyObservers();
    }
}
