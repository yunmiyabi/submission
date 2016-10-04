using UnityEngine;
using System.Collections;

// ---------------------------------------------------------
//
//　ゲーム全体の管理クラス
//
// --------------------------------------------------------- 
public class SHGameManager:SHSingletonMonoBehaviour<SHGameManager> {

    public enum DIFFICULTY {
        EASY = 0,
        NORMAL,
        HARD
    }

    private DIFFICULTY m_difficulty;
    public DIFFICULTY difficulty {
        get {
            return m_difficulty;
        }
    }

    private Goddes m_player;
    public Goddes player{
        get {
            return m_player;
        }
    }

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

        ChangeDifficulty(DIFFICULTY.NORMAL);

        m_player = new Goddes();
        m_player.Init(DIFFICULTY.NORMAL);


        LogUtil.DebugLog(m_player.GetNowLife().ToString());


    }

    // ------------
    /// <summary>
    /// ゲームの難易度変更
    /// </summary>
    /// <param name="i_mode"></param>
    public void ChangeDifficulty(DIFFICULTY i_mode) {

        m_difficulty = i_mode;
        LogUtil.DebugLog(SHConstant.COMMON_CHANGE_DIFFICULTY + m_difficulty);

    }

}
