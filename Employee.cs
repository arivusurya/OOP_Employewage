namespace EmployeWage{

    public class EmployeeCheck{


        public  void checkemplyee(){
          Random random = new Random();
          int number = random.Next(2);
         if(number == 1){
            Console.WriteLine("employe is present");
         }else {
            Console.WriteLine("employee is absent");
         }
        }
    }


}