// In Unity you always start by importing all the Unity libraries you need
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataLoader : MonoBehaviour {
//Import the Data Visualizer object that the data visualizer script is attatched to as Visualizer
    public DataVisualizer Visualizer;

    // Use this for initialization
    void Start ()

    {
	 //Access the Unity scenes through the scene manager, using the function .GetActiveScene()
        Scene scene = SceneManager.GetActiveScene();

        //loads selected json data set corrleating with correct scene
        if (scene.name == "Level1_Rlobe")
        {
           TextAsset jsonData = Resources.Load<TextAsset>("RLobe1");
           //TextAsset jsonData = Resources.Load<TextAsset>("N_simulated_braincoordinates");
            //Debug.Log(jsonData);
           // TextAsset jsonData = Resources.Load<TextAsset>("Data_Test");


            string json = jsonData.text;
            SeriesArray data = JsonUtility.FromJson<SeriesArray>(json);
            //accesses all data variable where all the timestamp arrays are stored. 
            Visualizer.CreateMeshes(data.AllData);

        }


        //loads selected json data set corrleating with correct scene
        if (scene.name == "Level2_Elsewhere")
        {
            TextAsset jsonData = Resources.Load<TextAsset>("Elsewhere1");
            Debug.Log(jsonData);
            //TextAsset jsonData = Resources.Load<TextAsset>("TestBrainCoordinates");


            string json = jsonData.text;
            SeriesArray data = JsonUtility.FromJson<SeriesArray>(json);
            //accesses all data variable where all the timestamp arrays are stored. 
            Visualizer.CreateMeshes(data.AllData);

        }


    }
	
	void Update () {
	
	}
}
//Down here we are accessing the SeriesArray class that is storeed in the Data Visualizer script. 
[System.Serializable]
public class SeriesArray
{
    // makes the AllData public and avaliable to all classes. 
	// We need to access the SeriesData variable to access and change the data used within the instaited mesh. 
    public SeriesData[] AllData;
}
