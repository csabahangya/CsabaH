using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] int spawnCount;
    [SerializeField] Asteroid[] asteroidPrefabs;
    [SerializeField] float spwanDistance = 20;

    List<Asteroid> asteroids = new(); //Amik a scene-ben léteznek

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0, asteroidPrefabs.Length);
            Asteroid prefab = asteroidPrefabs[randomIndex];
            Asteroid newAsteroid = Instantiate(prefab);
            asteroids.Add(newAsteroid);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spwanDistance;
            newAsteroid.transform.position = position;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RemoveAsteroid(Asteroid asteroid)
    {
        asteroids.Remove(asteroid);
        if(asteroids.Count ==0)
        {
            Debug.Log("STAGE CLEARED");
            Spawn();
        }
    }
}
