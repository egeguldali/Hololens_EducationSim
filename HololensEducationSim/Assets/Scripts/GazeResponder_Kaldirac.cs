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
    public class GazeResponder_Kaldirac : MonoBehaviour, IFocusable
    {

        public Material onFocusMaterial;
        public Material offFocusMaterial;
        



        private void Start()
        {
            //OrginalX = GetComponent<RectTransform>().localPosition.x;
            //OrginalY = GetComponent<RectTransform>().localPosition.y;
            //OrginalZ = GetComponent<RectTransform>().localPosition.z;

            Renderer rend = GetComponent<Renderer>();

        }

        public void OnFocusEnter()
        {


            // Highlight the material when gaze enters using the shader property.
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material = onFocusMaterial;
            }


        }

        public void OnFocusExit()
        {
            // Remove highlight on material when gaze exits.
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material = offFocusMaterial;
            }
        }
    }
}