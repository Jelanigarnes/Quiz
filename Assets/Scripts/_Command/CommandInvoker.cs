using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputActions;
   

    // Start is called before the first frame update
    void Start()
    {
       

        inputActions = PlayerInputController.controller.inputAction;

        inputActions.Editor.InvertMapping.performed += cntxt => InvertCommand();

    }

   
    public void InvertCommand()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
