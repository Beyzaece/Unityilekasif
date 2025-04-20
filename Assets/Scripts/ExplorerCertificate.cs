
using UnityEngine;
using UnityEngine.UI;

public class ExplorerCertificate : MonoBehaviour
{
    public Text playerNameText;

    public void SetPlayerName(string name)
    {
        playerNameText.text = name;
    }
}
