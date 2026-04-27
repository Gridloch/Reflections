// https://gamedev.stackexchange.com/questions/137523/unity-json-utility-does-not-serialize-datetime#137526
using System.Collections.Generic;
[System.Serializable]
public struct JsonDateTime {
    public long value;
    public static implicit operator System.DateTime(JsonDateTime jdt) {
        return System.DateTime.FromFileTimeUtc(jdt.value);
    }
    public static implicit operator JsonDateTime(System.DateTime dt) {
        JsonDateTime jdt = new JsonDateTime();
        jdt.value = dt.ToFileTimeUtc();
        return jdt;
    }
}