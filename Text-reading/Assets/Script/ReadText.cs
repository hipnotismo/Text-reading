using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TMPro;

public class ReadText : MonoBehaviour
{
    [SerializeField] private TextAsset hello;
    [SerializeField] private TMP_Text m_MyText;

    void Start()
    {
        
        Debug.Log(hello);
        WriteFile();
        ReadFile();
    }

    // Update is called once per frame
    void Update()
    {        

        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = hello.text;
        }

    }

    static void WriteFile()
    {
        FileStream fs = File.OpenWrite("Assets/Script/Unity-write.txt");

        StreamWriter sw = new StreamWriter(fs);

        sw.WriteLine("Works");

        sw.Close();
        fs.Close();
    }

    static void ReadFile()
    {
        FileStream fs = File.OpenRead("Assets/Script/Unity-write.txt");

        StreamReader sr = new StreamReader(fs);

        string texto = sr.ReadLine();
        Debug.Log(texto);

        Console.WriteLine(texto);

        sr.Close();
        fs.Close();
    }
}
