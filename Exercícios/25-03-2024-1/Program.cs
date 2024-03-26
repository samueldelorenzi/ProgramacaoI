using _25_03_2024.Models;

// primeira clinica
Clinica c1 = new();
Clinica.InstanceCount = 1;
c1.ObjectCount = 1;

//segunda clinica
Clinica c2 = new();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine($"Valor C1: {c1.ObjectCount} Instance Count: {Clinica.InstanceCount}");
Console.WriteLine($"Valor C2: {c2.ObjectCount} Instance Count: {Clinica.InstanceCount}");