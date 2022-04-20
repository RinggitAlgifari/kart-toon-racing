using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.UI;

public class lobbyManager : MonoBehaviourPunCallbacks
{
    public GameObject playButton;
    //public GameObject cancelButton;
    public GameObject searchingPanel;
    public GameObject connectingPanel;

    public string LoadKeScene;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Connected...");
        PhotonNetwork.AutomaticallySyncScene = true;
        //playButton.SetActive(true);
        connectingPanel.gameObject.SetActive(false);
    }

    public void findMatch()
    {
        PhotonNetwork.JoinRandomRoom();
        //playButton.SetActive(false);
        searchingPanel.gameObject.SetActive(true);
        print("Searching for game...");
    }

    public void quitMatch()
    {
        PhotonNetwork.LeaveRoom();
        //playButton.SetActive(true);
        connectingPanel.SetActive(true);
        searchingPanel.gameObject.SetActive(false);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        print("No rooms available - creating one...");
        makeRoom();
    }

    void makeRoom()
    {
        string randomRoomName = Random.Range(0, 10000).ToString() + "." + Random.Range(0, 10000).ToString();
        RoomOptions roomOptions =
        new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 2
        };

        PhotonNetwork.CreateRoom(randomRoomName, roomOptions);
        print("Room created waiting for other players...");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 && PhotonNetwork.IsMasterClient)
        {
            print("All players connected, starting game");
            PhotonNetwork.LoadLevel(LoadKeScene);
        }
        print("1/2");
    }

    public void MainSinglePlayer(){
        Application.LoadLevel("SinglePlayer");
    }
}
