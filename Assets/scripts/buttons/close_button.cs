using UnityEngine;
using UnityEngine.UI;



public class close_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(exit);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void exit()
    {
        Application.Quit();
    }
}
