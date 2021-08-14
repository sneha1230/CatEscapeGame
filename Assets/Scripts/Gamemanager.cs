using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public GameObject reviveUi;
    public GameObject gameOverUi;

    public GameObject Mainpanel;
    private bool revived;
    public GameObject Enemy;
    public GameObject gameWinPanel;
    
     
     
     
    
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 

    public void NextLevelbtn()
    {
      SceneManager.LoadScene(1);
    }
    private void Update()
    {
        
    }
    public void YouwantToRevive()
    {
        if (revived)
        {
            GameOver();
        }
        else
        {
            reviveUi.SetActive(true);
        }
    }
    public void RevivePlayer()
    {
        revived = true;
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        player.SetActive(true);

    }

    public void GameOver()
    {
        reviveUi.SetActive(false);
        gameOverUi.SetActive(true);
       

    }
    //re
    public void NGameOver()
    {
        reviveUi.SetActive(true);
        gameOverUi.SetActive(false);
        Mainpanel.SetActive(false);
    }

    public void GetARevive()
    {
        reviveUi.SetActive(false);
        RevivePlayer();
    }

    public void onCLickBtn()
    {
        player.SetActive(true);
        reviveUi.SetActive(false);
        //Destroy(gameOverUi);
        RevivePlayer();
        Mainpanel.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            gameWinPanel.SetActive(true);
            Enemy.SetActive(false);
        }
    }


}

 
