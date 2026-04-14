using UnityEngine;
using System;

using System.Runtime.InteropServices;

public class SaveLoadManager : MonoBehaviour
{
    public static SaveLoadManager Instance;
    public PlayerData playerData;

    
    #if !UNITY_EDITOR && UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void SaveToLocalStorage(string jsonString);

        [DllImport("__Internal")]
        private static extern IntPtr LoadFromLocalStorage();
    #endif

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        playerData = GetJSON();
        if (playerData == null)
        {
            playerData = new PlayerData();
        }
        // Debug.Log("PlayerData: " + playerData);
    }

    public static void SaveJSON()
    {
        string value = JsonUtility.ToJson(Instance.playerData, true);
        #if !UNITY_EDITOR && UNITY_WEBGL
            SaveToLocalStorage(value);
        #else
            PlayerPrefs.SetString("reflectionsData", value);
        #endif
    }

    public static PlayerData GetJSON()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
            IntPtr valuePtr = LoadFromLocalStorage();
            string value = Marshal.PtrToStringUTF8(valuePtr);
        #else
            string value = PlayerPrefs.GetString("reflectionsData");
        #endif
        return JsonUtility.FromJson<PlayerData>(value);
    }
}
