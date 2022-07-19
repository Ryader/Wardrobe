using UnityEngine;

public class Clothes : MonoBehaviour
{
    public GameObject obj;
    public void Update()
    {
        if(obj.activeSelf == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
