using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToSingleGame : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadScene);
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("singleScene");
    }
}
