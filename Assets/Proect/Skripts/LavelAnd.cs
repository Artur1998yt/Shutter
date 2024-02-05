using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavelAnd : MonoBehaviour {
	public string level;
    public Data data;
    public static LavelAnd rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void And()
    {
        SceneManager.LoadScene(level);
        data.record += 1;
        data.level = level;
        SaveAndLoad.Instance.Save();
    }
    public void Reload()
    {
        //SaveAndLoad.Instance.Save();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
