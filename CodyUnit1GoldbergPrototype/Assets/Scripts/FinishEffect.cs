using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEffect : MonoBehaviour
{
    public GameObject finishEffect;

    private void Start()
    {
        finishEffect.SetActive(true);
    }

    // Update is called once per frame
    public void ActivateEffect()
    {
        finishEffect.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ActivateEffect();
        }
    }
}
