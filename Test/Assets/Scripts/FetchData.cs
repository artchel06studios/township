using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Http;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;
using System;

public class FetchData : MonoBehaviour
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
    // jamjam
>>>>>>> parent of 06156ed (test1)
>>>>>>> parent of b9a9b3d (Update FetchData.cs)
    public TMP_Text row_name;
    public TMP_Text row_desc;
    public static HttpClient client;
    // Start is called before the first frame update
    async void Start()
    {
        client = new HttpClient();
        ProductInfo pinfo = ProductInfo.CreateFromJSON(await DisplayProducts());
        row_name.text = pinfo.prod_name;
        row_desc.text = pinfo.prod_desc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static async Task<string> DisplayProducts()
    {
        Task<string> text1 = client.GetStringAsync("http://localhost/springvalley");
        string text2 = await text1;
        return text2.ToString();
    }
}
