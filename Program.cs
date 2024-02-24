using Newtonsoft.Json;
using System;
using System.IO;

// <----------- ZADATAK 1 ----------->
//Console.WriteLine("Enter a number less than 10: ");
//EnterInput();
//int numInput;
//void EnterInput()
//{
//    int value;;
//    var input = Console.ReadLine();
//    if (int.TryParse(input, out value) && Convert.ToInt32(input) < 10)
//    {
//        numInput = Convert.ToInt32(input);
//    }
//    else if(int.TryParse(input, out value) && Convert.ToInt32(input) >= 10)
//    {
//        Console.WriteLine("Numbers must be less than 10, please enter a number: ");
//        EnterInput();
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please enter a number: ");
//        EnterInput();
//    }
//}

//List<List<int>> numbers = new List<List<int>>();

//for(int i = 0; i < numInput; i++)
//{
//    List<int> numbersToAdd = new List<int>();
//    List<int> numbersToAddDesc = new List<int>();
//    int maxNumber = i + 1;
//    for (int j = 0; j < maxNumber; j++)
//    {
//        numbersToAdd.Add(j + 1);
//    }
//    numbersToAddDesc = numbersToAdd.OrderByDescending(x => x).Where(x => x < maxNumber).ToList();
//    numbersToAdd.AddRange(numbersToAddDesc);
//    numbers.Add(numbersToAdd);
//}

//for (int i = numInput; i > 0; i--)
//{   
//    int space_number = i;
//    string spaces = "";

//    for(int j = 0; j < space_number; j++)
//    {
//        spaces += " ";
//    }

//    var numbersToPrint = string.Join("", numbers[numInput - i]);
//    Console.WriteLine(spaces + numbersToPrint);
//}


// <----------- ZADATAK 2 ----------->

//Console.WriteLine("Enter your number: ");
//int numInput;
//EnterInput2();
//long oddSum = 0;
//long evenSum = 0;
//void EnterInput2()
//{
//    int value; 
//    var input = Console.ReadLine();
//    if (int.TryParse(input, out value))
//    {
//        numInput = Convert.ToInt32(input);
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please enter a number: ");
//        EnterInput2();
//    }
//}

//List<long> inits = new List<long> { 0, 1 };

//for(int i = 2; i < numInput; i++)
//{
//    long newFibo = inits[i - 1] + inits[i - 2];
//    inits.Add(newFibo);
//}

//int count = inits.Count;
//bool isEven = false;

//if(count % 2 == 0)
//{
//    isEven = true;
//}

//Console.WriteLine("Sequence: ");
//foreach(var n in inits)
//{
//    Console.WriteLine(n);
//}

//if (isEven)
//{
//    for (int i = 0; i < count-1; i += 2)
//    {
//        evenSum += inits[i];
//    }
//    for(int i = 1; i < count; i+= 2)
//    {
//        oddSum += inits[i];
//    }
//}
//else
//{
//    for (int i = 0; i < count; i += 2)
//    {
//        evenSum += inits[i];
//    }
//    for (int i = 1; i < count - 1; i += 2)
//    {
//        oddSum += inits[i];
//    }
//}

//Console.WriteLine("\nSum of odd index numbers from the sequence: " + oddSum);
//Console.WriteLine("\nSum of even index numbers from the sequence: " + evenSum);


// <----------- ZADATAK 3 ----------->

//Console.WriteLine("\nEnter numbers x and y: ");

//Console.WriteLine("\nX: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("\nEnter the operator");
//var op = Console.ReadLine();
//Console.WriteLine();
//if (op != "Sve")
//{  
//    switch (op)
//    {
//        case "+":
//            int res = x + y;
//            Console.WriteLine("Result of addition is " + res);
//            break;
//        case "-":
//            res = x - y;
//            Console.WriteLine("Result of subtraction is " + res);
//            break;
//        case "*":
//            res = x * y;
//            Console.WriteLine("Result of multiplication is " + res);
//            break;
//        case "/":
//            if(y == 0)
//            {
//                Console.WriteLine("Division by zero impossible " + x + "/" + y);
//            }
//            else
//            {
//                Console.WriteLine("Result of division is " + x / y);
//            }
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Result of addition is " + (x+y));
//    Console.WriteLine("Result of subtraction is " + (x-y));
//    Console.WriteLine("Result of multiplication is " + (x*y));
//    if(y == 0)
//    {
//        Console.WriteLine("Division by zero impossible " + x + "/" + y);
//    }
//    else
//    {
//        Console.WriteLine("Result of division is " + (x / y));
//    }
//}

// <----------- ZADATAK 4 ----------->

//Console.WriteLine("\nIzgeneriran je nasumičan broj između 1 i 100, pokušaj ga pogoditi: ");
//Random random = new Random();
//int numToGuess = random.Next(1, 101);
//EnterInput4();
//void EnterInput4()
//{
//    int value; 
//    var input = Console.ReadLine();
//    if (int.TryParse(input, out value) && Convert.ToInt32(input) == numToGuess)
//    {
//        Console.WriteLine("Bravo, broj je pogođen");
//    }
//    else if (int.TryParse(input, out value) && Convert.ToInt32(input) > numToGuess)
//    {
//        Console.WriteLine("Previsoko, pokušaj ponovo");
//        EnterInput4();
//    }
//    else if(int.TryParse(input, out value) && Convert.ToInt32(input) < numToGuess)
//    {
//        Console.WriteLine("Prenisko, pokušaj ponovo");
//        EnterInput4();
//    }
//    else
//    {
//        Console.WriteLine("Broj pls: ");
//        EnterInput4();
//    }
//}

