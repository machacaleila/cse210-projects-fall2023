using System;

class Program
{
    static void Main(string[] args)
    {
        //Esta es solo un trabajador vamos a usar la clase en solo 1 trabajaodr
        Job job1 = new Job();//asi llamo la clase no tengo que agregar como el el programa 5. Aca solo tipear dos veces el titulo
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //job1.DisplayInfo();//Asi imprimo, llamando a Display junto con en este caso la perosna job1

        Job job2 = new Job();
        job2._jobTitle ="Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //job2.DisplayInfo();

        //crear una nueva instance of the resume class.
        Resume myResume = new Resume();
        //myResume._job[0]._jobTitle; Agrego los elementos a la lista creada en resume
        //pero como ya imprimir en resume class, hacer funcionar job en cada job de la lista que cree que ahora va a estar llena. 
        myResume._userName = "Alison Rose";

        myResume._jobList.Add(job1);//Ahora en vez de agregar a la lista cada uno, solo agrego directamente la persona ejemplo, job1 es una persona. 
        //ingreso todo lo que se creo con esa persona en especie de lista creada en resume. 
        myResume._jobList.Add(job2);

        myResume.DisplayResume();
        
        //Ahora porque hice un nuevo display en resume no tengo que imprimir en cada job. Hago uno solo. 




    }
}