using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randNum = Random.Range(0f, 15f);
        Debug.Log(randNum);
    }

    private void Update()
    {
        float randNum = Random.Range(0f, 15f);
        Debug.Log(randNum);

        // Mathf.
    }

}
