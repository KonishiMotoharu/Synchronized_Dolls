using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    static public int currentFloor;

    public RoomData[] roomData;

    private Room[,] rooms;

    [SerializeField] private GameObject room;
    // Start is called before the first frame update
    void Start()
    {
        int xLength = Random.Range(3, 6),yLength = Random.Range(3, 6);
        rooms = new Room[xLength,yLength];
        Vector2 goal = new Vector2(Random.Range(2, 10),Random.Range(2,10));
        for(int i = 0;i < xLength; i++)
        {
            for(int j = 0;j < yLength;j++)
            {
                Room newRoom = Instantiate(room,new Vector3(i * 8,j * 8,0),Quaternion.identity).GetComponent<Room>();
                newRoom.transform.parent = transform;
                int roomNumber = 0;
                
                if (i == 0 || j == 0 || i == xLength - 1 || j == yLength - 1)
                {
                    roomNumber = 0;
                    rooms[i, j] = newRoom;
                    newRoom.MakeRoom(roomNumber,roomData);
                    continue;
                }
                else if(i == 1 && j == 1)
                {
                    roomNumber = 8;
                    rooms[i, j] = newRoom;
                    newRoom.MakeRoom(roomNumber, roomData);
                    continue;
                }
                if (rooms[i,j - 1].thisRoom.rootLayout % 2 == 1)
                {
                    roomNumber += 4;
                }
                if ((rooms[i - 1,j].thisRoom.rootLayout - rooms[i - 1, j].thisRoom.rootLayout % 4) % 16 == 8)
                {
                    roomNumber += 2;
                }
                
                rooms[i, j] = newRoom;

                roomNumber += Random.Range(0, 2) + 8 * Random.Range(0, 2);

                newRoom.MakeRoom(roomNumber,roomData);
            }
        }
        
    }

}
