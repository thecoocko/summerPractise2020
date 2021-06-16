#include <iostream> 
#include <cstdlib>
#include<ctime>
void fillArray(int* a, int N);
void printArray(int* a, int N);
void selectionSort(int* a, int N);
int main() {
	srand(time(NULL));
	int const N = 10;
	int arr[N];
	fillArray(arr, N);
	printArray(arr, N);
	selectionSort(arr, N);
	printArray(arr, N);
	system("pause");
	return 0;
}
void fillArray(int* a, int N) {
	for (int i = 0; i < N; i++) {
		a[i] =1+rand()%10-6 ;
	}
}
void selectionSort(int* a, int N) {
	for (int i = 1; i < N-1; i++) {
		int small = i;
		for (int j = i + 1; j < N; j++) {
			if (a[j] < a[small]) {
				small = j;
				std::cout << a[j] << " ";
			}
		}
		
	}
	std::cout << "\n";
}
void printArray(int* a, int N) {
	std::cout << "Our array is: ";
	for (int i = 0; i < N; i++) {
		std::cout << a[i] << " ";
	}
	std::cout << "\n";
}
