using Microsoft.VisualBasic.FileIO;

class ReadingCSV
{
    public static void Main()
    {
        var files = File.Create(@"C:\Users\student\Desktop\projects_ACCADEMY22\\pizza.csv");
       
        string colonna1;
        string colonna2;
        var path = @"C:\Users\student\source\repos\scontrino.csv";
        using (TextFieldParser csvReader = new TextFieldParser(path))
        {
            csvReader.CommentTokens = new string[] { "#" };
            csvReader.SetDelimiters(new string[] { "," });
            csvReader.HasFieldsEnclosedInQuotes = true;

            while (!csvReader.EndOfData)
            {
                
                string[] registro = csvReader.ReadFields();
                colonna1 = registro[0];
                colonna2 = registro[1];
            }
            var directoryInfo = Directory.GetFiles("C:\\Users\\student\\Desktop\\projects_ACCADEMY22\\pizza.csv");
            System.IO.File.WriteAllText(@"C:\Users\student\Desktop\projects_ACCADEMY22\\pizza.csv", ",");
            var counter = 1;
            foreach (var file in directoryInfo)
            {
                var orderedId = $"order {counter++}";
                var orderLines = File.ReadAllLines("C:\\Users\\student\\Desktop\\projects_ACCADEMY22\\pizza.csv");
                var dir = File.ReadAllLines(file);

                foreach (var line in orderLines)
                {
                    var pizzacomponents = line.Split(';');
                    var ritorno = pizzacomponents.Split(',');
                }
            }



        }
    }
}