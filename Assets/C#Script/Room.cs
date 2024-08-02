using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Room : MonoBehaviour
{
    public RoomData thisRoom;
    
    public void MakeRoom(int layout,RoomData[] roomData)//部屋データを作る
    {
        List<int> layoutList = new List<int>();
        for (int i = 0; i < roomData.Length; i++)
        {
            if (roomData[i].rootLayout == layout)
            {
                layoutList.Add(layout);
            }
        }
        try
        {
            int useNumber = layoutList[Random.Range(0,layoutList.Count)];
            thisRoom = roomData[useNumber];
            
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = roomData[useNumber].roomSprite;
        }
        catch
        {
            Debug.LogError("どっかミスってます\n" + layout);
            return;
        }
        

    }
}
