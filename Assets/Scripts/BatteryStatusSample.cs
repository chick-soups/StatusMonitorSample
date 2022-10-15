using UnityEngine;
using TMPro;
using Puremilk.Status;
public class BatteryStatusSample : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    [SerializeField] private TextMeshProUGUI m_TextLevel;
    private Puremilk.Status.BatteryStatus m_BatteryState;
    private void OnEnable()
    {
        ShowBatteryStatus(Puremilk.Status.BatteryStatus.CurState);
        ShowBatteryLevel(Puremilk.Status.BatteryStatus.BatteryLevel);
        m_BatteryState = new Puremilk.Status.BatteryStatus();
        m_BatteryState.BatteryStatusChanged.AddListener(ShowBatteryStatus);
        m_BatteryState.BatteryLevelChanged.AddListener(ShowBatteryLevel);
        m_BatteryState.Register();
        

    }
    private void OnDisable() 
    {
        m_BatteryState.UnRegister();
        m_BatteryState.Dispose();
        m_BatteryState=null;
    }

    private void ShowBatteryStatus(UnityEngine.BatteryStatus status)
    {
        m_Text.text = status.ToString();
    }

    private void ShowBatteryLevel(float level)
    {
        m_TextLevel.text = level.ToString();
    }

}
