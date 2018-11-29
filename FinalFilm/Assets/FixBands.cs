using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class FixBands : MonoBehaviour
{
    public GameObject createBand;


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
        if (transf.name.Contains("new_athlete_mouse:sweat_band"))
        {
            // Delete its children
            if (transf.childCount != 0) {
                var tempArray = new GameObject[transf.childCount];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = transf.GetChild(i).gameObject;
                }

                foreach (var child in tempArray)
                {
                    DestroyImmediate(child);
                }

               
            }

            List<Transform> destroyList = new List<Transform>();
            foreach (Transform superChild in transf.parent)
            {
                if (superChild.name.Contains("Clone") || superChild.name.Contains("createNewGuy"))
                {
                    destroyList.Add(superChild);
                }
            }
            Debug.Log("Deleting " + destroyList.Count + "miscreants ");
            foreach (Transform destroy in destroyList)
            {
                DestroyImmediate(destroy.gameObject);
            }


            // This would add in the band
            /*GameObject copy = Instantiate<GameObject>(createBand);
            copy.name = createBand.name;
            copy.transform.parent = transf.parent;
            Vector3 delta = new Vector3(-0.29331f, -0.0022016f, 0.8487843f);
            copy.transform.position = transf.position + delta;
            copy.transform.eulerAngles = transf.eulerAngles;

            fancyParent parent = copy.GetComponent<fancyParent>();
            parent.parent = transf;*/

            transf.gameObject.SetActive(false);

            return;
            
        }

        // now search in its children, grandchildren etc.
        foreach (Transform child in transf)
        {
            NameContains(child);
        }
    }
}
