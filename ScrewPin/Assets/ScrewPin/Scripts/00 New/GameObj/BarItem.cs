using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BarItem : MonoBehaviour
{
    /*private List<MaskObject> myMasks = new List<MaskObject>();*/
    


    /*private void Start()
    {
        // Initialize myMasks with all child masks
        foreach (Transform child in transform)
        {
            MaskObject mask = child.GetComponent<MaskObject>();
            if (mask != null)
            {
                myMasks.Add(mask);
                //Gm.HoleStorageController.masks.Add(mask);
            }
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Limit"))
        {
            transform.gameObject.SetActive(false);
            


            foreach (Transform child in this.transform)
            {
                child.gameObject.SetActive(false);
            }

            
        }
    }
}
