using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    public int size = 20;
    public int xmax = 200;
    public int ymax = 200;



   //  Coords point = new Coords(10, 20);

    Coords startPointXAxis  = new Coords(160, 0);
    Coords endPointXAxis = new Coords(-160, 0);



    Coords startPointYAxis = new Coords(0, 100);
    Coords endPointYAxis = new Coords(0, -100);



    Coords[] leo =
    {
        new Coords(0,20),
        new Coords(20,30),
        new Coords(80,30),
        new Coords(30,50),
        new Coords(80,50),
        new Coords(70,60),
        new Coords(70,80),
        new Coords(80,90),
        new Coords(95,80)
     };

    // Start is called before the first frame update
    void Start()
    {

        //Can show the coordinates of the points on the console
        //Debug.Log(point.ToString());



        //It creates a red point at the Center of screen
        //Coords.DrawPoint(new Coords(0, 0), 2, Color.red);


        //It creates a green point to coordinates which has given before 
        //Coords.DrawPoint(point, 2, Color.green);


        //It draws a line for y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 0.5f, Color.green);
        // It draws a line for x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 0.5f, Color.red);




        //Leo Constellation Coordinates
        //foreach (Coords c in leo)
        //{
        //    Coords.DrawPoint(c, 2, Color.yellow);

        //}

        //Coords.DrawLine(leo[0], leo[1], 0.4f, Color.white);
        //Coords.DrawLine(leo[1], leo[2], 0.4f, Color.white);
        //Coords.DrawLine(leo[0], leo[3], 0.4f, Color.white);
        //Coords.DrawLine(leo[3], leo[5], 0.4f, Color.white);
        //Coords.DrawLine(leo[2], leo[4], 0.4f, Color.white);
        //Coords.DrawLine(leo[4], leo[5], 0.4f, Color.white);
        //Coords.DrawLine(leo[5], leo[6], 0.4f, Color.white);
        //Coords.DrawLine(leo[6], leo[7], 0.4f, Color.white);
        //Coords.DrawLine(leo[7], leo[8], 0.4f, Color.white);

        int xoffset = (int)(160 / (float)size);


        // It creates white vertical lines in every 20 points 
        
        for (int x = -xoffset * size; x <= xoffset * size; x += size)
        {
            Coords.DrawLine(new Coords(x, -100), new Coords(x, 100), 0.5f, Color.white);

        }

        int yoffset = (int)(100 / (float)size);


        // It creates white horizontal lines in every 20 points 
        for (int y = -yoffset * size;  y <= yoffset * size; y+= size)
        {
            Coords.DrawLine(new Coords(-160, y), new Coords(160, y), 0.5f, Color.white);

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
