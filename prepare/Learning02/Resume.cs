using System;
using System.Collections;
using System.Text; 


public class Resume
{
    public string _userName;
    public List<Job> _jobList = new List<Job>(); //Esta es la forma de crear y llamar una lista. Creo una lista para agregar toda la info en Job. 
    //Estoy llamando la clase Job en una lista y esta tiene int y string.s

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_userName} \n Jobs:  ");
//el tipo de data en Job aca es job. Esta es la forma de llamar a Job class en cada job. 
        foreach (Job job in _jobList)
        {
            job.DisplayInfo();
            
        }
    }
}