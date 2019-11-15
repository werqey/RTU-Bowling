using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorS : MonoBehaviour
{
    public int detected;
    public int count;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.GetComponent<TextMesh>().text = (count - detected).ToString();
        detected = 0;
        
    }
    private void OnTriggerStay(Collider other)
    {
        detected++;
    }
}
