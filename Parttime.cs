using System ;

namespace EmployeWage {

    public class DailyPartime {

        public void wagecalculation(){
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

    } 

}