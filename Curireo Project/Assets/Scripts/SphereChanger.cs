using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChanger : MonoBehaviour
{  
    //This ensures that we don't mash to change spheres
    bool changing = false;
    public void ChangeSphere(Transform nextSphere)
    {

        //Start the fading process
        StartCoroutine(FadeCamera(nextSphere));

    }
    IEnumerator FadeCamera(Transform nextSphere)
    {
        //Current position of camera is updated to the referenced sphere's position 
        Camera.main.transform.parent.position = nextSphere.position;
        yield return null;
    }
}
