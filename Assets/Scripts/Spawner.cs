using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject spawner;

    [SerializeField] private float cooldown = 0.4f;
    [SerializeField] private float initialDelay = 2f;

    [SerializeField] private float maxYPos = 4.5f;
    [SerializeField] private float minYPos = -4.5f;

    private void Awake() => spawner.GetComponent<GameObject>();

    private void Start() => StartCoroutine(CoinSpawner());

    private IEnumerator CoinSpawner()
    {
        yield return new WaitForSeconds(initialDelay);

        while (true)
        {
            var offset = new Vector3(Random.Range(minYPos, maxYPos), 0f, 0f);
            Instantiate(coinPrefab, spawner.transform.position + offset, Quaternion.identity);
            yield return new WaitForSeconds(cooldown);
        }
    }
}