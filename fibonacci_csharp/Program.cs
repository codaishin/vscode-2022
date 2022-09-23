// See https://aka.ms/new-console-template for more information
int fst = 0;
int snd = 1;

int from;
int to;

Console.Write("from: ");
from = Convert.ToInt32(Console.ReadLine());
Console.Write("to: ");
to = Convert.ToInt32(Console.ReadLine());

while (snd <= to) {
	if (snd >= from) {
		Console.WriteLine(snd);
	}
	int tmp = fst + snd;
	fst = snd;
	snd = tmp;
}
