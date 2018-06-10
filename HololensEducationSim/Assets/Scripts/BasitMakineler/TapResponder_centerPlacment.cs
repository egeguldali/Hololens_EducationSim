// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule.Tests
{
    /// <summary>
    /// This class implements IInputClickHandler to handle the tap gesture.
    /// It increases the scale of the object when tapped.
    /// </summary>
    /// 


    public class TapResponder_centerPlacment : MonoBehaviour, IInputClickHandler
    {

        public GameObject gO;
        public GameObject center;

        public void OnInputClicked(InputClickedEventData eventData)
        {
            center.gameObject.transform.position = this.transform.position;
            center.SetActive(true);
            gO.GetComponent<createCenters>().destroyClones();

        }


    }
}
