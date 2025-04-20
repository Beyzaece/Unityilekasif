using UnityEngine;
using UnityEngine.SceneManagement;

public class QRSceneLoader : MonoBehaviour
{
    public void LoadEiffelQuizScene()
    {
        SceneManager.LoadScene("eyfelquizscene"); // Sahnenin adý Build Settings’tekiyle birebir olmalý
    }
}