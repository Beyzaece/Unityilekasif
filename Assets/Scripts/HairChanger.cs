using UnityEngine;

public class HairChanger : MonoBehaviour
{
    public GameObject[] hairPrefabs;  // Seçilebilir saç prefablarý
    public Transform hairPoint;       // Kafaya eklenecek nokta

    private GameObject currentHair;

    public void ChangeHair(int index)
    {
        // Önceki saçý sil
        if (currentHair != null)
        {
            Destroy(currentHair);
        }

        // Yeni saçý instantiate et ve HairPoint'in çocuðu yap
        currentHair = Instantiate(hairPrefabs[index], hairPoint.position, Quaternion.identity);
        currentHair.transform.SetParent(hairPoint);
    }
}