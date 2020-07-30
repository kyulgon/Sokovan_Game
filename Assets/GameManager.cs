using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;

    public bool isGameOver;

    public GameObject winUI;

    void Start()
    {
        isGameOver = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }


        if(isGameOver == true)
        {
            return;
        }

        int count = 0;
        for (int i = 0; i < itemBoxes.Length; i++)
        {
            if(itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }

        if(count >= 3)
        {
            isGameOver = true;
            Debug.Log("게임승리");
            winUI.SetActive(true);
        }
    }
}
