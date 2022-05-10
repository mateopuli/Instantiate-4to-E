using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtcloneAmount;
    GameObject clon;
    

    public void MultiInstantiate()
    {
        
        cloneAmount = int.Parse(txtcloneAmount.text);
        for (int i = 0; i < cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon,1);
        }
    }
}
