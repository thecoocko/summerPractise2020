#include<iostream>
#include <iomanip>
#include<cmath>
#define M_PI 3.14159265358979323846
#define M_PI_4 0.785398163397448309616
#define M_2_PI_3 2.09439510239
#define M_PI_3 1.0471975512
void someFunctions(int choise);
double algebraicRational(double x);
double algebraicIrrational(double x);
double trigonometric(double x);
double exponential(double x);
double hyperbolic(double x);
double naturalLogarithms(double x);
double trigonometricHyperbolic(double x);
int main() {
    int choice=10;
    setlocale(LC_ALL, "RU");
    std::cout << std::cout.width(35) << "ТАБУЛИРОВАНИЕ ФУНКЦИИ НА ОТРЕЗКЕ [0;3] С ШАГОМ h = 0,1\n";
    while (choise) {
        std::cout << "Введите от 1 до 7, чтобы отобразить табуляцию нужной функции."
            <<" Нажмите любую другую клавишу для выхода: "; std::cin >> choise;
        someFunctions(choise);
    }
    system("pause");
    return 0;    
}
double algebraicRational(double x) {
    return pow(x, 3) / (1 + x);
}
double algebraicIrrational(double x) {
    return 1 / (x * sqrt(1 + x));
}
double trigonometric(double x) {
    return(1 - sin(x)) / x;
}
double exponential(double x) {
    return exp(-(1 - x));
}
double hyperbolic(double x) {
    return 1 / (pow(sinh(x),2));
}
double naturalLogarithms(double x) {
    return 1 / (x * log((1 + x) / x));
}
double trigonometricHyperbolic(double x) {
    return sinh(sin(x));
}
void someFunctions(int choice) {
    switch (choice) {
    case 1:
    {std::cout << "Алгебраическая функция: \n";
    double x = .0,
        const h = 0.1;
    std::cout << "\tx\t\ty\n";
    for (double i = 0; i <= 3; i = i + h) {
        double y = algebraicRational(x);
        std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
        x = x + 0.1;
    }break;
    }
    case 2: {
        std::cout << "Алгебраическая иррациональная функция: \n";
        double x = .0,
            const h = 0.1;
        std::cout << "\tx\t\ty\n";
        for (double i = 0; i <= 3; i = i + h) {
            double y = algebraicIrrational(x + h);
            std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
            x = x + 0.1;
        }
        break;
    }
    case 3:
    {std::cout << "Тригонометрическая: \n";
    double x = .0,
        const h = 0.1;
    std::cout << "\tx\t\ty\n";
    if (x == 0) {
        x = x + h;
    }    
    for (double i = 0; i <= 3; i = i + h) {
        double y = trigonometric(x);
        std::cout << std::setw(7)<<"|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
        x = x + 0.1;
    }
    double y1= trigonometric(M_PI_3);
    double y2 = trigonometric(M_PI_4); 
    double y3 = trigonometric(M_2_PI_3); 
    double y4 = trigonometric(M_PI);
    std::cout << "\nM_PI_3"<<"\tM_PI_4"<<"\tM_2_PI_3"<<" M_PI\n";
    std::cout << "|"<< std::setw(3)  << y1 << std::setw(3) << " | "  <<y2 << std::setw(3) << " | "<<y3 << std::setw(7) << " | "<<y4 << "|" << std::endl; break;
    }
    case 4:
    {std::cout << "Экспоненциальная функция: \n";
    double x = .0,
        const h = 0.1;
    if (x == 0) {
        x = x + h;
    }
    std::cout << "\tx\t\ty\n";
    for (double i = 0; i <= 3; i = i + h) {
        double y = exponential(x);
        std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
        x = x + 0.1;
    }break;
    }
    case 5:
    {
    std::cout << "Гиперболическая функция: \n";
        double x = .0,
            const h = 0.1;
        if (x == 0) {
            x = x + h;
        }
        std::cout << "\tx\t\ty\n";
        for (double i = 0; i <= 3; i = i + h) {
            double y = hyperbolic(x);
            std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
            x = x + 0.1;
        }
        double y1 = hyperbolic(M_PI_3);
        double y2 = hyperbolic(M_PI_4);
        double y3 = hyperbolic(M_2_PI_3);
        double y4 = hyperbolic(M_PI);
        std::cout << "\nM_PI_3" << "\tM_PI_4" << "\tM_2_PI_3" << " M_PI\n";
        std::cout << "|" << std::setw(3) << y1 << std::setw(3) << " | " << y2 << std::setw(3) << " | " << y3 << std::setw(7) << " | " << y4 << "|" << std::endl; break; break;
    }
    case 6:
    {
    std::cout << "Натуральная логарифмическая функция: \n"; 
        double x = .0,
            const h = 0.1;
        if (x == 0) {
            x = x + h;
        }
        std::cout << "\tx\t\ty\n";
        for (double i = 0; i <= 3; i = i + h) {
            double y = naturalLogarithms(x);
            std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
            x = x + 0.1;
        }break;
    }
    case 7:
    {std::cout << "Тригонометрическя гиперболическая функция: \n";
    double x = .0,
        const h = 0.1;
    std::cout << "\tx\t\ty\n";
    for (double i = 0; i <= 3; i = i + h) {
        double y = trigonometricHyperbolic(x);
        std::cout << std::setw(7) << "|" << x << std::setw(7) << "\t|\t" << std::fixed << y << std::cout.precision(2) << "|" << std::endl;
        x = x + 0.1;
    }
    double y1 = trigonometricHyperbolic(M_PI_3);
    double y2 = trigonometricHyperbolic(M_PI_4);
    double y3 = trigonometricHyperbolic(M_2_PI_3);
    double y4 = trigonometricHyperbolic(M_PI);
    std::cout << "\nM_PI_3" << "\tM_PI_4" << "\tM_2_PI_3" << " M_PI\n";
    std::cout << "|" << std::setw(3) << y1 << std::setw(3) << " | " << y2 << std::setw(3) << " | " << y3 << std::setw(7) << " | " << y4 << "|" << std::endl; break; break;
    }break;
    default:exit(0); break;
    }
}
