using System;
using System.Collections;
using System.Text; 


public class Job 
{
    
    public string _jobTitle;//No agreagar comillas ni nada porque solo va a ser una caja vacia.Template
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
    }
   
}