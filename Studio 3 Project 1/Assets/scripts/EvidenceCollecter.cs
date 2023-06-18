using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    public string evidenceTag = "Evidence"; 
    public List<GameObject> collectedEvidence = new List<GameObject>(); 
    public TextMeshProUGUI evidenceNameText;
    public void AddEvidence(GameObject Evidence)
    {
        collectedEvidence.Add(Evidence);
        evidenceNameText.text = Evidence.gameObject.name;
    }
}
