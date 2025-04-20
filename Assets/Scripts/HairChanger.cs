using UnityEngine;

public class HairChanger : MonoBehaviour
{
    public GameObject[] hairPrefabs;  // Se�ilebilir sa� prefablar�
    public Transform hairPoint;       // Kafaya eklenecek nokta

    private GameObject currentHair;

    public void ChangeHair(int index)
    {
        // �nceki sa�� sil
        if (currentHair != null)
        {
            Destroy(currentHair);
        }

        // Yeni sa�� instantiate et ve HairPoint'in �ocu�u yap
        currentHair = Instantiate(hairPrefabs[index], hairPoint.position, Quaternion.identity);
        currentHair.transform.SetParent(hairPoint);
    }
}