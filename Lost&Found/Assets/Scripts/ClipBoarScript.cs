using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClipBoarScript : MonoBehaviour
{
    [SerializeField] PlayerBehavior playerBehav;
    [SerializeField] List<GameObject> lostOjbs;
    public List<GameObject> foundOjbs;
    [SerializeField] List<Text> textBoxes;
    public List<GameObject> stamps;
    public int numIndex , numIndex1;
    public bool stamping;

    private void Start()
    {
        numIndex = 0;
        numIndex1 = 0;
        foundOjbs = new List<GameObject>();

        foreach (GameObject item in playerBehav.lostObjects)
        {
            numIndex++;
            lostOjbs.Add(item);
            textBoxes[numIndex - 1].text = item.name;
            stamps[numIndex - 1].name = item.name;
        }
    }
    private void Update()
    {
        if (stamping)
        {
            foreach (GameObject i in stamps)
            {
                foreach  (GameObject j in foundOjbs)
                {
                    if(j.name == i.name)
                    {
                        i.SetActive(true);
                    }
                    
                }
            }
        }
        
        if (foundOjbs.Count >= playerBehav.lostObjects.Count)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
 }
            
        
    

    


