using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jail : MonoBehaviour
{
    private void Awake() {
        StartCoroutine(New());
    }
    IEnumerator New()
    {
        yield return new WaitForSeconds(0.9f);

        gameObject.SetActive(false);
    }
}
