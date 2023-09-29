using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    // Start is called before the first frame update
    public void LoadSpecificScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
    
}
