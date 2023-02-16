namespace EmployeWage {

    public class MonthlyWageCondition{
        public  int number_ofWorking_days=20;


        public  void wagecalculation(){
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