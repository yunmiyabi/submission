using UnityEngine;
using System.Collections;
using GM = SHGameManager;
using CONST = SHConstant;

public class Goddes : PlayerBase {

    // ---------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    /// <param name="i_mode"></param>
    public void Init(GM.DIFFICULTY i_mode) {

        switch (i_mode) {

            case GM.DIFFICULTY.EASY:
                m_life = CONST.PLAYER_LIFE_INITIAL_VALUE_EASY;
            break;

            case GM.DIFFICULTY.NORMAL:
                m_life = CONST.PLAYER_LIFE_INITIAL_VALUE_NORMAL;
            break;

            case GM.DIFFICULTY.HARD:
                m_life = CONST.PLAYER_LIFE_INITIAL_VALUE_HARD;
            break;

        }       

    }


    // ---------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int GetNowLife() {

        return m_life;

    }

	
}
