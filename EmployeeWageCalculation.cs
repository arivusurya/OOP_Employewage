using System;

namespace EmployeWage{

    public class EmployeWage {


          public  void monthlywagecalculation(){
         int number_ofWorking_days=20;
            int employeehour = 0;
            int wageperhour = 20 ;
            int totalemployeewage =0; 
           for(int day =0 ;day <number_ofWorking_days;day++){
            Random random = new Random();
           int number = random.Next(3);
           switch (number)
           {
            case 0:
                employeehour =8;
                break;
            case 1:
                employeehour =4;
                break;
            case 2:
                employeehour =0;
                break;
            
           }

            int dailywageofworker = employeehour * wageperhour;
            totalemployeewage +=dailywageofworker;
            Console.WriteLine("The daily wage is {0}",dailywageofworker);
           }
           Console.WriteLine("Total employee wage for a month is "+totalemployeewage);
        }

        
        public void parttimewagecalculation(){
             int workperhour = 20 ;
                int workinghour = 0;
                 Random random =  new Random();
                int number = random.Next(0,3);
                if (number == 0){
                    workinghour = 8;
                }else if( number == 1 ){
                    workinghour = 4;
                }else{
                    workinghour = 0;
                }
                int dailywage = workinghour * workperhour;
                Console.WriteLine("dailywages is  {0}",dailywage); 
        }
                public   void dailwageSwitch(){
                int employeehour = 0;
                int dailywage =0;
                int wageperhour =20;
                Random random = new Random();

            int number = random.Next(3);

            switch (number)
           {
            case 0:
                employeehour =8;
                break;
            case 1:
                employeehour =4;
                break;
            case 2:
                employeehour =0;
                break;
            
           }
            dailywage = employeehour * wageperhour ;

        
           Console.WriteLine("Daily wage of employee is {0}",dailywage);
        
        } 
          public  void dailywage(){
                int workperhour = 20 ;
                int workinghour = 8;
                int dailywage = workinghour * workperhour;
                Console.WriteLine(" daily wage is {0} ",dailywage );
            }
             public  void conditionalwagecalculation(){
            
            int employeehour = 0;
            int wageperhour = 20 ;
            int totalemployeewage =0; 
            int totalemphour =0 ;
            int maxworkinghour=100;
            int totalworkingday=0;
            int max_workingday=20;
       while (totalemphour <=maxworkinghour && totalworkingday < max_workingday)
       {
        
            totalworkingday++;
            Random random = new Random();
           int number = random.Next(3);
           switch (number)
           {
            case 0:
                employeehour =8;
                break;
            case 1:
                employeehour =4;
                break;
            case 2:
                employeehour =0;
                break;
            
           }
            totalemphour +=employeehour;
            int dailywageofworker = employeehour * wageperhour;
            totalemployeewage +=dailywageofworker;
            
            Console.WriteLine("The daily wage is {0}",dailywageofworker);
           }
           Console.WriteLine(totalemphour);
           Console.WriteLine(totalworkingday);
           Console.WriteLine("total employe wage : "+totalemployeewage);
        }




    }


}