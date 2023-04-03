class Program {
   
  
    static float InputText(float preVal, string mode){
        Console.Write("Input number or End to finished: ");
        string InputValue = (Console.ReadLine());

        mode = "";
        float output = 0.0f;
        float number = 0;
            if (InputValue != "End"){
                number = float.Parse(InputValue);

                float nextNumber = InputText(number,mode);
                
                Console.WriteLine("Mode is: " + mode);

                    switch (mode){
                    case "FindMax":
                    Console.Write(preVal + " ," + number);
                    
                    if (number <= preVal){
                        output = number;
                    }
                    break;
                    case "FindMin":
                    if (number >= nextNumber){
                        output = number;
                    }
                    break;
                    case "FindMean":
                    output = number + preVal/2;
                    break;
                    
                    }           
                }
            
            
            if (InputValue == "End" ){
                Console.Write(preVal + " ,");

                Console.WriteLine(number);
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

    static void Main(string[] args){
        float output = InputText(0,"");
        Console.WriteLine(output);
    }
}