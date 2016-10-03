using UnityEngine;
using System.Collections;


// ---------------------------------------------------------
//
//　ゲーム全体の初期化を行う
//
// --------------------------------------------------------- 
public class Boot : SceneBase {

    private bool m_endInit = false;

    // ---------------------------------------------------------

    void Start() {

        _init();

        base.ChangeScene("title");


    }

    // ---------------------------------------------------------
    /// <summary>
    /// 初期化
    /// </summary>
    public void _init() {

        // 多重初期化の防止
        if (m_endInit) return;

        // ゲームマネージャを設定し、初期化
        gameObject.AddComponent<SHGameManager>().Init();

        // 初期化済みとする
        m_endInit = true;

        // LOG:初期化が完了しました
        LogUtil.DebugLog(SHConstant.BOOT_FINISH_INIT);

    }

}
