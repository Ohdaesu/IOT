using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;

using System;

public class mqttTest : MonoBehaviour {

	public GameObject receiver;
	public String [] msg;
	public String subTopic;
	public String pubTopic;
	public String ip = "192.168.0.22";
	public int port = 1883;

	private bool isReceive = false;
	private string receiveMsg;


	private MqttClient client;

	// Use this for initialization
	void Start () {
		// create client instance 
		client = new MqttClient(IPAddress.Parse(ip),port, false , null ); 

		// register to message received 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 

		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 

		// subscribe to the topic "/home/temperature" with QoS 2 
		client.Subscribe(new string[] {subTopic}, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE }); 


	}
	void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message));
		receiveMsg = System.Text.Encoding.UTF8.GetString (e.Message);
		isReceive = true;
	} 
		
	public void pubMSG(int msgNum)
	{
		//if (msgNum > msg.Length - 1)
		//	msgNum = msg.Length - 1;
		Debug.Log("sending...");
		client.Publish(pubTopic, System.Text.Encoding.UTF8.GetBytes(msg[msgNum]), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
		Debug.Log("sent");
	}
	// Update is called once per frame
	public void Update ()
	{
		if (isReceive)
		{
			receiver.GetComponent<AbstractReceiver> ().receiveHandler (receiveMsg);
			isReceive = false;
		}
	}
}