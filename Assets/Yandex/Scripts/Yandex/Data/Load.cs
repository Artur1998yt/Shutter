using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using pEventBus;
using UnityEngine;
public class Load : MonoBehaviour, IEventReceiver<OnLoadIsComplete>
{
    public Data data;
    public void Staring()
    {
        SceneManager.LoadScene(1);
        data.record = 0;
        data.level = "Scene1";
    }
    public void Loading()
    {
        SceneManager.LoadScene(data.level);
    }
    public void OnEvent(OnLoadIsComplete e)
    {
        
    }

    void Start()
    {
        EventBus.Register(this);
        SaveAndLoad.Instance.Load();
    }

    private void OnDestroy()
    {
        EventBus.UnRegister(this);
    }
}
