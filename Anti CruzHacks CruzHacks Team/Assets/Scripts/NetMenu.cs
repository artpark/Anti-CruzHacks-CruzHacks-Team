using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetMenu : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle();
    private int state = 0;
	public string serverIP = "IP Address";
	string myIP;
	public string hostString = "Hosting server on ";
    NetworkClient myClient;
	public string pingString = "Ping: ";
	private int currentPing;
	//public Button S;
	//public Button C;
	void Start()
	{
		//S = GetComponent<Button>();
		//C = GetComponent<Button>();
		
		myIP = GetLocalIPAddress();
		this.StartCoroutine(PingUpdate());
	}
    void Update () 
    {
		if(state == 2)
		{
			StartCoroutine (PingUpdate());			
		}
	}
    void OnGUI()
    {
		guiStyle.fontSize = 20; //change the font size
		guiStyle.normal.textColor = Color.white;
        if (state == 0)
        {
            if(GUI.Button(new Rect(180, 180, 150, 25), "Host", guiStyle)){ SetupServer(); }
			if(GUI.Button(new Rect(180, 230, 75, 25), "Join", guiStyle)){ SetupClient(); }
			serverIP = GUI.TextField(new Rect(250, 230, 150, 20), serverIP, 25);
			
        }
		 if (state == 1)
		 {
			 GUI.Label(new Rect(180, 230, 150, 100), String.Concat(hostString, myIP), guiStyle);     
		 }
		 if (state == 2)
		 {
			GUI.Label(new Rect(180, 230, 150, 100), "Connected to server.", guiStyle);
			GUI.Label(new Rect(180, 250, 150, 100), String.Concat(pingString, currentPing.ToString()), guiStyle); 
		 }
    }  
// Create a server and listen on a port
    public void SetupServer()
    {
        NetworkServer.Listen(4444);
        state = 1;
    }
    
    // Create a client and connect to the server port
    public void SetupClient()
    {
        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);     
        myClient.Connect(serverIP, 4444);
    }
    
    // Create a local client and connect to the local server
    public void SetupLocalClient()
    {
        myClient = ClientScene.ConnectLocalServer();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);     
    }
// client function
    public void OnConnected(NetworkMessage netMsg)
    {
        Debug.Log("Connected to server");
		state = 2;
    }	

   IEnumerator PingUpdate()
    {
        RestartLoop:
        var ping = new Ping(serverIP);
 
        yield return new WaitForSeconds(1f);
        while (!ping.isDone) yield return null;
 
        Debug.Log(ping.time);
        currentPing = (ping.time);
 
        goto RestartLoop;
    }
	
	public static string GetLocalIPAddress()
    {
        var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }

        throw new System.Exception("No network adapters with an IPv4 address in the system!");
    }
	public void serverEvent(){ SetupServer();}
	public void clientEvent(){ SetupClient();}
}

