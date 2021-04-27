using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEffect2 : MonoBehaviour
{
    public GameObject finishEffect2;

    private void Start()
    {
        finishEffect2.SetActive(false);
    }

    // Update is called once per frame
    public void ActivateEffect()
    {
        finishEffect2.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ActivateEffect();
        }
    }
}