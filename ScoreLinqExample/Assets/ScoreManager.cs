using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public List<Player> players = new List<Player>();

    private void Start()
    {
        var time = from theData in players                      // 從 玩家清單 內 取得資料
                   where theData.hasCake == false               // 選取 沒有蛋糕的資料
                   orderby theData.time descending              // 排序 根據時間 反排序 (由大到小)
                   select theData.time;                         // 選取 篩選後的資料

        foreach (var item in time)
        {
            print(item);
        }
    }
}
