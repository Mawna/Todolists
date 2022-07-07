using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class delete : MonoBehaviour
{
    public Button del;
    public GameObject todoListItemprefab;

    // Start is called before the first frame update
    void Start()
    {
        del.onClick.AddListener(delegate {explooooosion();});
    }

    void explooooosion()
    {
        Destroy(todoListItemprefab);
    }
}
