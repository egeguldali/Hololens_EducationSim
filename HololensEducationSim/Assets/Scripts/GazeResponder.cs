// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using System.Collections;

namespace HoloToolkit.Unity.InputModule.Tests
{
    /// <summary>
    /// This class implements IFocusable to respond to gaze changes.
    /// It highlights the object being gazed at.
    /// </summary>
    public class GazeResponder : MonoBehaviour, IFocusable
    {
        
        float OrginalX;
        float OrginalY;
        float OrginalZ;


        private void Start()
        {
            //OrginalX = GetComponent<RectTransform>().localPosition.x;
            //OrginalY = GetComponent<RectTransform>().localPosition.y;
            //OrginalZ = GetComponent<RectTransform>().localPosition.z;
        }

        public void OnFocusEnter()
        {

          
            // Highlight the material when gaze enters using the shader property.
            gameObject.transform.position += Vector3.forward * -0.05f;
          
            
        }

        public void OnFocusExit()
        {
            // Remove highlight on material when gaze exits.
            gameObject.transform.position += Vector3.forward* 0.05f;
           
        }
    }
}