using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    //    private static int[] PlayerStatus = new int[] { 0, 0, 0, 0 };
    
    public static readonly int CHECKPOINT_COUNT = 3;
    private int Curentx, Curenty, Curntz;
    public int Checkpointx, Checkpointy, Checkpointz;
    private static int[] PlayerStatus = new int[] { 0, 0, 0, 0 };

    [SerializeField]
    int CheckpointNumber;


    void OnTriggerEnter(Collider other)
    {
        registerCheckpoint(other.tag, CheckpointNumber);
    }

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
            Debug.Log($"<color=blue>Time:{Timer.time}</color>");
            return currentCheckpoint == 0 || currentCheckpoint == CHECKPOINT_COUNT;
        }
        else
        {
            return newCheckpoint == currentCheckpoint + 1;
            //last checkpoint set the spawn position
        }
    }
}
