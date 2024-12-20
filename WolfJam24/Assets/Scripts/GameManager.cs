using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    private float[] correctFrequencies = {100.8f, 92.0f, 97.3f};

    public bool deliveredGood = false;

    private int currentPackage = 0;

    public float CorrectFrequency => correctFrequencies[currentPackage];
    public int CurrentPackage => currentPackage;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextPackage()
    {
        currentPackage++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
