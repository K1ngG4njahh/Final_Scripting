using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClipBoard : MonoBehaviour
{
    public List<GameObject> lostObjects, foundObjects;
    [SerializeField] List<Text> textBoxes;

    [SerializeField] GameStateCaller events;

    private void Awake()
    {
        for (int i = 0; i < lostObjects.Count; i++)
        {
            textBoxes[i].text = lostObjects[i].name;
        }
    }
    public void Collected(LostObject lostObject)
    {
        int index = 0;
        textBoxes[lostObject.Id].color = Color.red;
        for (int i = 0; i < textBoxes.Count; i++)
        {
            if (textBoxes[i].color == Color.red)
            {
                index++;
            }
        }
        if (index == textBoxes.Count)
        {
            events.Won();
            SceneManager.LoadScene("Victory");
        }
    }
}
