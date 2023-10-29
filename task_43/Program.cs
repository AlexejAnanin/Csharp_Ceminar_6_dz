// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] DataInput(){
    Console.WriteLine("Введите произвольные коэффициенты уравнений прямых b1, k1, b2, k2 в заданном формате:");
    double[] coord = Array.ConvertAll(Console.ReadLine()!.Split(", "), double.Parse);

    return coord;
}

void WriteEquations(double[] coord){
    string sign = "+", sign2 = "+";
    if (coord[0] < 0)
    {
        coord[0] = -coord[0];
        sign = "-";
    }
     if (coord[2] < 0)
    {
        coord[2] = -coord[2];
        sign2 = "-";
    }
    Console.WriteLine($"Уравнения: y = {coord[1]}x {sign} {coord[0]}; y = {coord[3]}x {sign2} {coord[2]}");
}

void Calculations(double[] coord, out double x, out double y){

     x = Math.Round((coord[2] - coord[0]) / (coord[1] - coord[3]), 1);
     y = Math.Round((coord[1]*x + coord[0]), 1);
}

double x = 0, y = 0;
double[] coord = DataInput();
WriteEquations(coord);
Calculations(coord, out x, out y);
Console.WriteLine($"Точка пересечения ({x}; {y})");
