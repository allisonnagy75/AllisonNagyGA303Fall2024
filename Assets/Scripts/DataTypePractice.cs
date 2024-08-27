using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePractice : MonoBehaviour
{

    //whole numbers
    public int num1; //int is 4 bytes - stores shorter #s (~2 billion)
    public int num2;

    public long num3; //long is 8 bytes - stores longer #s (~9 quintillion)

    public uint num4; //still 4 bytes - positive #s only - ~4.29 billion
    public ulong num5; //still 8 bytes - positive #s only - ~18.4 quintilllion

    //decimals
    public float num6 = 3.14f; //float is 4 bytes - decimals up to 6-7 digits - need an "f" at end of #
    public double num7 = 3.14159265; //double is 8 bytes - stores up to 15-16 digits

    //true or false
    public bool isProgrammingHard = true; //bool is 1 bit - only T or F aka 0 or 1

    //data sizes
    //8 bits = 1 byte
    //1024 bytes = 1 kilobyte
    //1024 kb = 1 megabyte
    //1024 mb = 1 gigabyte
    //1024 gb = 1 terabyte

    //300Mbps =/ 300 MBps - Mbps = megaBITS per second - MBps = megaBYTES per secondd
    //1 gigabit internet = download speed of 125 MB per second

    //text
    public char charizard = 'a';
    public char blastoise = 'b';
    public char venusaur = 'c';

    //already known data types WOAHHHH
    public Light light;
    public Transform transform;

    public string monsters = "Pokemon are so cool and " + //space - quote - space - plus sign
      "awesome yippee!";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The starting number for num1 is: " + num1);
        num1 = num1 + 1;
        Debug.Log("The end number for num1 after adding 1 is: " + num1);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(charizard);
    }
}
