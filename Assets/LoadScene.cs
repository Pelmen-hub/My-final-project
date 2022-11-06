 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   

    private Scene scene;

    private void Start()
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);

        scene = SceneManager.LoadScene(0);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
