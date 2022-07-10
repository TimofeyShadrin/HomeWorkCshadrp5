namespace Task
{
    class Methods
    {
        public int[] GetRandomArrayInt(byte minSize, byte maxSize, int minValue, int maxValue)
        {
            int[] array = new int[0];
            int sizeOfArray = new Random().Next(minSize, maxSize);
            Array.Resize(ref array, sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = new Random().Next(minValue, maxValue);
            }
            return array;
        }

        public double[] GetRandomArrayDouble(byte minSize, byte maxSize, int minValue, int maxValue)
        {
            double[] array = new double[0];
            int sizeOfArray = new Random().Next(minSize, maxSize);
            Array.Resize(ref array, sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                double temp = new Random().Next(minValue, maxValue);
                int digit = new Random().Next(minValue, maxValue);
                array[i] = digit + temp /1000;
            }
            return array;
        }

        public void PrintGotArray(int[] array)
        {
            int sizeOfArray = array.Length;
            if (sizeOfArray >= 3)
            {
                Console.Write($"[{array[0]},");
                for (int i = 1; i < sizeOfArray - 1; i++)
                {
                    Console.Write($" {array[i]},");
                }
                Console.WriteLine($" {array[sizeOfArray - 1]}]");
            }
            else if (sizeOfArray == 2)
            {
                Console.WriteLine($"[{array[0]}, {array[1]}]");
            }
            else if (sizeOfArray == 1)
            {
                Console.WriteLine($"[{array[0]}]");
            }
            else
            {
                Console.WriteLine("Sorry, but the pc didnt create an array.");
            }
        }

        public void PrintGotArray(double[] array)
        {
            int sizeOfArray = array.Length;
            if (sizeOfArray >= 3)
            {
                Console.Write($"[{Math.Round(array[0], 3)} ");
                for (int i = 1; i < sizeOfArray - 1; i++)
                {
                    Console.Write($" {Math.Round(array[i], 3)} ");
                }
                Console.WriteLine($" {Math.Round(array[sizeOfArray - 1], 3)}]");
            }
            else if (sizeOfArray == 2)
            {
                Console.WriteLine($"[{Math.Round(array[0], 3)} {Math.Round(array[1], 3)}]");
            }
            else if (sizeOfArray == 1)
            {
                Console.WriteLine($"[{Math.Round(array[0], 3)}]");
            }
            else
            {
                Console.WriteLine("Извините, но с пустым массивом не возможно провести требуемые операции!");
            }
        }

        public void PrintArrayDigit(char[,] matr, byte left, byte top)
        {
            Console.SetCursorPosition(14 +left * 7, top);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                Console.SetCursorPosition(14 + left * 7, top + i);
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public void PrintNumber (double number, byte top)
        {
            char[] array = number.ToString().ToCharArray();
            
            for (byte i = 0; i < array.Length; i++)
            {
                if (array[i] == '1') PrintArrayDigit(Digits.digit1, i, top);
                else if (array[i] == '2') PrintArrayDigit(Digits.digit2, i, top);
                else if (array[i] == '3') PrintArrayDigit(Digits.digit3, i, top);
                else if (array[i] == '4') PrintArrayDigit(Digits.digit4, i, top);
                else if (array[i] == '5') PrintArrayDigit(Digits.digit5, i, top);
                else if (array[i] == '6') PrintArrayDigit(Digits.digit6, i, top);
                else if (array[i] == '7') PrintArrayDigit(Digits.digit7, i, top);
                else if (array[i] == '8') PrintArrayDigit(Digits.digit8, i, top);
                else if (array[i] == '9') PrintArrayDigit(Digits.digit9, i, top);
                else if (array[i] == '0') PrintArrayDigit(Digits.digit0, i, top);
                else if (array[i] == '-') PrintArrayDigit(Digits.digitMinus, i, top);
                else if (array[i] == ',') PrintArrayDigit(Digits.digitComma, i, top);
            }
        }

        public void PrintNumber (int number, byte top)
        {
            char[] array = number.ToString().ToCharArray();
            
            for (byte i = 0; i < array.Length; i++)
            {
                if (array[i] == '1') PrintArrayDigit(Digits.digit1, i, top);
                else if (array[i] == '2') PrintArrayDigit(Digits.digit2, i, top);
                else if (array[i] == '3') PrintArrayDigit(Digits.digit3, i, top);
                else if (array[i] == '4') PrintArrayDigit(Digits.digit4, i, top);
                else if (array[i] == '5') PrintArrayDigit(Digits.digit5, i, top);
                else if (array[i] == '6') PrintArrayDigit(Digits.digit6, i, top);
                else if (array[i] == '7') PrintArrayDigit(Digits.digit7, i, top);
                else if (array[i] == '8') PrintArrayDigit(Digits.digit8, i, top);
                else if (array[i] == '9') PrintArrayDigit(Digits.digit9, i, top);
                else if (array[i] == '0') PrintArrayDigit(Digits.digit0, i, top);
                else if (array[i] == '-') PrintArrayDigit(Digits.digitMinus, i, top);
            }
        }
    }
}