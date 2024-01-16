// See https://aka.ms/new-console-template for more information

class ItogHW{

    static void Main(){
        Console.Clear();

        string[] mass = createMassive();
        Console.WriteLine("Исходный массив: ");
        writeToConsoleArray(mass);
        Console.WriteLine("Преобразованный массив: ");
    }


    static string[ ] createMassive(){
        Random rand = new Random();
        int endI = rand.Next(1, 10);

        string [ ] array = new string [endI];

        for(int i = 0; i < endI; i++){
            int randCountChars = rand.Next(0, 7);
            int count = 0;
            while (count < randCountChars){
                array[i] = array[i] + (char)rand.Next(0x0020, 0x007E);
                count++;
            }   
        }
        return array;
    }

    static void writeToConsoleArray(string [] array){
        foreach(string word in array)
            Console.WriteLine(word);

    }

    static string[ ] modifMassive(string [] array){
        int count = 0;
        foreach(string word in array){
             if (word.Length) 
                count++;
                
            if (count == 0){

            } 


           
        }        
    }

}
