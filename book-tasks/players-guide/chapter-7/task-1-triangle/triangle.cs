
string triangleHeight;
string triangleBaseLength;

Console.WriteLine("Enter the height of your flat triangle (meters): ");

triangleHeight = Console.ReadLine();
if (double.TryParse(triangleHeight, out double parsedTriangleHeight)){}
else{Console.WriteLine("Invalid input."); return;}


Console.WriteLine("\nEnter the base length of your flat triangle (meters): ");

triangleBaseLength = Console.ReadLine();
if (double.TryParse(triangleBaseLength, out double parsedTriangleBaseLength)){}
else{Console.WriteLine("Invalid input."); return;}


double triangleSurfaceArea = (parsedTriangleHeight * parsedTriangleBaseLength) / 2;
Console.WriteLine("\nThe surface area of this triangle is " + triangleSurfaceArea + "(m²).");

