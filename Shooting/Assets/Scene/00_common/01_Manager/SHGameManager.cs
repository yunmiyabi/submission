using UnityEngine;
using System.Collections;

// ---------------------------------------------------------
//
//　ゲーム全体の管理クラス
//
// --------------------------------------------------------- 
public class SHGameManager:SHSingletonMonoBehaviour<SHGameManager> {

    // ------------

    public void Awake() {

        if (this != Instance) {
            Destroy(this);
            return;
        }

        DontDestroyOnLoad(this.gameObject);

    }

    // ------------

    public void Init() {

        
    
    }

}
