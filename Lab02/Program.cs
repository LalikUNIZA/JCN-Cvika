using Lab02;

PersonDatabase personDatabase = new();
personDatabase.Add(PersonGenerator.Generate(20));
personDatabase.PrintToConsole();
