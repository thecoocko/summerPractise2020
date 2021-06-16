#include<iostream>
#include<fstream>
#include<vector>
#include<cmath>
#include<ctime>
#include <string>
int main() {
	setlocale(LC_ALL,"RU");
	srand(time(NULL));
	int n,k,
		sum = 0,
		product = 1,
		sumOfSquares=0;
	std::string filename;
	std::vector<int>numbers;
	std::cout << "Укажите имя файла(например file.txt): "; std::getline(std::cin,filename);
	std::cout << "Введите количество цифр:"; std::cin >> k;
	std::ofstream ofs(filename);
	for (int i = 0; i < k; i++)
	{
		int newfile = 1 + rand() % 10 - 6;
		ofs << newfile;
	}
	ofs.close();
	std::ifstream ifs(filename);
	if (!ifs.is_open()) { std::cout << "The file "<<filename <<" didn't open\n"; }
	else {
		while (ifs >> n) {
			numbers.push_back(n);
		}
		if (numbers.empty()) { std::cout << "File is empty"; }
		else {
			std::cout << "Output of the program:\n";
			for (int i = 0; i < numbers.size(); i++) {
				std::cout << numbers[i] << " ";
			}
			std::cout << "\na)The sum of numbers:\t ";
			for (int i = 0; i < numbers.size(); i++) {
				sum += numbers[i];
			}
			std::cout << sum << " ";
			std::cout << "\nb)The product of the numbers:\t ";
			for (int i = 0; i < numbers.size(); i++) {
				product *= numbers[i];
			}
			std::cout << product << " ";
			std::cout << "\nc)The sum of squares of the numbers:\t ";
			for (int i = 0; i < numbers.size(); i++) {
				sumOfSquares += pow(numbers[i],2);
			}
			std::cout << sumOfSquares << " ";
			std::cout << "\nd)The module of the sum and product square:\t ";
			std::cout <<"|" <<abs(sum) <<"|"<< "  product^2 = "<< pow(product,2);
			std::cout << "\nd)The last element of the file:\t ";
			int n=numbers.back();
			std::cout << n<<"\n";
		}
	}
	ifs.close();
	system("pause");
	return 0; }
