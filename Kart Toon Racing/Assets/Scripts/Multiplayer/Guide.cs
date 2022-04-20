using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Examples{
public class Guide : MonoBehaviour
{
    public GameObject PanelGuideStart, PanelGuideInGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseGuide(){
        GameObject.Find("How to in Game").gameObject.SetActive(false);
        PanelGuideStart.SetActive(true);
        StartCoroutine(CloseGuideInStart());
    }

    IEnumerator CloseGuideInStart(){
        yield return new WaitForSeconds(3);
        PanelGuideStart.SetActive(false);
        //GameObject.FindWithTag("Enemy").GetComponent<PathFollower>().enabled = true;
    }

    public void SelectNewbie(){
        //GameObject.FindWithTag("Enemy").GetComponent<PathFollower>().speed = 2;
        GameObject.Find("SelectLevelPanel").gameObject.SetActive(false);
    }

    public void SelectMedium(){
        //GameObject.FindWithTag("Enemy").GetComponent<PathFollower>().speed = 3;
        GameObject.Find("SelectLevelPanel").gameObject.SetActive(false);
    }

    public void SelectHard(){
        //GameObject.FindWithTag("Enemy").GetComponent<PathFollower>().speed = 4;
        GameObject.Find("SelectLevelPanel").gameObject.SetActive(false);
    }
}
}