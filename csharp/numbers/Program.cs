// See https://aka.ms/new-console-template for more information
int start, end, steps;

do {
	Console.Write("from: ");
} while (!int.TryParse(Console.ReadLine(), out start));
do {
	Console.Write("to: ");
} while (!int.TryParse(Console.ReadLine(), out end));
do {
	Console.Write("steps: ");
} while (!int.TryParse(Console.ReadLine(), out steps));

for (int number = start; number <= end; number += steps) {
	Console.WriteLine(number);
}
