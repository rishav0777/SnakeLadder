using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaver2 : MonoBehaviour
{
    private static DataSaver2 instance;

    public static DataSaver2 Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public string roomId="";
    public int playerCount=0;
    public int mode = 0;
    public string prefabid="id";
    public string prefabfirstName = "firstName";
    public string prefablastName = "lastName";
    public string prefabToken = "token";

    public string _id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string contestIdJoined { get; set; }
    public string token { get; set; }
    public int deposite { get; set; }
    public int bonus { get; set; }
    public int firstPrize { get; set; }
    public int secondPrize { get; set; }
    public int thirdPrize { get; set; }
    public string contestId { get; set; }
    public int entryFee { get; set; }


    public  string GetRoomId() { return roomId; }
    public void SetRoomId(string id) { roomId = id; }
    public int GetPlayerCount() { return playerCount; }
    public void SetPlayerCount(int p) { playerCount = p; }
    public int GetMode() { return mode; }
    public void SetMode(int p) { mode = p; }




    public int coinValue { get; set; }
    public int getcoinValue { get; set; }
    public int BetAmount { get; set; }


    public Dictionary<int, int> SnakeMap = new Dictionary<int, int>();
    public Dictionary<int, int> LadderMap = new Dictionary<int, int>();
    private void Start()
    {
        SnakeMap.Add(27,8);
        SnakeMap.Add(26,4);
        SnakeMap.Add(53,30);
        SnakeMap.Add(42,16);
        SnakeMap.Add(65, 44);
        SnakeMap.Add(88, 52);
        SnakeMap.Add(94, 75);
        SnakeMap.Add(98, 1);

        LadderMap.Add(3,22);
        LadderMap.Add(12, 45);
        LadderMap.Add(41, 62);
        LadderMap.Add(32, 51);
        LadderMap.Add(49, 68);
        LadderMap.Add(61, 80);
        LadderMap.Add(73, 92);
    }

    public Sprite[] profileIcon = new Sprite[8];
    public int profileValue { get; set; }

}
