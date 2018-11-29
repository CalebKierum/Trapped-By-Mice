using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class FixEyes : MonoBehaviour
{

    public Material whiteEye;
    public Material blackEye;


    // Use this for initialization
    void Awake()
    {
        SearchOnMe();
    }

    // Update is called once per frame
    void Update()
    {
        SearchOnMe();
    }

    void SearchOnMe()
    {
        Debug.Log("Searching....");
        NameContains(this.transform);
        Debug.Log("Done!");
    }

    void NameContains(Transform transf)
    {
        if (transf.name.Contains("mouse:left_eye_geo") || transf.name.Contains("mouse:right_eye_geo")) {
            SkinnedMeshRenderer rend = transf.GetComponent<SkinnedMeshRenderer>();
            if (rend.sharedMaterials.Length == 1)
            {
                rend.material = whiteEye;
                //Debug.Log("" + transf.name + " is a terrible node with no materials!");
            }
            else
            {
                Material[] matArray = rend.sharedMaterials;
                matArray[0] = whiteEye;
                matArray[1] = blackEye;
                rend.sharedMaterials = matArray;
            }
        }

        // now search in its children, grandchildren etc.
        foreach (Transform child in transf)
        {
            NameContains(child);
        }
    }
}
