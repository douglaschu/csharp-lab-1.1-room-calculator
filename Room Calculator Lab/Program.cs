Console.WriteLine("Please enter the length of the room.");
float length = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room.");
float width = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter the ceiling height of the room. Standard height is 10.");
float height = float.Parse(Console.ReadLine());
float area = length * width;
float perimeter = (2 * length) + (2 * width);
float volume = length * width * height;
float surfaceArea = ((2 * area) + 2 * (width * height) + 2 * (length * height));

Console.WriteLine($"The room's area is {area}.");
Console.WriteLine($"The room's perimeter is {perimeter}.");
Console.WriteLine($"The room's volume is {volume}.");
Console.WriteLine($"The room's surface area is {surfaceArea}.");

if (area <= 250)
{
    string roomSize = "small";
    Console.WriteLine($"The room is {roomSize}.");
}
else if (area > 250 && area < 650) {
    string roomSize = "medium";
    Console.WriteLine($"The room is {roomSize}.");
} else {
    string roomSize = "large";
    Console.WriteLine($"The room is {roomSize}.");
}

Console.ReadLine();
