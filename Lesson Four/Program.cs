using Lesson_Four;

Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 2, 5), new Point("C", 3, 4), new Point("D", 4, 4));

Console.Write($"{figure.Type}, P = ");

figure.PerimeterCalculator();