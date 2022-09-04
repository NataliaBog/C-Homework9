Console.WriteLine();

            Console.WriteLine("Введите натуральное число M:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int task64_start);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task64_start);
            }

            // считано число M

            Console.WriteLine("Введите натуральное число N:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task64_end);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task64_end);
            }

            // считано число N


            if (task64_end < task64_start)
                for (int i = task64_start; i >= task64_end; i--)
                {
                    {
                        if (i < task64_start) Console.Write(", ");
                        Console.Write(i);
                    }
                }
            else
                for (int i = task64_start; i <= task64_end; i++)
                {
                    {
                        if (i > task64_start) Console.Write(", ");
                        Console.Write(i);
                    }
                }

            Console.WriteLine("\n");