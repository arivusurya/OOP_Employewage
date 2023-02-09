namespace EmployeWage {

    public class dailywage{

        public static void wagecalculation(){
            int employeehour = 0;
            int wageperhour = 20 ;
            Random random = new Random();
            int empcheck = random.Next(3);
            if (empcheck == 0 ){
                employeehour = 8;
            }else if(empcheck == 1){
                employeehour =4;
            }else{
                employeehour =0;
            }

            int dailywageofworker = employeehour * wageperhour;

            Console.WriteLine("The daily wage is {0}",dailywageofworker);
        }

    }



}