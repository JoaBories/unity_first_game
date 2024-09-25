using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class start_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(start);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void start()
    {
        SceneManager.LoadScene("scenes/First_scene");
    }
}
