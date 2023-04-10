using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    public void ExecuteCommand(Command command)
    {
        command.Execute();
    
        //Debug.Log("Recorded Time: " + _recordingTime);
        //Debug.Log("Recorded Commands: " + command);
    }
}
