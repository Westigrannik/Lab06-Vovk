// 1.1

// for (int i = 10; i >= 1; i--){
// Console.WriteLine(i);
// }

// 1.2 

// for (int i = 0; i <= 50; i+=2){
// Console.WriteLine(i);
// }

// 2

// int sum = 0;
// int count = 0;

// for (int i = 0; i <= 50; i++){
//  if (i%3==0){
//     sum+=3;
//  }
//  if (i%7==0){
//     count++;
//  }
//  }
//  Console.WriteLine(sum);
//  Console.WriteLine(count);

// 3

// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int countm = 0;
// int countp = 0;
// while (number != 0) {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number > 0){
//         countp++;
//     }
//     else if (number < 0){
//         countm--;
//     }
// }

// Console.WriteLine($"Сумма: {total}, {countp}, {countm}");

// 4

// string password;
// int count = 0;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     count++;
//     if (count > 2) break;
// } while (password != "qwerty");
// if (count > 2 ){
//     Console.WriteLine("Доступ запрещён");
// }
// else {
//     Console.WriteLine("Доступ разрешён");
// }

// 5

// Console.Write("Напишите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++){
//     Console.WriteLine($"{n} x {i} = {n*i}");
// }

//6

// for (int i = 1; i <=30; i++){
//     if (i%3==0) continue;
//     if (i%10==0 && i>20) break;
//     Console.WriteLine(i);
// };



// int count = 0;
// bool guess = false;
// Console.WriteLine("Угадайте чвисло от 1 до 50");
// while(!guess){
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n == 41) break;
//     int diff = 50 - n;
//     if (diff < 41) {
//         Console.WriteLine("Меньше");
//     };
//     if (diff > 41) {
//         Console.WriteLine("Больше");
//     };
//     if (count == 4) break;
//     count++;
// }
// if (count == 4 ) Console.WriteLine("Не угадали");
// else Console.WriteLine("Правильно! Число 41");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;
while (n>0){
     sum+=n%10;
     count++;
     n/=10;
}
Console.WriteLine(sum);
Console.WriteLine(count);