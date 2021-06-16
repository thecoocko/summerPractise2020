#include<iostream>
#include<cstdlib>
#include<cmath>
#include<iomanip>
void sum(int n, double x);
int main() {
	setlocale(LC_ALL, "RU");
	float x;
	int n = 10;
	std::cout << "Практическое задание №1.\n\nДиапазон изменений аргумента x є [0.1;1], n = 10, e = 0.001\n";
	std::cout << "\nВведите промежуточное значение: ";std::cin >> x;
	sum(n, x);
	system("pause");
	return 0;
}
void sum(int n, double x) {
	int count1 = 0, count2 = 0, count3 = 0;
	double sum1 = 1, sum2 = 1,sum3 = 1, 
		a1 = 1, a2 = 1,a3 = 1,last = 1,
		func1 = 1, func2 = 1, func3 = 1, deviation1,
		deviation2 , deviation3;
	double const e = 0.001, first = 0.1;
	func1 = pow(3, first);
		func2 = pow(3, x);
		func3 = pow(3, last);
	if (x > 1 || x< 0.1) {
		std::cout << "\nВЫХОД ЗА ГРАНИЦУ\n";
	}
	else {
		std::cout << "\nТаблица зависимости кол-ва аргументов от суммы для x = 0.1\n";
		for (int i = 1; abs(a1 *= (first * log(3)) / i) >= e; i++) {
			sum1 += a1;
			deviation1 = func1 - sum1;
			
				std::cout << "\nФункция: " << "\t" << func1
				<< "\nСумма: " << "\t\t" << sum1
				<< "\nКоличество: " << "\t" << count1 
				<< "\nОтклонение: " << "\t" << deviation1
				<< std::endl;
			count1++;
		}
		std::cout << "\nТаблица зависимости кол-ва аргументов от суммы для x = " << x << "\n";
		for (int i = 1; abs(a2 *= (x * log(3)) / i) >= e; i++) {
			sum2 += a2;
			deviation2 = func2 - sum2;			
			std::cout << "\nФункция: " << "\t" << func2
				<< "\nСумма: " << "\t\t" << sum2
				<< "\nКоличество: " << "\t" << count2
				<< "\nОтклонение: " << "\t" << deviation2
				<< std::endl;
			count2++;
		}
		std::cout << "\nТаблица зависимости кол-ва аргументов от суммы для x = 1\n";
		for (int i = 1; abs(a3 *= (last * log(3)) / i) >= e; i++) {
			sum3 += a3;
			deviation3 = func3 - sum3;
			
			std::cout << "\nФункция: " << "\t" << func3
				<< "\nСумма: " << "\t\t" << sum3
				<< "\nКоличество: " << "\t" << count3
				<< "\nОтклонение: " << "\t" << deviation3
				<< std::endl;
			count3++;
		}		
		std::cout <<"\t\t\tx = 0.1\t\tx = " << x << "\t\tx = 1"
			<< "\nСумма: " << std::setw(23) << sum1 << std::setw(16) << sum2 << std::setw(17) << sum3
			<< "\nКоличество: " << std::setw(13) << count1 << std::setw(16) << count2 << std::setw(16) << count3
			<< "\nЗначение функции:" << std::setw(14) << func1<<std::setw(16) << func2 << std::setw(10) <<func3
			<< "\nОтклонение: " << std::setw(21) << deviation1 << std::setw(16) << deviation2 << std::setw(18) <<deviation3 << std::endl;
	}
}
