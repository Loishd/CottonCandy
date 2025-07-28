using System;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]

public struct ObjectGroup
{

    public string groupID;
    public GameObject[] objects;
}

public class ObjectLibrary : MonoBehaviour
{
    public ObjectGroup[] objectGroups;
    public int Num = 0;
    public GameObject GetRandomObjectFromGroup(string name)
    {
        foreach (var group in objectGroups)
        {
            if (group.groupID == name)
            {
                return group.objects[UnityEngine.Random.Range(0, group.objects.Length)];
            }
        }
        return null;
    }

    //SoundManager.Instance.PlaySound2D("SFX02");
    void update()
    {
        if (Input.GetMouseButtonDown(0))
        {


           
            Num += 1;
            return;
        }
    }

}
