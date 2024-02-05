using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreator : MonoBehaviour
{
    public GameObject monster;
    public Transform instTransform;
    public static MonsterCreator rid { get; set; }
    void Awake()
    {
        instTransform = monster.transform;
        Box.stopTarget += Dan;
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
        Box.stopTarget -= Dan;
        rid = null;
    }

    public void Rewarning()
    {
        monster.transform.position = instTransform.position;
        monster.SetActive(false);
        GameTimer.rid.timer -= 10;
    }
    public void Warning()
    {
        monster.transform.position = instTransform.position;
        monster.SetActive(true);
        Debug.Log("Wackeup");
    }
    public void ThisTransform(Transform thisTR)
    {
        instTransform = thisTR;
    }
    public void Dan()
    {
        Debug.Log("Dan");
    }
}
