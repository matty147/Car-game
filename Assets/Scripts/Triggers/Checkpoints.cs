using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoints : MonoBehaviour
{
    // todo make it possible for maps to have differrent number of checkqpoints

    public static readonly int CHECKPOINT_COUNT = 3;
    private int Curentx, Curenty, Curntz;
    public int Checkpointx, Checkpointy, Checkpointz;
    public static int[] PlayerLap = new int[] { 0, 0, 0, 0 };
    private static int[] PlayerStatus = new int[] { 0, 0, 0, 0 };
    public Text Lap;
    [SerializeField]
    int CheckpointNumber;

    public static void Reset()
    {
        PlayerStatus[0] = 0;
        PlayerStatus[1] = 0;
        PlayerStatus[2] = 0;
        PlayerStatus[3] = 0;
        PlayerLap[0] = 0;
        PlayerLap[1] = 0;
        PlayerLap[2] = 0;
        PlayerLap[3] = 0;
        //Debug.Log($"Reset: {PlayerStatus}");
    }

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
            if (currentCheckpoint == CHECKPOINT_COUNT && newCheckpoint == 1) 
            {
                PlayerLap[playerIdx]++;
                Debug.Log($"<color=red>Lap: player {playerTag} lap={PlayerLap[playerIdx]+1}</color>");
                
            }
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

    public void Update()
    {
       // Lap.text = Lap.ToString("0.0000");
    }
}
