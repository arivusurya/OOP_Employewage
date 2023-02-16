namespace EmployeWage{

    public class Switchcase{
       public  int employeehour = 0;
       public  int dailywage =0;
       public  int wageperhour =20;
        public   void dailwageSwitch(){
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

    }

}