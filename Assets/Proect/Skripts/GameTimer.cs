using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    public Image up, down;
    public float timer;
    public static GameTimer rid { get; set; }
    public bool working = true;
    void Awake()
    {
        working = true;
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
    void Update()
    {
        if (timer >= 120)
        {
            if (working)
            {
                Interface.rid.CutScene();
                MonsterCreator.rid.Warning();
                working = false;
            }
        }
        else
        {
            working = true;
            timer += Time.deltaTime;
            up.fillAmount = 1 - timer / 120;
            down.fillAmount = timer / 120;
        }
    }
}
