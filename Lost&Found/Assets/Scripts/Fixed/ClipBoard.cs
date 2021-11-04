using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClipBoard : MonoBehaviour
{
    public List<GameObject> lostObjects;
    [SerializeField] List<Text> textBoxes;

    private void Awake()
    {
        for (int i = 0; i < lostObjects.Count; i++)
        {
            textBoxes[i].text = lostObjects[i].name;
        }
    }
}
