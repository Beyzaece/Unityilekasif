using UnityEngine;
using UnityEngine.SceneManagement;

public class QRSceneLoader : MonoBehaviour
{
    public void LoadEiffelQuizScene()
    {
        SceneManager.LoadScene("eyfelquizscene"); // Sahnenin ad� Build Settings�tekiyle birebir olmal�
    }
}