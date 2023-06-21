using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    [SerializeField] EvidenceCollecter collecter;


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            collecter.AddEvidence(this.gameObject);
        }
    }
}
