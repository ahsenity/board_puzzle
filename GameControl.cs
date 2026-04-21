using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
   [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    private GameObject Wintext;

    public static bool youWin;
     void Start()
     {
        Wintext.SetActive(false);
        youWin=false;
     }

     void Update()
     {
        if(pictures[0].rotation.z==0 &&
        pictures[1].rotation.z==0 &&
        pictures[2].rotation.z==0 &&
        pictures[3].rotation.z==0   )
        {
            youWin=true;
            Wintext.SetActive(true);
        }
     }
}
