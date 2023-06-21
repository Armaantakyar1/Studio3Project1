using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    public List<GameObject> collectedEvidence = new List<GameObject>(); 

    public void AddEvidence(GameObject Evidence)
    {
        collectedEvidence.Add(Evidence);

        if (collectedEvidence.Count >= 2)
        {
            CompareObjects();
        }

    }
    private void CompareObjects()
    {
        GameObject firstObject = collectedEvidence[0];
        GameObject secondObject = collectedEvidence[1];

        if (firstObject.name == secondObject.name)
        {
            Debug.Log("The objects are identical.");
        }
        else
        {
            Debug.Log("The objects are different.");
        }
        collectedEvidence.Clear();
    }
}
