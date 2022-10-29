using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puremilk.Status;
using TMPro;

public class LocationStatusSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;
    private LocationStatus m_Status;
    private void OnEnable() {
        OnStatusChanged(LocationStatus.CurState);
        m_Status =new LocationStatus();
        m_Status.StatusChanged.AddListener(OnStatusChanged);
        m_Status.Register();
       
    }

    private void OnDisable() {
        m_Status.UnRegister();
        m_Status.Dispose();
        m_Status=null;
    }

    private void OnStatusChanged(bool curStatus){
        m_TextMeshProUGUI.text=curStatus.ToString();
    }
}
