using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Move all of *gestures broadly* this into its own file!

[Serializable]
public class Category
{
    public string name;
    public Level[] levels;

    int size() {
        return levels.Length;
    }
}

[Serializable]
public class Hint
{
    public int cost;
    public string type;
    public string content;
}

[Serializable]
class Level
{
    public string[] answer;
    public Hint[] hints;
    bool guessed;
    int last_guessed;
}

public class LevelManagement : MonoBehaviour
{
    public TextAsset categoriesFolder;
    [Serializable] private int stuff;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void updateCategories()
    {
        Category category = JsonUtility.FromJson<Category>(jsonFile.text);  // TODO: Yes, this just loads a single category.
    }

    void GetCategoryStats(string name) 
    {

    }

    void LoadLevel(string filename)
    {

    }
}
