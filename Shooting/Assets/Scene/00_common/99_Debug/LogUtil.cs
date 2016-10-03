using UnityEngine;
using System.Collections;


// ---------------------------------------------------------
//
//  ログの統括クラス
//
// --------------------------------------------------------- 
public static class LogUtil {


    // ---------------------------------------------------------
    /// <summary>
    /// Debug実行時のみ、ログを出力する
    /// </summary>
    /// <param name="i_outputLog"></param>
    public static void DebugLog(string i_outputLog) {

#if SH_DEBUG
        Debug.Log(i_outputLog);
#endif

    }


}
