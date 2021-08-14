using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine.UI;
public class PlayerSaveData : MonoBehaviour
{
    public string playerName;
    public string playerAddress;
    public string Country;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetData();
        GetData();
    }
    public void SetData()
    {
        string path = Application.persistentDataPath + "/PlayerData.file";
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Player Name : " + playerName);
        bw.Write("Player Address : " + playerAddress);
        bw.Write("Country : " + Country);
        //bw.Write("Score is : " + lastscore.score.ToString());
        bw.Close();
        fs.Close();
        Debug.Log(playerAddress);
    }
    public void GetData()
    {
        string path = Application.persistentDataPath + "/PlayerData.file";
        FileStream fs = new FileStream(path, FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        br.ReadString();
        br.Close();
        fs.Close();
    }
}
