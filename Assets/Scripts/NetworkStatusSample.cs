
using UnityEngine;
using TMPro;
using Puremilk.Status;

public class NetworkStatusSample : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    NetworkStatus status;
    private void OnEnable()
    {
        ShowStatus(NetworkStatus.CurStatus);
        status = new NetworkStatus();
        status.Callback.AddListener(ShowStatus);
        status.Register();
    }
    private void OnDisable()
    {
        status.UnRegister();
        status.Dispose();
        status = null;
    }

    private void ShowStatus(NetworkReachability intValue)
    {
        m_Text.text = intValue.ToString();
    }
}
