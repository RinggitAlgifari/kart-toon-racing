// Copyright (c) 2021 Justin Couch / JustInvoke
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerslideKartPhysics
{
    // This class controls the menu in the demo and spawns karts
    public class DemoMenu : MonoBehaviour
    {
        public Vector3 spawnPoint = Vector3.zero;
        public Vector3 spawnDir = Vector3.forward;
        public GameObject uiContainer;
        public KartCamera kartCam;

        public GameObject kart;
        
        public GameObject[] characterPrefabs;
	    //public Transform spawnPoint;

        public bool MultiplayerScene;

        private void Awake()
        {
            // Hide UI when showing the menu
            if (uiContainer != null)
            {
                uiContainer.SetActive(false);
            }
        }

        /*public void SpawnKart()
        {
            // Spawn a given kart at the spawn point
            Kart newKart = null;
            if (kart != null)
            {
                //newKart = Instantiate(kart, spawnPoint, Quaternion.LookRotation(spawnDir.normalized, Vector3.up)).GetComponent<Kart>();
            }

            // Show the UI and connect it to the spawned kart
            if (uiContainer != null)
            {
                UIControl uiController = uiContainer.GetComponent<UIControl>();
                if (uiController != null)
                {
                    uiController.Initialize(newKart);
                }

                uiContainer.SetActive(true);
            }

            // Connect the camera to the spawned kart
            if (kartCam != null)
            {
                kartCam.Initialize(newKart);
            }

            gameObject.SetActive(false);
        }*/

        /*public void SpawnKart()
        {
            // Spawn a given kart at the spawn point
            Kart newKart = null;
            if (kart != null)
            {
                //int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
                //GameObject prefab = characterPrefabs[selectedCharacter];
                //GameObject clone = Instantiate(prefab, spawnPoint, Quaternion.LookRotation(spawnDir.normalized, Vector3.up)).GetComponent<Kart>();
                //newKart = Instantiate(prefab, spawnPoint, Quaternion.LookRotation(spawnDir.normalized, Vector3.up)).GetComponent<Kart>();
                //newKart = Instantiate(prefab, spawnPoint, Quaternion.LookRotation(spawnDir.normalized, Vector3.up)).GetComponent<Kart>();
            }

            // Show the UI and connect it to the spawned kart
            if (uiContainer != null)
            {
                UIControl uiController = uiContainer.GetComponent<UIControl>();
                if (uiController != null)
                {
                    uiController.Initialize(newKart);
                }

                uiContainer.SetActive(true);
            }

            // Connect the camera to the spawned kart
            if (kartCam != null)
            {
                kartCam.Initialize(newKart);
            }

            gameObject.SetActive(false);
        }*/

        // Visualize the kart spawn point
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(spawnPoint, 0.5f);
            Gizmos.DrawRay(spawnPoint + spawnDir.normalized * 0.5f, spawnDir.normalized);
        }

        void Start(){
            if (MultiplayerScene == false){
                Kart newKart = null;
                if (kart != null)
                {
                    int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
                    GameObject kart = characterPrefabs[selectedCharacter];
                    //GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
                    newKart = Instantiate(kart, spawnPoint, Quaternion.LookRotation(spawnDir.normalized, Vector3.up)).GetComponent<Kart>();
                }

                if (uiContainer != null)
                {
                    UIControl uiController = uiContainer.GetComponent<UIControl>();
                    if (uiController != null)
                    {
                        uiController.Initialize(newKart);
                    }

                    uiContainer.SetActive(true);
                }

                // Connect the camera to the spawned kart
                if (kartCam != null)
                {
                    kartCam.Initialize(newKart);
                }

                //gameObject.SetActive(false);

                //StartCoroutine(SpawnTime());
            }
            if (MultiplayerScene == true){
                Debug.Log("Multiplayer Scene");
            }
        }

        void Update(){
            if (Input.GetKeyDown("r")){
                PlayerPrefs.DeleteAll();
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        IEnumerator SpawnTime(){
            yield return new WaitForSeconds(1f);
            //SpawnKart();
        }
    }
}
