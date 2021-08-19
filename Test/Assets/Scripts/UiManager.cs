using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UiManager : MonoBehaviour
{
    public Canvas canvasUI;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        canvasUI.gameObject.SetActive(true);
        this.GetComponent<Outline>().enabled = true;
    }
    public void OnMouseExit()
    {
        canvasUI.gameObject.SetActive(false);
        this.GetComponent<Outline>().enabled = false;
    }
}
