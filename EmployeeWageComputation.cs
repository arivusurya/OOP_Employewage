using System;

namespace EmployeWageContainer{

    public class EmployeWageComputation{
        public int wageperhour ;
        public int maxDay ;
        public int maxworkinghour;
        public EmployeWageComputation(int wageperhour,int maxDay,int maxworkinghour){
            this.wageperhour=wageperhour;
            this.maxDay=maxDay;
            this.maxworkinghour=maxworkinghour;
        }

        public void MonthlyWageCondition(){
            int employeehour = 0;
            int totalemphour =0;
            int totalworkingday =0;
            int monthlywage =0;
            while(totalemphour <= maxworkinghour && totalworkingday < maxDay ){
                totalworkingday++;
                Random random = new Random();
                int number = random.Next(3);

                switch (number)
           {
            case 0:
                employeehour = 8;
                break;
            case 1:
                employeehour =4;
                break;
            case 2:
                employeehour =0;
                break;
            
           }
           totalemphour +=employeehour;
           int dailywage = employeehour * wageperhour;
           monthlywage +=dailywage;

            
            }
            Console.WriteLine("Monthy wage {0}",monthlywage);


        }

    }


}