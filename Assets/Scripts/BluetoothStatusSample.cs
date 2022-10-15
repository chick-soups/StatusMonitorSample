using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puremilk.Status;
using TMPro;

public class BluetoothStatusSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;
    private BluetoothStatus m_BluetoothStatus;
    private void OnEnable() {
        OnStatusChanged(BluetoothStatus.CurState);
        m_BluetoothStatus =new BluetoothStatus();
        m_BluetoothStatus.StatusChanged.AddListener(OnStatusChanged);
        m_BluetoothStatus.Register();
       
    }

    private void OnDisable() {
        m_BluetoothStatus.UnRegister();
        m_BluetoothStatus.Dispose();
        m_BluetoothStatus=null;
    }

    private void OnStatusChanged(BluetoothStatus.Status curStatus){
        m_TextMeshProUGUI.text=curStatus.ToString();
    }
}
