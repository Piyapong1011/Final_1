using System;

class Program{
    static void Main(string[]args){
        Console.Write("How many city : ");
        int number_of_cities = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------");
        int[] city_number = new int[number_of_cities];
        int[] covid_levels = new int[number_of_cities];
        string[] name_of_city = new string[number_of_cities];

        for (int i = 0; i < number_of_cities; i++){
            city_number[i] = i;
            covid_levels[i] = 0;
        }
        
        for (int i = 0; i < number_of_cities; i++){
            Console.Write("Name of cities {0} : ", city_number[i]);
            name_of_city[i] = Console.ReadLine();

            Console.Write("How many of nearby cities : ");
            int number_of_nearby_cities = int.Parse(Console.ReadLine());
            int[] nearby_city = new int[number_of_nearby_cities];

            for (int j = 0; j < number_of_nearby_cities; j++){
                Console.Write("City nearby : ");
                nearby_city[j] = int.Parse(Console.ReadLine());

                if (nearby_city[j] > number_of_cities || nearby_city[j] == city_number[i]){
                    Console.WriteLine("Invalid ID");
                    j = j - 1;
                }else{
                    if (j > 0){
                        for (int k = 0; k < number_of_nearby_cities; k++){
                            if (k != j && nearby_city[k] == nearby_city[j]){
                                Console.WriteLine("Invalid ID");
                                j = j - 1;
                                break;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("------------------------------");    
        for (int i = 0; i < number_of_cities; i++){
            Console.WriteLine("{0} {1} {2}", city_number[i], name_of_city[i], covid_levels[i]);
        }
        Console.WriteLine("------------------------------");

        bool end = true;

        do{
            Console.Write("Situation : ");
            string situation = Console.ReadLine();
            switch(situation){
                case "Outbreak" :
                    Console.Write("At city : ");
                    int num1 = int.Parse(Console.ReadLine());
                    covid_levels[num1] = covid_levels[num1]+2;

                break;

                case "Vaccinate" :
                    Console.Write("At city : ");
                    int num2 = int.Parse(Console.ReadLine());
                    covid_levels[num2] = 0;
                break;

                case "Lockdown" :
                    Console.Write("At city : ");
                    int num3 = int.Parse(Console.ReadLine());
                    covid_levels[num3] = covid_levels[num3]-1;
                break;

                case "Spread" :
                    Console.Write("At city : ");
                    int num4 = int.Parse(Console.ReadLine());
                    covid_levels[num4] = covid_levels[num4]+1;
                break;

                case "Exit" :
                    end = false;
                break;

                default :
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.WriteLine("------------------------------");    
            for (int i = 0; i < number_of_cities; i++){
                Console.WriteLine("{0} {1} {2}", city_number[i], name_of_city[i], covid_levels[i]);
            }
            Console.WriteLine("------------------------------");
        }while(end);

    }

    /*static void Comment(){
        NO GPT ONLY BRAIN 300%
    }*/

}
