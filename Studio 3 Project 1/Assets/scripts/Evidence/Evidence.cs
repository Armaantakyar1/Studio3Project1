using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    [SerializeField] EvidenceCollecter collecter;
    [SerializeField] bool isItOver;
    [SerializeField]GameObject evidence;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isItOver == true)
        {
            collecter.AddEvidence(evidence);
            evidence.SetActive(false);
        }
    }

    private void OnMouseOver()
    {
        isItOver = true;
    }

    private void OnMouseExit()
    {
        isItOver = false;
    }
}
