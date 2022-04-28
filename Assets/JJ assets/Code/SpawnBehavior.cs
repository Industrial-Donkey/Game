using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject warningPrefab;
    public GameObject trashPrefab;
    public Transform player;
    public Transform warn;

    private float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        ///At the start, call the spawn function after 3 seconds, every 3 seconds.
        ///Changing the last number will change laser spawn rate
        InvokeRepeating("spawnLaserWarn", 3, 3);

        ///At the start, call function after 2 seconds every 5 seconds
        ///Changing last number will change trash spawn rate
        InvokeRepeating("spawnTrash", 3, 8);

        ///Hides the warning prefab as a later function will enable it when needed
        warningPrefab.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///This function controls laser and laserWarning spawns
    void spawnLaserWarn()
    {
        //Chooses a random y-range for laser to spawn
        ///int y = Random.Range(-1, 7);
        
        ///Declares value 'y' at player's position
        float y = player.position.y;

        ///Moves the warning sign for laser to the same y-value as laser
        warningPrefab.transform.position = new Vector3(player.position.x - 3.6f, y, 0);

        ///shows warning
        warningPrefab.GetComponent<Renderer>().enabled = true;

        Invoke("laserSpawn", 0.4f);

        ///Calls function after 0.4 seconds to hide the warning
        Invoke("hideLaserWarning", 0.4f);
    }

    void laserSpawn ()
    {
        ///Declares value 'y' at player's position
        float y = warn.position.y;

        ///Creates a laser at player's y position, behind the player by 45
        Instantiate(laserPrefab, new Vector3(player.position.x - 15, y, 0), Quaternion.identity);
    }

    ///Function to hide the laser's warning
    void hideLaserWarning()
    {
        ///literally hides the warning, but keeps its script active
        warningPrefab.GetComponent<Renderer>().enabled = false;
    }

    void spawnTrash()
    {
        Instantiate(trashPrefab, new Vector3(player.position.x + 30, 0, 0), Quaternion.identity);
    }

}

