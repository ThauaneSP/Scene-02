using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimdeCamera : MonoBehaviour {

    public void CameraAcabou() {
        CutSceneController.instancia.ProximaCamera();
    }
}