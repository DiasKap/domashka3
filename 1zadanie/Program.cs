Console.WriteLine("Введите число: ");  
            int number = int.Parse(Console.ReadLine());  
            int reverse = 0;
            int number2 = number;
            while(number2>0)  
            {  
                int reminder = number2 % 10;  
                reverse = (reverse * 10) + reminder;  
                number2 = number2 / 10;  
            }  
            if (number == reverse) {
                Console.WriteLine("Это палиндром");
            }
            else {
                Console.WriteLine("Не палиндром");
            }