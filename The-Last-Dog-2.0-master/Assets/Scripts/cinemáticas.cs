using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class VideoPlay : MonoBehaviour {    

     private UnityEngine.Video.VideoPlayer videoPlayer;
     private string status;
     private string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        

        switch (sceneName) { 
            case "Escena2":
                videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath,"Cinematica-intro.mp4");
            break;
            


         
                  videoPlayer.Play();        
        
    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
