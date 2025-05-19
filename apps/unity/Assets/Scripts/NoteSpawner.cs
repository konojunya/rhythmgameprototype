using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    public float spawnInterval = 1.0f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            Instantiate(notePrefab, new Vector3(0, 5, 0), Quaternion.identity);
            timer = 0f;
        }
    }
}