using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Launcher : MonoBehaviour
{
    [SerializeField] private Transform TogglesRoot;
    // Start is called before the first frame update
    void Start()
    {
        Toggle[] toggles = TogglesRoot.GetComponentsInChildren<Toggle>();
        for (int i = 0; i < toggles.Length; i++)
        {
            Toggle toggle = toggles[i];
            string sampleName = toggle.transform.Find("Label").GetComponent<TextMeshProUGUI>().text;
            sampleName += "StatusSample";
            MonoBehaviour monoBehaviour = GetComponent(sampleName) as MonoBehaviour;
            toggle.onValueChanged.AddListener((isOn) =>
            {
                monoBehaviour.enabled = isOn;
            });
        }
    }
}
