
//
// $created by Ismail Ozsaygi
// $contains functions for scene process.
// $do not attach it to any game object just call functions from another file.
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUtils : MonoBehaviour 
{

    public static void change_scene_async( int p_sceneIndex )
    {
        SceneManager.LoadSceneAsync( p_sceneIndex );
    }
	
}
