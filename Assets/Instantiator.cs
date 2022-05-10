using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtcloneAmount;
    

    public void MultiInstantiate()
    {
        int counter = 0;
        cloneAmount = int.Parse(txtcloneAmount.text);
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
