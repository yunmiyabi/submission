using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


// ---------------------------------------------------------
//
//　各シーンのベース
//
// --------------------------------------------------------- 
public class SceneBase : MonoBehaviour {

    // ---------------------------------------------------------
    /// <summary>
    /// 引数に与えられたシーンへ遷移を行う
    /// </summary>
    /// <param name="i_sceneName"></param>
	protected void ChangeScene(string i_sceneName) {

        try {
            SceneManager.LoadScene(i_sceneName);
        } catch {
            // LOG:シーンチェンジに失敗しました
            LogUtil.DebugLog(SHConstant.COMMON_FAILD_SCENE_CHANGE);
        }
        
        
    }

}
