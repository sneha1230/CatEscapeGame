using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWinScreen : MonoBehaviour
{
    public GameObject gameWinPanel;
    public GameObject Enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            gameWinPanel.SetActive(true);
            Enemy.SetActive(false);
        }
    }
}
