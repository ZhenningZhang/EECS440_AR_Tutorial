using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObjectSpawner : MonoBehaviour
{
    [SerializeField] Transform cursor;
    [SerializeField] AudioClip spawn_sound_effect;
    //[SerializeField] GameObject gameobject_to_spawn;

    public void SpawnGameobjectAtCursor(GameObject gameobject_to_spawn)
    {
        GameObject new_object = Instantiate(gameobject_to_spawn);
        new_object.transform.SetPositionAndRotation(cursor.position, cursor.rotation);

        AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
    }
}