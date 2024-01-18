using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Count : MonoBehaviour
{
    TextMeshProUGUI text;
    [SerializeField] string tag_to_find;

    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = tag_to_find + " count: " + GameObject.FindGameObjectsWithTag(tag_to_find).Length.ToString();
    }
}
