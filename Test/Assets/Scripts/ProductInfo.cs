using UnityEngine;

[System.Serializable]
public class ProductInfo
{
    public string prod_name;
    public string prod_desc;

    public static ProductInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<ProductInfo>(jsonString);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}
