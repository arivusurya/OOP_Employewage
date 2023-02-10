namespace EmployeWage {

    public class dailywage{
        public const int number_ofWorking_days=20;


        public static void wagecalculation(){
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

    }
}