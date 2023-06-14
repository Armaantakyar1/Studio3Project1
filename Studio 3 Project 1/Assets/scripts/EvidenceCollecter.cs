using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    public string evidenceTag = "Evidence";
    public List<GameObject> collectedEvidence = new List<GameObject>();
    public TextMeshProUGUI evidenceNameText;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag(evidenceTag))
            {
                collectedEvidence.Add(hit.collider.gameObject);
                evidenceNameText.text = hit.collider.gameObject.name;
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
