// Calcular area de un rectangulo

// largo
int largo;
Console.WriteLine("Porfavor ingrese el largo del rectangulo");
largo = int.Parse(Console.ReadLine());

// Ancho
int ancho;
Console.WriteLine("Porfavor ingrese el ancho del rectangulo");
ancho = int.Parse(Console.ReadLine());

// Area
double area; 
area = (largo * ancho);
Console.Write("El area del rectangulo es ");
Console.Write(area);