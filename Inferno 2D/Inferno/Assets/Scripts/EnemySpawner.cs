using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


        public Transform PlayerObject;

        public GameObject Enemy; // the enemy prefab
        public GameObject Door;
        public float mytimer; // the time to wait before spawn
        public int EnemyCounter = 0;

    /// /////////////////////////////////////////////////Lvl 1
    public bool EnemyIsCreated;
        public bool DoorIsCreated;

        private GameObject SpawnedEnemy; // the enemy that was spawned
        private GameObject SpawnedEnemy1;
      
        private GameObject door1;
        private GameObject door2;
        private GameObject door3;
    /// //////////////////////////////////////////////Lvl 2
        private GameObject SpawnedEnemy1_Rm2; 
        private GameObject SpawnedEnemy2_Rm2;
        private GameObject SpawnedEnemy3_Rm2;
        private GameObject SpawnedEnemy4_Rm2;

        private GameObject Rm2_door1;
        private GameObject Rm2_door2;
        private GameObject Rm2_door3;
        private GameObject Rm2_door4;

        public bool EnemyIsCreated2;
        public bool DoorIsCreated2;

    /// ////////////////////////////////////////////////Lvl 3
    
        private GameObject SpawnedEnemy1_Rm3;
        private GameObject SpawnedEnemy2_Rm3;
        private GameObject SpawnedEnemy3_Rm3;
        private GameObject SpawnedEnemy4_Rm3;

        private GameObject Rm3_door1;
        private GameObject Rm3_door2;
        private GameObject Rm3_door3;
        private GameObject Rm3_door4;

        public bool EnemyIsCreated3;
        public bool DoorIsCreated3;

    /// ////////////////////////////////////////////////Lvl 4

        private GameObject SpawnedEnemy1_Rm4;
        private GameObject SpawnedEnemy2_Rm4;
        private GameObject SpawnedEnemy3_Rm4;
        private GameObject SpawnedEnemy4_Rm4;

        private GameObject Rm4_door1;
        private GameObject Rm4_door2;
        private GameObject Rm4_door3;
        private GameObject Rm4_door4;

        public bool EnemyIsCreated4;
        public bool DoorIsCreated4;

    /// ////////////////////////////////////////////////Lvl 5

    private GameObject SpawnedEnemy1_Rm5;
    private GameObject SpawnedEnemy2_Rm5;
    private GameObject SpawnedEnemy3_Rm5;
    private GameObject SpawnedEnemy4_Rm5;

    private GameObject Rm5_door1;
    private GameObject Rm5_door2;
    private GameObject Rm5_door3;
    private GameObject Rm5_door4;

    public bool EnemyIsCreated5;
    public bool DoorIsCreated5;

    /// ////////////////////////////////////////////////Lvl 6

    private GameObject SpawnedEnemy1_Rm6;
    private GameObject SpawnedEnemy2_Rm6;
    private GameObject SpawnedEnemy3_Rm6;
    private GameObject SpawnedEnemy4_Rm6;

    private GameObject Rm6_door1;
    private GameObject Rm6_door2;
    private GameObject Rm6_door3;
    private GameObject Rm6_door4;

    public bool EnemyIsCreated6;
    public bool DoorIsCreated6;

    /// ////////////////////////////////////////////////Lvl 7

    private GameObject SpawnedEnemy1_Rm7;
    private GameObject SpawnedEnemy2_Rm7;
    private GameObject SpawnedEnemy3_Rm7;
    private GameObject SpawnedEnemy4_Rm7;

    private GameObject Rm7_door1;
    private GameObject Rm7_door2;
    private GameObject Rm7_door3;
    private GameObject Rm7_door4;

    public bool EnemyIsCreated7;
    public bool DoorIsCreated7;

    /// ////////////////////////////////////////////////Lvl 8

    private GameObject SpawnedEnemy1_Rm8;
    private GameObject SpawnedEnemy2_Rm8;
    private GameObject SpawnedEnemy3_Rm8;
    private GameObject SpawnedEnemy4_Rm8;

    private GameObject Rm8_door1;
    private GameObject Rm8_door2;
    private GameObject Rm8_door3;
    private GameObject Rm8_door4;
    
    public bool EnemyIsCreated8;
    public bool DoorIsCreated8;


   

    /// ////////////////////////////////////////////////Lvl 9

    private GameObject SpawnedEnemy1_Rm9;
    private GameObject SpawnedEnemy2_Rm9;
    private GameObject SpawnedEnemy3_Rm9;
    private GameObject SpawnedEnemy4_Rm9;

    private GameObject Rm9_door1;
    private GameObject Rm9_door2;
    private GameObject Rm9_door3;
    private GameObject Rm9_door4;

    public bool EnemyIsCreated9;
    public bool DoorIsCreated9;

    /// ////////////////////////////////////////////////Lvl 10

    private GameObject SpawnedEnemy1_Rm10;
    private GameObject SpawnedEnemy2_Rm10;
    private GameObject SpawnedEnemy3_Rm10;
    private GameObject SpawnedEnemy4_Rm10;

    private GameObject Rm10_door1;
    private GameObject Rm10_door2;
    private GameObject Rm10_door3;
    private GameObject Rm10_door4;

    public bool EnemyIsCreated10;
    public bool DoorIsCreated10;

    /// ////////////////////////////////////////////////Lvl 11

    private GameObject SpawnedEnemy1_Rm11;
    private GameObject SpawnedEnemy2_Rm11;
    private GameObject SpawnedEnemy3_Rm11;
    private GameObject SpawnedEnemy4_Rm11;

    private GameObject Rm11_door1;
    private GameObject Rm11_door2;
    private GameObject Rm11_door3;
    private GameObject Rm11_door4;

    public bool EnemyIsCreated11;
    public bool DoorIsCreated11;

    /// ////////////////////////////////////////////////Lvl 12

    private GameObject SpawnedEnemy1_Rm12;
    private GameObject SpawnedEnemy2_Rm12;
    private GameObject SpawnedEnemy3_Rm12;
    private GameObject SpawnedEnemy4_Rm12;

    private GameObject Rm12_door1;
    private GameObject Rm12_door2;
    private GameObject Rm12_door3;
    private GameObject Rm12_door4;

    public bool EnemyIsCreated12;
    public bool DoorIsCreated12;

    public AudioClip DoorSpawnAudio;
    public AudioSource audioSource;

    Animation DeathOfDemon;

    public GameObject Endboss;
    private GameObject SpawnedBoss;

    //public ParticleSystem DoorParticle;

    private void Start()
    {
        //DoorParticle = Door.GetComponent<ParticleSystem>();
        audioSource.clip = DoorSpawnAudio;
    }


    void Update()
    {
        Spawn();
        DoorDeletion();
        CounterCheck();
        Debug.Log("Counter" + EnemyCounter);
    }

    void CounterCheck()
    {
        if (EnemyCounter <= 0)
        {
            EnemyCounter = 0;
        }
    }

    void SpawnEnemy()
    {
        if (!EnemyIsCreated)
        {
            var enemySpawnPoint = GameObject.Find("Rm_1_Spawner1").transform;
            SpawnedEnemy = Instantiate(Enemy, enemySpawnPoint.position, enemySpawnPoint.rotation) as GameObject;
            SpawnedEnemy.GetComponent<AnimationScript>().player = PlayerObject;
            EnemyCounter += 1;
            //DoorParticle.Play();

            var enemySpawnPoint1 = GameObject.Find("Rm_1_Spawner2").transform;
            SpawnedEnemy1 = Instantiate(Enemy, enemySpawnPoint1.position, enemySpawnPoint1.rotation) as GameObject;
            EnemyCounter  += 1;
            SpawnedEnemy1.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated = true;
           
        }

       
    }

    void SpawnDoor()
    {
        if (!DoorIsCreated)
        {
            if (GameObject.Find("Rm_1_B_Door") != null)
            {
                var door1Spawn = GameObject.Find("Rm_1_B_Door").transform;
                door1 = Instantiate(Door, door1Spawn.position, door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_1_T_Door") != null)
            {
                var door1Spawn = GameObject.Find("Rm_1_T_Door").transform;
                door1 = Instantiate(Door, door1Spawn.position, door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_1_R_Door") != null)
            {
                var door1Spawn = GameObject.Find("Rm_1_R_Door").transform;
                door1 = Instantiate(Door, door1Spawn.position, door1Spawn.rotation) as GameObject;
            }
            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
            DoorIsCreated = true;
        }
    }

    void SpawnEnemy2()
    {
        if (!EnemyIsCreated2)
        {
            
            var enemySpawnPoint1_Rm2 = GameObject.Find("Rm_2_Spawner1").transform;
            SpawnedEnemy1_Rm2 = Instantiate(Enemy, enemySpawnPoint1_Rm2.position, enemySpawnPoint1_Rm2.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm2.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm2 = GameObject.Find("Rm_2_Spawner2").transform;
            SpawnedEnemy2_Rm2 = Instantiate(Enemy, enemySpawnPoint2_Rm2.position, enemySpawnPoint2_Rm2.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm2.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm2 = GameObject.Find("Rm_2_Spawner3").transform;
            SpawnedEnemy3_Rm2 = Instantiate(Enemy, enemySpawnPoint3_Rm2.position, enemySpawnPoint3_Rm2.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy3_Rm2.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm2 = GameObject.Find("Rm_2_Spawner4").transform;
            SpawnedEnemy4_Rm2 = Instantiate(Enemy, enemySpawnPoint4_Rm2.position, enemySpawnPoint4_Rm2.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy4_Rm2.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated2 = true;

        }


    }

    void SpawnDoor2()
    {
        if (!DoorIsCreated2)
        {
            if (GameObject.Find("Rm_2_B_Door") != null)
            {
                var Rm_2_door1Spawn = GameObject.Find("Rm_2_B_Door").transform;
                Rm2_door1 = Instantiate(Door, Rm_2_door1Spawn.position, Rm_2_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_2_T_Door") != null)
            {
                var Rm_2_door2Spawn = GameObject.Find("Rm_2_T_Door").transform;
                Rm2_door2 = Instantiate(Door, Rm_2_door2Spawn.position, Rm_2_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_2_R_Door") != null)
            {
                var Rm_2_door3Spawn = GameObject.Find("Rm_2_R_Door").transform;
                Rm2_door3 = Instantiate(Door, Rm_2_door3Spawn.position, Rm_2_door3Spawn.rotation) as GameObject;
            }

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);

            DoorIsCreated2 = true;
        }
    }

    void SpawnEnemy3()
    {
        if (!EnemyIsCreated3)
        {

            var enemySpawnPoint1_Rm3 = GameObject.Find("Rm_3_Spawner1").transform;
            SpawnedEnemy1_Rm3 = Instantiate(Enemy, enemySpawnPoint1_Rm3.position, enemySpawnPoint1_Rm3.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm3.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm3 = GameObject.Find("Rm_3_Spawner2").transform;
            SpawnedEnemy2_Rm3 = Instantiate(Enemy, enemySpawnPoint2_Rm3.position, enemySpawnPoint2_Rm3.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm3.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm3 = GameObject.Find("Rm_3_Spawner3").transform;
            SpawnedEnemy3_Rm3 = Instantiate(Enemy, enemySpawnPoint3_Rm3.position, enemySpawnPoint3_Rm3.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy3_Rm3.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm3 = GameObject.Find("Rm_3_Spawner4").transform;
            SpawnedEnemy4_Rm3 = Instantiate(Enemy, enemySpawnPoint4_Rm3.position, enemySpawnPoint4_Rm3.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy4_Rm3.GetComponent<AnimationScript>().player = PlayerObject;
            
            EnemyIsCreated3 = true;

        }


    }

    void SpawnDoor3()
    {
        if (!DoorIsCreated3)
        {
            if (GameObject.Find("Rm_3_B_Door") != null)
            {
                var Rm_3_door1Spawn = GameObject.Find("Rm_3_B_Door").transform;
                Rm3_door1 = Instantiate(Door, Rm_3_door1Spawn.position, Rm_3_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_3_R_Door") != null)
            {
                var Rm_3_door3Spawn = GameObject.Find("Rm_3_R_Door").transform;
                Rm3_door3 = Instantiate(Door, Rm_3_door3Spawn.position, Rm_3_door3Spawn.rotation) as GameObject;
            }
            

            DoorIsCreated3 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }


    void SpawnEnemy4()
    {
        if (!EnemyIsCreated4)
        {

            var enemySpawnPoint1_Rm4 = GameObject.Find("Rm_4_Spawner1").transform;
            SpawnedEnemy1_Rm4 = Instantiate(Enemy, enemySpawnPoint1_Rm4.position, enemySpawnPoint1_Rm4.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm4.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm4 = GameObject.Find("Rm_4_Spawner2").transform;
            SpawnedEnemy2_Rm4 = Instantiate(Enemy, enemySpawnPoint2_Rm4.position, enemySpawnPoint2_Rm4.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm4.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm4 = GameObject.Find("Rm_4_Spawner3").transform;
            SpawnedEnemy1_Rm4 = Instantiate(Enemy, enemySpawnPoint3_Rm4.position, enemySpawnPoint3_Rm4.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm4.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm4 = GameObject.Find("Rm_4_Spawner4").transform;
            SpawnedEnemy2_Rm4 = Instantiate(Enemy, enemySpawnPoint4_Rm4.position, enemySpawnPoint4_Rm4.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm4.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated4 = true;

        }


    }

    void SpawnDoor4()
    {
        if (!DoorIsCreated4)
        {
            if (GameObject.Find("Rm_4_T_Door") != null)
            {
                var Rm_4_door1Spawn = GameObject.Find("Rm_4_T_Door").transform;
                Rm3_door1 = Instantiate(Door, Rm_4_door1Spawn.position, Rm_4_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_4_R_Door") != null)
            {
                var Rm_4_door3Spawn = GameObject.Find("Rm_4_R_Door").transform;
                Rm4_door2 = Instantiate(Door, Rm_4_door3Spawn.position, Rm_4_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_4_L_Door") != null)
            {
                var Rm_4_door4Spawn = GameObject.Find("Rm_4_L_Door").transform;
                Rm4_door3 = Instantiate(Door, Rm_4_door4Spawn.position, Rm_4_door4Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_4_B_Door") != null)
            {
                var Rm_4_door2Spawn = GameObject.Find("Rm_4_B_Door").transform;
                Rm4_door4 = Instantiate(Door, Rm_4_door2Spawn.position, Rm_4_door2Spawn.rotation) as GameObject;
            }

            DoorIsCreated4 = true;
            audioSource.PlayOneShot(DoorSpawnAudio, 1f);

        }
    }


    void SpawnEnemy5()
    {
        if (!EnemyIsCreated5)
        {

            var enemySpawnPoint1_Rm5 = GameObject.Find("Rm_5_Spawner1").transform;
            SpawnedEnemy1_Rm5 = Instantiate(Enemy, enemySpawnPoint1_Rm5.position, enemySpawnPoint1_Rm5.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm5.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm5 = GameObject.Find("Rm_5_Spawner2").transform;
            SpawnedEnemy2_Rm5 = Instantiate(Enemy, enemySpawnPoint2_Rm5.position, enemySpawnPoint2_Rm5.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm5.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm5 = GameObject.Find("Rm_5_Spawner3").transform;
            SpawnedEnemy1_Rm5 = Instantiate(Enemy, enemySpawnPoint3_Rm5.position, enemySpawnPoint3_Rm5.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm5.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm5 = GameObject.Find("Rm_5_Spawner4").transform;
            SpawnedEnemy2_Rm5 = Instantiate(Enemy, enemySpawnPoint4_Rm5.position, enemySpawnPoint4_Rm5.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm5.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated5 = true;

        }


    }

    void SpawnDoor5()
    {
        if (!DoorIsCreated5)
        {
            if (GameObject.Find("Rm_5_B_Door") != null)
            {
                var Rm_5_door1Spawn = GameObject.Find("Rm_5_B_Door").transform;
                Rm5_door1 = Instantiate(Door, Rm_5_door1Spawn.position, Rm_5_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_5_T_Door") != null)
            {
                var Rm_5_door2Spawn = GameObject.Find("Rm_5_T_Door").transform;
                Rm5_door2 = Instantiate(Door, Rm_5_door2Spawn.position, Rm_5_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_5_L_Door") != null)
            {
                var Rm_5_door3Spawn = GameObject.Find("Rm_5_L_Door").transform;
                Rm5_door3 = Instantiate(Door, Rm_5_door3Spawn.position, Rm_5_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_5_R_Door") != null)
            {
                var Rm_5_door4Spawn = GameObject.Find("Rm_5_R_Door").transform;
                Rm5_door4 = Instantiate(Door, Rm_5_door4Spawn.position, Rm_5_door4Spawn.rotation) as GameObject;
            }
            DoorIsCreated5 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy6()
    {
        if (!EnemyIsCreated6)
        {

            var enemySpawnPoint1_Rm6 = GameObject.Find("Rm_6_Spawner1").transform;
            SpawnedEnemy1_Rm6 = Instantiate(Enemy, enemySpawnPoint1_Rm6.position, enemySpawnPoint1_Rm6.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm6.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm6 = GameObject.Find("Rm_6_Spawner2").transform;
            SpawnedEnemy2_Rm6 = Instantiate(Enemy, enemySpawnPoint2_Rm6.position, enemySpawnPoint2_Rm6.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm6.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm6 = GameObject.Find("Rm_6_Spawner3").transform;
            SpawnedEnemy1_Rm6 = Instantiate(Enemy, enemySpawnPoint3_Rm6.position, enemySpawnPoint3_Rm6.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm6.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm6 = GameObject.Find("Rm_6_Spawner4").transform;
            SpawnedEnemy2_Rm6 = Instantiate(Enemy, enemySpawnPoint4_Rm6.position, enemySpawnPoint4_Rm6.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm6.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated6 = true;

        }


    }

    void SpawnDoor6()
    {
        if (!DoorIsCreated6)
        {
            if (GameObject.Find("Rm_6_L_Door") != null)
            {
                var Rm_6_door1Spawn = GameObject.Find("Rm_6_L_Door").transform;
                Rm6_door1 = Instantiate(Door, Rm_6_door1Spawn.position, Rm_6_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_6_R_Door") != null)
            { 
                var Rm_6_door3Spawn = GameObject.Find("Rm_6_R_Door").transform;
                Rm6_door2 = Instantiate(Door, Rm_6_door3Spawn.position, Rm_6_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_6_B_Door") != null)
            {
                var Rm_6_door2Spawn = GameObject.Find("Rm_6_B_Door").transform;
                Rm6_door3 = Instantiate(Door, Rm_6_door2Spawn.position, Rm_6_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_6_T_Door") != null)
            {
                var Rm_6_door4Spawn = GameObject.Find("Rm_6_T_Door").transform;
                Rm6_door4 = Instantiate(Door, Rm_6_door4Spawn.position, Rm_6_door4Spawn.rotation) as GameObject;
            }


            DoorIsCreated6 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy7()
    {
        if (!EnemyIsCreated7)
        {

            var enemySpawnPoint1_Rm7 = GameObject.Find("Rm_7_Spawner1").transform;
            SpawnedEnemy1_Rm7 = Instantiate(Enemy, enemySpawnPoint1_Rm7.position, enemySpawnPoint1_Rm7.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm7.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm7 = GameObject.Find("Rm_7_Spawner2").transform;
            SpawnedEnemy2_Rm7 = Instantiate(Enemy, enemySpawnPoint2_Rm7.position, enemySpawnPoint2_Rm7.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm7.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm7 = GameObject.Find("Rm_7_Spawner3").transform;
            SpawnedEnemy1_Rm7 = Instantiate(Enemy, enemySpawnPoint3_Rm7.position, enemySpawnPoint3_Rm7.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm7.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm7 = GameObject.Find("Rm_7_Spawner4").transform;
            SpawnedEnemy2_Rm7 = Instantiate(Enemy, enemySpawnPoint4_Rm7.position, enemySpawnPoint4_Rm7.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm7.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated7 = true;

        }


    }

    void SpawnDoor7()
    {
        if (!DoorIsCreated7)
        {
            if (GameObject.Find("Rm_7_R_Door") != null)
            {
                var Rm_7_door1Spawn = GameObject.Find("Rm_7_R_Door").transform;
                Rm7_door1 = Instantiate(Door, Rm_7_door1Spawn.position, Rm_7_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_7_L_Door") != null)
            {
                var Rm_7_door2Spawn = GameObject.Find("Rm_7_L_Door").transform;
                Rm7_door2 = Instantiate(Door, Rm_7_door2Spawn.position, Rm_7_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_7_T_Door") != null)
            {
                var Rm_7_door3Spawn = GameObject.Find("Rm_7_T_Door").transform;
                Rm7_door3 = Instantiate(Door, Rm_7_door3Spawn.position, Rm_7_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_7_B_Door") != null)
            {
                var Rm_7_door4Spawn = GameObject.Find("Rm_7_B_Door").transform;
                Rm7_door4 = Instantiate(Door, Rm_7_door4Spawn.position, Rm_7_door4Spawn.rotation) as GameObject;
            }

            DoorIsCreated7 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy8()
    {
        if (!EnemyIsCreated8)
        {

            var enemySpawnPoint1_Rm8 = GameObject.Find("Rm_8_Spawner1").transform;
            SpawnedEnemy1_Rm8 = Instantiate(Enemy, enemySpawnPoint1_Rm8.position, enemySpawnPoint1_Rm8.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm8.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm8 = GameObject.Find("Rm_8_Spawner2").transform;
            SpawnedEnemy2_Rm8 = Instantiate(Enemy, enemySpawnPoint2_Rm8.position, enemySpawnPoint2_Rm8.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm8.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm8 = GameObject.Find("Rm_8_Spawner3").transform;
            SpawnedEnemy1_Rm8 = Instantiate(Enemy, enemySpawnPoint3_Rm8.position, enemySpawnPoint3_Rm8.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm8.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm8 = GameObject.Find("Rm_8_Spawner4").transform;
            SpawnedEnemy2_Rm8 = Instantiate(Enemy, enemySpawnPoint4_Rm8.position, enemySpawnPoint4_Rm8.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm8.GetComponent<AnimationScript>().player = PlayerObject;
            
            var enemySpawnPoint = GameObject.Find("EndBossSpawner").transform;
            SpawnedBoss = Instantiate(Endboss, enemySpawnPoint.position, enemySpawnPoint.rotation) as GameObject;
            
            EnemyIsCreated8 = true;

        }


    }

    void SpawnDoor8()
    {
        if (!DoorIsCreated8)
        {
            if (GameObject.Find("Rm_8_B_Door") != null)
            {
                var Rm_8_door2Spawn = GameObject.Find("Rm_8_B_Door").transform;
                Rm8_door1 = Instantiate(Door, Rm_8_door2Spawn.position, Rm_8_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_8_T_Door") != null)
            {
                var Rm_8_door3Spawn = GameObject.Find("Rm_8_T_Door").transform;
                Rm8_door2 = Instantiate(Door, Rm_8_door3Spawn.position, Rm_8_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_8_R_Door") != null)
            {
                var Rm_8_door1Spawn = GameObject.Find("Rm_8_R_Door").transform;
                Rm8_door3 = Instantiate(Door, Rm_8_door1Spawn.position, Rm_8_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_8_L_Door") != null)
            {
                var Rm_8_door4Spawn = GameObject.Find("Rm_8_L_Door").transform;
                Rm8_door4 = Instantiate(Door, Rm_8_door4Spawn.position, Rm_8_door4Spawn.rotation) as GameObject;
            }

            DoorIsCreated8 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy9()
    {
        if (!EnemyIsCreated9)
        {

            var enemySpawnPoint1_Rm9 = GameObject.Find("Rm_9_Spawner1").transform;
            SpawnedEnemy1_Rm9 = Instantiate(Enemy, enemySpawnPoint1_Rm9.position, enemySpawnPoint1_Rm9.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm9.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm9 = GameObject.Find("Rm_9_Spawner2").transform;
            SpawnedEnemy2_Rm9 = Instantiate(Enemy, enemySpawnPoint2_Rm9.position, enemySpawnPoint2_Rm9.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm9.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm9 = GameObject.Find("Rm_9_Spawner3").transform;
            SpawnedEnemy1_Rm9 = Instantiate(Enemy, enemySpawnPoint3_Rm9.position, enemySpawnPoint3_Rm9.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm9.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm9 = GameObject.Find("Rm_9_Spawner4").transform;
            SpawnedEnemy2_Rm9 = Instantiate(Enemy, enemySpawnPoint4_Rm9.position, enemySpawnPoint4_Rm9.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm9.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated9 = true;

        }


    }

    void SpawnDoor9()
    {
        if (!DoorIsCreated9)
        {
            if (GameObject.Find("Rm_9_B_Door") != null)
            {
                var Rm_9_door2Spawn = GameObject.Find("Rm_9_B_Door").transform;
                Rm9_door1 = Instantiate(Door, Rm_9_door2Spawn.position, Rm_9_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_9_L_Door") != null)
            {
                var Rm_9_door3Spawn = GameObject.Find("Rm_9_L_Door").transform;
                Rm9_door2 = Instantiate(Door, Rm_9_door3Spawn.position, Rm_9_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_9_R_Door") != null)
            {
                var Rm_9_door1Spawn = GameObject.Find("Rm_9_R_Door").transform;
                Rm9_door3 = Instantiate(Door, Rm_9_door1Spawn.position, Rm_9_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_9_T_Door") != null)
            {
                var Rm_9_door4Spawn = GameObject.Find("Rm_9_T_Door").transform;
                Rm9_door4 = Instantiate(Door, Rm_9_door4Spawn.position, Rm_9_door4Spawn.rotation) as GameObject;
            }

            DoorIsCreated9 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy10()
    {
        if (!EnemyIsCreated10)
        {

            var enemySpawnPoint1_Rm10 = GameObject.Find("Rm_10_Spawner1").transform;
            SpawnedEnemy1_Rm10 = Instantiate(Enemy, enemySpawnPoint1_Rm10.position, enemySpawnPoint1_Rm10.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm10.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm10 = GameObject.Find("Rm_10_Spawner2").transform;
            SpawnedEnemy2_Rm10 = Instantiate(Enemy, enemySpawnPoint2_Rm10.position, enemySpawnPoint2_Rm10.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm10.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm10 = GameObject.Find("Rm_10_Spawner3").transform;
            SpawnedEnemy1_Rm10 = Instantiate(Enemy, enemySpawnPoint3_Rm10.position, enemySpawnPoint3_Rm10.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm10.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm10 = GameObject.Find("Rm_10_Spawner4").transform;
            SpawnedEnemy2_Rm10 = Instantiate(Enemy, enemySpawnPoint4_Rm10.position, enemySpawnPoint4_Rm10.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm10.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated10 = true;

        }


    }

    void SpawnDoor10()
    {
        if (!DoorIsCreated10)
        {
            if (GameObject.Find("Rm_10_T_Door") != null)
            {
                var Rm_10_door2Spawn = GameObject.Find("Rm_10_T_Door").transform;
                Rm10_door1 = Instantiate(Door, Rm_10_door2Spawn.position, Rm_10_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_10_L_Door") != null)
            {
                var Rm_10_door3Spawn = GameObject.Find("Rm_10_L_Door").transform;
                Rm10_door2 = Instantiate(Door, Rm_10_door3Spawn.position, Rm_10_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_10_R_Door") != null)
            {
                var Rm_10_door1Spawn = GameObject.Find("Rm_10_R_Door").transform;
                Rm10_door3 = Instantiate(Door, Rm_10_door1Spawn.position, Rm_10_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_10_B_Door") != null)
            {
                var Rm_10_door4Spawn = GameObject.Find("Rm_10_L_Door").transform;
                Rm10_door4 = Instantiate(Door, Rm_10_door4Spawn.position, Rm_10_door4Spawn.rotation) as GameObject;
            }


            DoorIsCreated10 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy11()
    {
        if (!EnemyIsCreated11)
        {

            var enemySpawnPoint1_Rm11 = GameObject.Find("Rm_11_Spawner1").transform;
            SpawnedEnemy1_Rm11 = Instantiate(Enemy, enemySpawnPoint1_Rm11.position, enemySpawnPoint1_Rm11.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm11.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint2_Rm11 = GameObject.Find("Rm_11_Spawner2").transform;
            SpawnedEnemy2_Rm11 = Instantiate(Enemy, enemySpawnPoint2_Rm11.position, enemySpawnPoint2_Rm11.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm11.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm11 = GameObject.Find("Rm_11_Spawner3").transform;
            SpawnedEnemy1_Rm11 = Instantiate(Enemy, enemySpawnPoint3_Rm11.position, enemySpawnPoint3_Rm11.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm11.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm11 = GameObject.Find("Rm_11_Spawner4").transform;
            SpawnedEnemy2_Rm11 = Instantiate(Enemy, enemySpawnPoint4_Rm11.position, enemySpawnPoint4_Rm11.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm11.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated11 = true;

        }


    }

    void SpawnDoor11()
    {
        if (!DoorIsCreated11)
        {
            if (GameObject.Find("Rm_11_T_Door") != null)
            {
                var Rm_11_door2Spawn = GameObject.Find("Rm_11_T_Door").transform;
                Rm11_door1 = Instantiate(Door, Rm_11_door2Spawn.position, Rm_11_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_11_B_Door") != null)
            {
                var Rm_11_door3Spawn = GameObject.Find("Rm_11_B_Door").transform;
                Rm11_door2 = Instantiate(Door, Rm_11_door3Spawn.position, Rm_11_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_11_L_Door") != null)
            {
                var Rm_11_door4Spawn = GameObject.Find("Rm_11_L_Door").transform;
                Rm11_door3 = Instantiate(Door, Rm_11_door4Spawn.position, Rm_11_door4Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_11_R_Door") != null)
            {
                var Rm_11_door1Spawn = GameObject.Find("Rm_11_R_Door").transform;
                Rm11_door4 = Instantiate(Door, Rm_11_door1Spawn.position, Rm_11_door1Spawn.rotation) as GameObject;
            }

            DoorIsCreated11 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }

    void SpawnEnemy12()
    {
        if (!EnemyIsCreated12)
        {

            var enemySpawnPoint1_Rm12 = GameObject.Find("Rm_12_Spawner1").transform;
            SpawnedEnemy1_Rm12 = Instantiate(Enemy, enemySpawnPoint1_Rm12.position, enemySpawnPoint1_Rm12.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm12.GetComponent<AnimationScript>().player = PlayerObject;
            

            var enemySpawnPoint2_Rm12 = GameObject.Find("Rm_12_Spawner2").transform;
            SpawnedEnemy2_Rm12 = Instantiate(Enemy, enemySpawnPoint2_Rm12.position, enemySpawnPoint2_Rm12.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm12.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint3_Rm12 = GameObject.Find("Rm_12_Spawner3").transform;
            SpawnedEnemy1_Rm12 = Instantiate(Enemy, enemySpawnPoint3_Rm12.position, enemySpawnPoint3_Rm12.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy1_Rm12.GetComponent<AnimationScript>().player = PlayerObject;

            var enemySpawnPoint4_Rm12 = GameObject.Find("Rm_12_Spawner4").transform;
            SpawnedEnemy2_Rm12 = Instantiate(Enemy, enemySpawnPoint4_Rm12.position, enemySpawnPoint4_Rm12.rotation) as GameObject;
            EnemyCounter += 1;
            SpawnedEnemy2_Rm12.GetComponent<AnimationScript>().player = PlayerObject;

            EnemyIsCreated12 = true;

        }


    }

    void SpawnDoor12()
    {
        if (!DoorIsCreated12)
        {
            if (GameObject.Find("Rm_12_B_Door") != null)
            {
                var Rm_12_door2Spawn = GameObject.Find("Rm_12_B_Door").transform;
                Rm12_door1 = Instantiate(Door, Rm_12_door2Spawn.position, Rm_12_door2Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_12_L_Door") != null)
            {
                var Rm_12_door3Spawn = GameObject.Find("Rm_12_L_Door").transform;
                Rm12_door2 = Instantiate(Door, Rm_12_door3Spawn.position, Rm_12_door3Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_12_R_Door") != null)
            {
                var Rm_12_door1Spawn = GameObject.Find("Rm_12_R_Door").transform;
                Rm12_door3 = Instantiate(Door, Rm_12_door1Spawn.position, Rm_12_door1Spawn.rotation) as GameObject;
            }
            if (GameObject.Find("Rm_12_T_Door") != null)
            {
                var Rm_12_door4Spawn = GameObject.Find("Rm_12_T_Door").transform;
                Rm12_door4 = Instantiate(Door, Rm_12_door4Spawn.position, Rm_12_door4Spawn.rotation) as GameObject;
            }


            DoorIsCreated12 = true;

            audioSource.PlayOneShot(DoorSpawnAudio, 1f);
        }
    }


    void Spawn()
         { 
          if (Player.spawnVarRoom1 == 1)
            {
            
            SpawnEnemy();
            SpawnDoor();
            Destroy(GameObject.Find("Rm_1_Spawner1"));
            Destroy(GameObject.Find("Rm_1_Spawner2"));
            Player.spawnVarRoom1 = 0;
            Debug.Log("rOOM 1");
            //Destroy(this.gameObject); //Destroys main spawner
        }
          else
        if (Player.spawnVarRoom2 == 1)
        {
            Debug.Log("Room 2 spawn running");
            SpawnEnemy2();
            SpawnDoor2();
            Destroy(GameObject.Find("Rm_2_Spawner1"));
            Destroy(GameObject.Find("Rm_2_Spawner2"));
            Destroy(GameObject.Find("Rm_2_Spawner3"));
            Destroy(GameObject.Find("Rm_2_Spawner4"));
            Player.spawnVarRoom2 = 0;
            Debug.Log("rOOM 2");
            //Destroy(this.gameObject); //Destroys main spawner
        }
        else
        if (Player.spawnVarRoom3 == 1)
        {
            Debug.Log("Room 3 spawn running");
            SpawnEnemy3();
            SpawnDoor3();
            Destroy(GameObject.Find("Rm_3_Spawner1"));
            Destroy(GameObject.Find("Rm_3_Spawner2"));
            Destroy(GameObject.Find("Rm_3_Spawner3"));
            Destroy(GameObject.Find("Rm_3_Spawner4"));
            Player.spawnVarRoom3 = 0;
            Debug.Log("rOOM 3");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom4 == 1)
        {
            Debug.Log("Room 4 spawn running");
            SpawnEnemy4();
            SpawnDoor4();
            Destroy(GameObject.Find("Rm_4_Spawner1"));
            Destroy(GameObject.Find("Rm_4_Spawner2"));
            Destroy(GameObject.Find("Rm_4_Spawner3"));
            Destroy(GameObject.Find("Rm_4_Spawner4"));
            Player.spawnVarRoom4 = 0;
            Debug.Log("rOOM 4");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom5 == 1)
        {
            Debug.Log("Room 5 spawn running");
            SpawnEnemy5();
            SpawnDoor5();
            Destroy(GameObject.Find("Rm_5_Spawner1"));
            Destroy(GameObject.Find("Rm_5_Spawner2"));
            Destroy(GameObject.Find("Rm_5_Spawner3"));
            Destroy(GameObject.Find("Rm_5_Spawner4"));
            Player.spawnVarRoom5 = 0;
            Debug.Log("rOOM 5");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom6 == 1)
        {
            Debug.Log("Room 6 spawn running");
            SpawnEnemy6();
            SpawnDoor6();
            Destroy(GameObject.Find("Rm_6_Spawner1"));
            Destroy(GameObject.Find("Rm_6_Spawner2"));
            Destroy(GameObject.Find("Rm_6_Spawner3"));
            Destroy(GameObject.Find("Rm_6_Spawner4"));
            Player.spawnVarRoom6 = 0;
            Debug.Log("rOOM 6");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom7 == 1)
        {
            Debug.Log("Room 7 spawn running");
            SpawnEnemy7();
            SpawnDoor7();
            Destroy(GameObject.Find("Rm_7_Spawner1"));
            Destroy(GameObject.Find("Rm_7_Spawner2"));
            Destroy(GameObject.Find("Rm_7_Spawner3"));
            Destroy(GameObject.Find("Rm_7_Spawner4"));
            Player.spawnVarRoom7 = 0;
            Debug.Log("rOOM 7");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom8 == 1)
        {
            Debug.Log("Room 8 spawn running");
            SpawnEnemy8();
            SpawnDoor8();
            Destroy(GameObject.Find("Rm_8_Spawner1"));
            Destroy(GameObject.Find("Rm_8_Spawner2"));
            Destroy(GameObject.Find("Rm_8_Spawner3"));
            Destroy(GameObject.Find("Rm_8_Spawner4"));
            Player.spawnVarRoom8 = 0;
            Debug.Log("rOOM 8");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom9 == 1)
        {
            Debug.Log("Room 9 spawn running");
            SpawnEnemy9();
            SpawnDoor9();
            Destroy(GameObject.Find("Rm_9_Spawner1"));
            Destroy(GameObject.Find("Rm_9_Spawner2"));
            Destroy(GameObject.Find("Rm_9_Spawner3"));
            Destroy(GameObject.Find("Rm_9_Spawner4"));
            Player.spawnVarRoom9 = 0;
            Debug.Log("rOOM 9");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom10 == 1)
        {
            Debug.Log("Room 10 spawn running");
            SpawnEnemy10();
            SpawnDoor10();
            Destroy(GameObject.Find("Rm_10_Spawner1"));
            Destroy(GameObject.Find("Rm_10_Spawner2"));
            Destroy(GameObject.Find("Rm_10_Spawner3"));
            Destroy(GameObject.Find("Rm_10_Spawner4"));
            Player.spawnVarRoom10 = 0;
            Debug.Log("rOOM 10");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom11 == 1)
        {
            Debug.Log("Room 11 spawn running");
            SpawnEnemy11();
            SpawnDoor11();
            Destroy(GameObject.Find("Rm_11_Spawner1"));
            Destroy(GameObject.Find("Rm_11_Spawner2"));
            Destroy(GameObject.Find("Rm_11_Spawner3"));
            Destroy(GameObject.Find("Rm_11_Spawner4"));
            Player.spawnVarRoom11 = 0;
            Debug.Log("rOOM 11");
            //Destroy(this.gameObject); //Destroys main spawner
        }

        if (Player.spawnVarRoom12 == 1)
        {
            Debug.Log("Room 12 spawn running");
            SpawnEnemy12();
            SpawnDoor12();
            Destroy(GameObject.Find("Rm_12_Spawner1"));
            Destroy(GameObject.Find("Rm_12_Spawner2"));
            Destroy(GameObject.Find("Rm_12_Spawner3"));
            Destroy(GameObject.Find("Rm_12_Spawner4"));
            Player.spawnVarRoom12 = 0;
            Debug.Log("rOOM 12");
            //Destroy(this.gameObject); //Destroys main spawner
        }

    }

    void DoorDeletion()
    {
       if ((EnemyCounter == 0) && (EnemyIsCreated == true))
       {
            Destroy(GameObject.FindWithTag("Door"));
            Debug.Log("Door deletion enemyspawner");

        }
       

    }
}
