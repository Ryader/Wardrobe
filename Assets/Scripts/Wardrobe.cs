using UnityEngine;
public class Wardrobe : MonoBehaviour
{
    public GameObject[] �����;
    public GameObject[] �����;
   // public GameObject[] �����;
   // public GameObject[] ����;

    public void OnTriggerEnter(Collider other)
    {
       
        ����� = GameObject.FindGameObjectsWithTag("Player");

        if (�����.Length == 2)
        {
            �����[1].SetActive(true);
            �����[0].SetActive(false);
        }
        ����� = GameObject.FindGameObjectsWithTag("Player2");

        if (�����.Length == 2)
        {
            �����[1].SetActive(true);
            �����[0].SetActive(false);
        }

        /*����� = GameObject.FindGameObjectsWithTag("Player3");

        if (�����.Length == 2)
        {
            �����[1].SetActive(true);
            �����[0].SetActive(false);
        }

        ���� = GameObject.FindGameObjectsWithTag("Player4");

        if (����.Length == 2)
        {
            ����[1].SetActive(true);
            ����[0].SetActive(false);
        }*/
    }
}