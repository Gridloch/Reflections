using System.Collections.Generic;
[System.Serializable]
public class PlayerData
{
    // The version of the data format
    public int version = 1;

    // Use with https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tobinary?view=net-9.0 
    // and https://learn.microsoft.com/en-us/dotnet/api/system.datetime.frombinary?view=net-9.0
    public JsonDateTime timeDayStart = (JsonDateTime) System.DateTime.Now;
    public int money = 1000;

    // public int careSlots;

    // Home customisation options
    public RoomCustomisation roomCustomisation;

    public RoomCustomisation GetRoomCustomisation()
    {
        if (roomCustomisation == null)
        {
            roomCustomisation = new RoomCustomisation();
        }
        return roomCustomisation;
    }

}  