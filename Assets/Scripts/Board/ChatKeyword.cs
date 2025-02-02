using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;




[Serializable]
public class KeywordData
{
    public string keywordCount2;
    public string keywordCount1;
    public string keywordContent2;
    public string keywordContent1;
}


[Serializable]
public class ResponseKeywordData
{
    public int status;
    public string message;
    public KeywordData data;
}

public class ChatKeyword : MonoBehaviour
{
    public static ChatKeyword Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public InputField id;
    public InputField password;
    public KeywordData keydata;
    //public KeywordData keywordCount;
    

    public void OnKeywordClickAll()
    {
        HttpRequester requester = new HttpRequester();
        requester.url = "http://3.34.133.115:8080/keyword";
        //print(requester.url);
        requester.requestType = RequestType.GET;

        requester.onComplete = OnCilckDownloadAll;


        HttpManager.instance.SendRequest(requester);
    }

    public void OnCilckDownloadAll(DownloadHandler handler)
    {

        string data = System.Text.Encoding.Default.GetString(handler.data);
        print("data : " + data);

        ResponseKeywordData keyword = JsonUtility.FromJson<ResponseKeywordData>(data);

        keydata = keyword.data;
        print(keydata.keywordContent1);
        


        //int("��ȸ�Ϸ�");
        //ResponseKeywordData keyword = JsonUtility.FromJson<ResponseKeywordData>(data);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
