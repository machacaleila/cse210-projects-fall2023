using System;

class Program
{
    static void Main(string[] args)
    {
        //Esta es solo un trabajador vamos a usar la clase en solo 1 trabajaodr
        Job job1 = new Job();//asi llamo la clase no tengo que agregar como el el programa 5. Aca solo tipear dos veces el titulo
        job1._jobTitle = "Software Engineer";
        job1.DisplayInfo();//Asi imprimo, llamando a Display junto con en este caso la perosna job1
    }
}