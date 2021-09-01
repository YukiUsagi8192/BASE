using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        FadeManager.Instance.LoadScene("PlayModeSelectScene", 1.0f);
        //SceneManager.LoadScene("PlayModeSelectScene");
    }
}
