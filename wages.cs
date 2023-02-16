using System;

namespace EmployeWage {

    public class Wages{

            public  void dailywage(){
                int workperhour = 20 ;
                int workinghour = 8;
                int dailywage = workinghour * workperhour;
                Console.WriteLine(" daily wage is {0} ",dailywage );
            }

    }

}