// <----------- ZADATAK 5 ----------->

//string? input = Console.ReadLine();

//if (!string.IsNullOrEmpty(input))
//{
//    string toPrint = "";
//    for (int i = input.Length-1; i >= 0; i--)
//    {
//        toPrint += input[i];
//    }
//    Console.WriteLine(toPrint);
//}


// <----------- ZADATAK 6 ----------->

//List<string> allWords = new List<string>();

//string? input = Console.ReadLine();

//string ParseUnwantedChars(string stringToParse)
//{
//    List<char> unwantedChars = new List<char> {
//            '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')',
//            '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ';', ':',
//            '\'', '"', ',', '<', '.', '>', '/', '?'
//        };
//    string toReturn = "";

//    for (int i = 0; i < stringToParse.Length; i++)
//    {
//        if (unwantedChars.Contains(stringToParse[i]))
//        {
//            toReturn += " ";
//        }
//        else 
//        {
//            toReturn += stringToParse[i];
//        }     
//    }

//    return toReturn;
//}

//string ParseWhiteSpace(string stringToParse)
//{
//    int lastIndex = stringToParse.Length - 1;
//    string toReturn = "";
//    for(int i = 0; i < stringToParse.Length-1; i++)
//    {
//        //Console.Write(stringToParse[i]);
//        if (stringToParse[i] != ' ')
//        {
//            toReturn += stringToParse[i];
//        }
//        else if (stringToParse[i] == ' ' && stringToParse[i+1] != ' ')
//        {
//            toReturn += stringToParse[i];
//        }
//    }
//    if (stringToParse[lastIndex] != ' ')
//    {
//        toReturn += stringToParse[lastIndex];
//    }

//    return toReturn;
//}

//void GetWords(string words)
//{
//    string newWord = "";
//    for(int i = 0; i < words.Length; i++)
//    {
//        if (newWord != "" && i == words.Length - 1)
//        {
//            allWords.Add(newWord + words[i]);
//        }
//        else if (words[i] != ' ')
//        {
//            newWord += words[i];
//        }   
//        else
//        {
//            allWords.Add(newWord);
//            newWord = "";
//        }
//    }
//}

//if (!string.IsNullOrEmpty(input))
//{
//    int min = Int32.MaxValue;
//    int max = 0;
//    string minString = "";
//    string maxString = "";
//    string parsedUnwantedChars = ParseUnwantedChars(input);
//    string parsedWhiteSpace = ParseWhiteSpace(parsedUnwantedChars);
//    GetWords(parsedWhiteSpace);
//    List<string> shortestWords = new List<string>();
//    List<string> longestWords = new List<string>();

//    foreach(var word in allWords)
//    {
//        if (word.Length > max)
//        {
//            max = word.Length;
//            maxString = word;
//        }
//    }

//    foreach (var word in allWords)
//    {
//        if (word.Length < min)
//        {
//            min = word.Length;
//            minString = word;
//        }
//    }

//    shortestWords.Add(minString);
//    longestWords.Add(maxString);

//    var filteredWords = allWords.Where(x => x != minString && x != maxString);

//    foreach(var word in filteredWords)
//    {
//        if(word.Length == minString.Length)
//        {
//            shortestWords.Add(word);
//        }
//        else if(word.Length == maxString.Length)
//        {
//            longestWords.Add(word);
//        }
//    }

//    if(shortestWords.Count > 1)
//    {
//        Console.WriteLine("\nNajkrace rijeci: ");
//        foreach(var word in shortestWords)
//        {
//            Console.WriteLine(word + "(" + word.Length + ")");
//        }
//    }
//    else
//    {
//        Console.Write("\nNajkraca rijec:");
//        Console.WriteLine("\n" + minString + " (" + minString.Length + ")");  
//    }

//    if(longestWords.Count > 1) 
//    {
//        Console.WriteLine("\nNajduze rijeci: ");
//        foreach (var word in longestWords)
//        {
//            Console.WriteLine(word + " (" + word.Length + ")");
//        }
//    }
//    else
//    {
//        Console.Write("\nNajduza rijec:");
//        Console.WriteLine("\n" + maxString + "(" + maxString.Length + ")");
//    }
//}

// <----------- ZADATAK 7 ----------->

//var input = Console.ReadLine();

//List<Char> vowels = new List<Char>()
//{
//    'a', 'e', 'i', 'o', 'u',
//    'A', 'E', 'I', 'O', 'U'
//};

//int count = 0;

//if (!String.IsNullOrEmpty(input))
//{
//    foreach(var c in input)
//    {
//        if (vowels.Contains(c))
//        {
//            count++;
//        }
//    }
//}

//Console.WriteLine("\nInput contains " + count + " vowels.");


// <----------- ZADATAK 8 ----------->
//string filePath = @"C:\Users\Korisnik\Desktop\myc#file.txt";

//try
//{
//    string path = Path.GetDirectoryName(filePath);
//    if (!Directory.Exists(path))
//    {
//        Directory.CreateDirectory(path);
//    }

//    using (StreamWriter writer = File.CreateText(filePath))
//    {
//        writer.WriteLine("My .txt file content");
//    }

//    Console.WriteLine(".txt file created!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}

//try
//{
//    Console.WriteLine("\nContent of .txt file: ");
//    using (StreamReader reader = File.OpenText(filePath))
//    {
//        string line;
//        while ((line = reader.ReadLine()) != null)
//        {
//            Console.WriteLine(line);
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}