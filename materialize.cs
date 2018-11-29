using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class materialize : MonoBehaviour
{

    public List<Material> materials;
    public List<string> mapping;

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
        for (int i = 0; i < mapping.Count; i++) {
            if ((mapping[i] != "") && transf.name.Contains(mapping[i])) {
                // Apply 
                Renderer rend = transf.GetComponent<Renderer>();
                if (rend != null) {
                    rend.material = materials[i];
                }
            }
        }

         // now search in its children, grandchildren etc.
        foreach (Transform child in transf)
        {
            NameContains(child);
        }
    }
}
