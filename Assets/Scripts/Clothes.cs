using UnityEngine;

public class Clothes : MonoBehaviour
{
    private GameObject _obj;
    public GameObject Obj
    {
        get
        {
            return _obj;
        }
        set
        {
            _obj = value;
            if (_obj.activeSelf == true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
