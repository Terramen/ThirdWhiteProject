using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLoading : MonoBehaviour
{
    private void Awake() {
        StartCoroutine(MyCoroutine());
    }
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(0.8f);

        gameObject.SetActive(false);
    }
}
