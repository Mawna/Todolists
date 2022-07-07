using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TodoListObject : MonoBehaviour
{
    public string objName;
    public string type;
    public int index;


    public UnityEngine.UI.Text itemText;
    // Start is called before the first frame update
    void Start()
    {
        itemText = GetComponentInChildren<UnityEngine.UI.Text>();
        itemText.text = objName;
    }

    public void SetObjectInfo(string name, string type, int index)
    {
        this.objName = name;
        this.type = type;
        this.index = index;
    }

}
