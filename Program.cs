class Program {
   
    static void Main(string[] args){
        string modeselect = "";

        static float InputText(float preVal,ref string mode){
            Console.Write("Input number or End to finished: ");
            string InputValue = (Console.ReadLine());

            float output = 0.0f;
            float number = 0;
                if (InputValue != "End"){
                    number = float.Parse(InputValue);


                    float nextNumber = InputText(number,ref mode);
                    
                    //Console.WriteLine("Mode is: " + mode);

                        switch (mode){
                        case "FindMax":
                        
                        if (number >= preVal){
                            output = number;
                        }
                        break;
                        case "FindMin":
                        if (number <= preVal){
                            output = number;
                        }
                        break;
                        case "FindMean":
                        output = number + preVal/2.0f;
                        break;
                        
                        }           
                    }
                
                
                if (InputValue == "End" ){
                    
                    bool selected = false;
                    while (!selected){
                        Console.WriteLine("Input mode [FindMax ,FindMin,FindMean] ");
                        Console.Write("Press here: ");
                        mode = (Console.ReadLine());

                        switch (mode){
                        case "FindMax":
                        selected = true;
                    
                        break;
                        case "FindMin":
                        selected = true;
                        
                        break;
                        case "FindMean":
                        selected = true;
                        break;
                        default:
                        Console.Write("Invalid mode");
                        break;
                        }            
                    }
                }
            
            return output;
        }
        Console.Write("Input number or End to finished: ");
        float preVal = float.Parse(Console.ReadLine());

        float output = InputText(preVal,ref modeselect);
        Console.WriteLine(output);
    }
 }
