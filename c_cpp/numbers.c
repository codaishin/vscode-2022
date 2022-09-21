#include <stdio.h>

int main() {
	int from, to, steps = 0;
	printf("from: ");
	scanf("%d", &from);
	printf("to: ");
	scanf("%d", &to);
	printf("steps: ");
	scanf("%d", &steps);

	for (int number = from; number <= to; number += steps) {
		printf("%i\n", number);
	}
	return 0;
}
