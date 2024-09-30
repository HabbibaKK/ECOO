using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialouge : MonoBehaviour
{
    [SerializeField] Flowchart _interact;
    [SerializeField] string _FCName;
    [SerializeField] bool isArea = false;
    [SerializeField] GameObject keyIcon;
    [SerializeField] bool isEnd;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isArea = false;
            keyIcon.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(isEnd)
                Timer.instance.isDone = true;
            isArea = true;
            keyIcon.SetActive(true);
        }
    }
    private void Update()
    {
        ExcuteFunguns();
    }
    void ExcuteFunguns()
    {
        if (isArea && Input.GetKeyDown(KeyCode.E))
        {
            _interact.ExecuteBlock(_FCName);
        }
    }
}
