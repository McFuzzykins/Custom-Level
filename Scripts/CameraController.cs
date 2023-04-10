using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Observer
{
    private PlayerController _pCont;
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }

    public override void Notify(Subject subject)
    {
        if(!_pCont)
        {
            _pCont = subject.GetComponent<PlayerController>();
        }

        if(_pCont)
        {
            //Something
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
