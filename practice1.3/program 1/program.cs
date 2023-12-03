namespace program_1;

public class program
{ 
    static void Main(string[] args) 
    { 
 
        string[] lines = File.ReadAllLines("input.txt");  
        string[] winningNumber = lines[0].Split(" "); // берем числа которые выбраны для выигрыша 
        List<string[]> ticketNumbers = new List<string[]>(); // список для хранения чисел 
        for (int i = 2; i < lines.Length; i++) 
        { 
            ticketNumbers.Add(lines[i].Split(" ")); 
        } 
         
        int WinningTicket = 0; 
        string outputFileName = "output.txt"; 
        using (StreamWriter writer = new StreamWriter(outputFileName)) 
        { 
            foreach (string[] ticketNumber in ticketNumbers) 
            { 
                WinningTicket = 0; 
                foreach (string number in ticketNumber) 
                { 
                    if (winningNumber.Contains(number)) 
                    { 
                        WinningTicket++; 
                    } 
                } 
                 
                if (WinningTicket >= 3) 
                { 
                    string output = "Lucky"; 
                    Console.WriteLine("Lucky"); 
                    writer.WriteLine(output); 
                } 
                else 
                { 
                    string output = "Unlucky"; 
                    Console.WriteLine("Unlucky"); 
                    writer.WriteLine(output); 
                } 
            } 
        } 
    } 
}