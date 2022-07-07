using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Unity.TextMeshPro;
using TMPro;

public class TodoListManage : MonoBehaviour
{
    public Transform content;
    public GameObject addpanel;
    public Button createButton;
    public GameObject todoListItemprefab;

    string filepath;

    private List<TodoListObject> todoListObj = new List<TodoListObject>();

    private TMP_InputField[] addinput;
    private Button event1;
    private void Start()
    {
        filepath =  Application.persistentDataPath + "/todoList.txt";  
        createButton.onClick.AddListener(delegate {CreateTodoList();});
       // todoListItemprefab.transform.GetChild(2).gameObject.GetComponent<Button>().onClick.AddListener(delegate {Destroy(todoListItemprefab);});
      //  addinput = addpanel.GetComponentsInChildren<InputField>();
    }



    public void AddPopup(int mode)
    {
        if (mode == 0)
        {
            addpanel.SetActive(false);

        }
        else if (mode == 1)
        {
            addpanel.SetActive(true);
        }
    }
    public void CreateTodoList(/*string name, string type*/)
    {
        AddPopup(1);
        addinput = addpanel.GetComponentsInChildren<TMP_InputField>();
        
        string name = addinput[0].text;
        string type = addinput[1].text;
        //Debug.Log(name + type);
        GameObject item = Instantiate(todoListItemprefab);
        
        int index = 0;
        if (todoListObj.Count  > 0)
            index = todoListObj.Count - 1;
        item.transform.SetParent(content);

        TodoListObject itemObecj = item.GetComponent<TodoListObject>();
        Debug.Log(itemObecj);
        itemObecj.SetObjectInfo(name, type, index);
        todoListObj.Add(itemObecj);
        TodoListObject tmp = itemObecj;
        itemObecj.GetComponent<Toggle>().onValueChanged.AddListener(delegate {checkItem(tmp);});

        AddPopup(0);

    }


    public void checkItem(TodoListObject item)
    {
        todoListObj.Remove(item);
    }

}
