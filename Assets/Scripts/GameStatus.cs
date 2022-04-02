using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    private static int[] PlayerStatus = new int[] { 0, 0, 0, 0 };

    private static readonly int CHECKPOINT_COUNT = 3;
    public static void registerCheckpoint(string playerTag, int newCheckpoint)
    {
        int playerIdx = getPlayerIdx(playerTag);
        int currentCheckpoint = PlayerStatus[playerIdx];
        if (isOk(currentCheckpoint, newCheckpoint))
        {
            PlayerStatus[playerIdx] = newCheckpoint;
            Debug.Log($"Checkpoint OK: player={playerTag}, checkpoint={currentCheckpoint} > {newCheckpoint}");
        }
        else
        {
            Debug.Log($"Checkpoint ERROR: player={playerTag}, checkpoint={currentCheckpoint} > {newCheckpoint}");
        }
    }



    private static int getPlayerIdx(string playerTag)
    {
        switch (playerTag)
        {
            case "Player1": return 0;
            case "Player2": return 1;
            case "Player3": return 2;
            case "Player4": return 3;
        }
        return -1;
    }

    private static bool isOk(int currentCheckpoint, int newCheckpoint)
    {
        if (newCheckpoint == 1)
        {
            return currentCheckpoint == 0 || currentCheckpoint == CHECKPOINT_COUNT;
        }
        else
        {
            return newCheckpoint == currentCheckpoint + 1;
        }
    }

}
