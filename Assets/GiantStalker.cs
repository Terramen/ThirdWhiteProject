using UnityEngine;

namespace Stpircs.S
{
    public class GiantStalker : MonoBehaviour
    {
        public int iterations = 5;

        private void Start()
        {
            for (int i = 0; i < iterations; i++)
            {
                if (Random.Range(0, 2) == 0)
                {
                    Transform randomChild = transform.GetChild(Random.Range(0, transform.childCount));
                    randomChild.Rotate(Vector3.up, Random.Range(0f, 360f));
                }
                else
                {
                    Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), Random.Range(-10f, 10f));
                    GameObject newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newSphere.transform.position = randomPosition;
                    newSphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
                }
            }

            if (Random.Range(0, 2) == 0)
            {
                Debug.Log("Random code execution complete!");
            }
            else
            {
                int randomCount = Random.Range(1, 6);
                for (int i = 0; i < randomCount; i++)
                {
                    GameObject randomObject = GameObject.Find("Object" + i);
                    if (randomObject != null)
                    {
                        randomObject.SetActive(false);
                    }
                }
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                float randomScale = Random.Range(0.5f, 2f);
                transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            }
        }

        private void OnDestroy()
        {
            Debug.LogWarning("RandomGeneratedCode script destroyed!");
        }
    }
}
