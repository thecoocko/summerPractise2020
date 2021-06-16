#include <iostream>
#include<cmath>
#include<ctime>
#include<cstdlib>
void fillArray1D(int* a, int n);
void fillArray2D(int** a, int n);
void printArray1D(int* a, int n);
void printArray2D(int** a, int n);
int main() {
	int n,v=1,u=1,sumU=0,b=1;
	setlocale(LC_ALL, "RU");
	srand(time(NULL));
	std::cout << "Введите размер матрицы (n<=6): "; std::cin >> n;
	int *arx = new int[n];
	int* ary = new int[n];
	int** arr = new int* [n];
	for (int i = 0; i < n; i++) {
		arr[i] = new int[n];
	}
	if (n > 6) {std::cout << "Ошибка. Вводимое значение выходит за условие.\n";}
	else {
		fillArray1D(arx,n);
		fillArray1D(ary, n);
		fillArray2D(arr,n);
		std::cout << "Вектор х(....): ";
		printArray1D(arx, n);
		std::cout << "Вектор у(....): ";
		printArray1D(ary, n);
		std::cout << "Матрица А\n";
		printArray2D(arr, n);
		for (int k = 1; k < n; k++) {
			v += (*arr[k]) * ary[k];
		}
		std::cout << "Первое действие:(v)  " << v << std::endl;
		for (int i = 1; i < n; i++) {
			u += arx[i] * v;
		}
		std::cout << "Второе действие:(u) " << u << std::endl;
		int m = arx[0];
		for (int i = 0; i < n; i++) {
			if (arx[i] > m) {
				m = arx[i];
			}
		}
		std::cout << "Максимум в векторе х(...): " << m << std::endl;
		b = m * u;
		std::cout << "Биленейная форма: " << b << std::endl;
	}
	delete []arx;
	delete []ary;
	for (int i = 0; i < n; i++) {
		delete[] arr[i];
	}
	system("pause");
	return 0;
	
}
void fillArray1D(int* a,int n) {
	int chose;
	std::cout << "Для ввода вектора с клавиатуры нажмите 1. Для  заполнения случайными числами 2:  "; std::cin >> choice;
	while (choice) {
		switch (choice) {
		case 1: {
			for (int i = 0; i < n; i++) {
				std::cin >> a[i];
			}
			system("cls");
			break;
		}
		case 2: {
			for (int i = 0; i < n; i++) {
				a[i] = 1 + rand() % 10 - 6;
			}
			break; }
		default: {std::cout << "1 или 2, пожалуйста!\n"; }
		}
		break;
	}
}
void fillArray2D(int** a, int n) {
	int choice;
	std::cout << "Для ввода  матрицы с клавиатуры нажмите 1. Для  заполнения случайными числами 2:  "; std::cin >> chose;
	switch (choice) {
	case 1: {
		std::cout << "Введите элементы матрицы\n";
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				std::cin >> a[i][j];
			}
		}
		system("cls");
		break;
	}
	case 2: {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				a[i][j] = 1 + rand() % 10 - 6;
			}
		}
		break;
	}default: {std::cout << "1 или 2, пожалуйста!"; }
	}			
}
void printArray1D(int* a, int n) {
	std::cout << "(";
	for (int i = 0; i < n; i++) {
		std::cout << a[i] << " ";
	}
	std::cout << ")\n";
}
void printArray2D(int** a, int n) {

	for (int i = 0; i < n; i++){
		for (int j = 0; j < n; j++) {
			std::cout.width(2);
			std::cout << a[i][j] << " ";
		}
		std::cout << "\n";
	}
}
