using UnityEngine;
public class Wardrobe : MonoBehaviour
{
    public GameObject[] Шапки;
    public GameObject[] Броня;
   // public GameObject[] Плечи;
   // public GameObject[] Плащ;

    public void OnTriggerEnter(Collider other)
    {
       
        Шапки = GameObject.FindGameObjectsWithTag("Player");

        if (Шапки.Length == 2)
        {
            Шапки[1].SetActive(true);
            Шапки[0].SetActive(false);
        }
        Броня = GameObject.FindGameObjectsWithTag("Player2");

        if (Броня.Length == 2)
        {
            Броня[1].SetActive(true);
            Броня[0].SetActive(false);
        }

        /*Плечи = GameObject.FindGameObjectsWithTag("Player3");

        if (Плечи.Length == 2)
        {
            Плечи[1].SetActive(true);
            Плечи[0].SetActive(false);
        }

        Плащ = GameObject.FindGameObjectsWithTag("Player4");

        if (Плащ.Length == 2)
        {
            Плащ[1].SetActive(true);
            Плащ[0].SetActive(false);
        }*/
    }
}