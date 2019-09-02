using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataLoader : MonoBehaviour {
    public DataVisualizer Visualizer;
   // public DataViz Visualizer;
    // Use this for initialization
    void Start ()

    {
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
[System.Serializable]
public class SeriesArray
{
    // makes the AllData public and avaliable to all classes. 
    public SeriesData[] AllData;
}