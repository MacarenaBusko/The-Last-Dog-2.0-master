using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;


public class VideoPlay1 : MonoBehaviour
{
      public static VideoPlayer videoInicial;
    bool empezar = false;
    private string sceneName;
    public GameObject camAnimacion;

    // Start is called before the first frame update
    void Start()
    {
     

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        videoInicial = GameObject.Find("Video Player").GetComponent<VideoPlayer>();        
         
      

        switch (sceneName) { 

          case "Cinematica1":
break; 

            case "Cinematica2":
                 videoInicial.url = Path.Combine(Application.streamingAssetsPath, "BosqueInicio.mp4");
              
               
                break;

               case "Cinematica3":
                 videoInicial.url = Path.Combine(Application.streamingAssetsPath, "Bosque_ciudad_boceto.mp4");
              
               
                break;   

                 case "Cinematica4":
                 videoInicial.url = Path.Combine(Application.streamingAssetsPath, "Cinematica-comienzo-fabrica.mp4");
break; 
            }
                
        videoInicial.Play();        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
