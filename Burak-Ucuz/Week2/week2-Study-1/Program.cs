using System;

namespace Week2_Study_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Bir kelime grubundan rastgele bir kelime seç. (ayna)
             * 2. Seçtiğin bu kelimenin her harfini * işaretine dönüştür
             * 3. Bu bulmacayı ekranda göster. (****)
             * 4. Oyuncudan harf iste 
             * 5. Harf kelimede var mı kontrol et.
             * 6. a. Eğer varsa, o harfin bulunduğu * işaretlerini harfe çevir (Örnek a**a)
             *    b. Yoksa bir hakkını azalt
             * 7. Oyuncudan kelimeyi tahmin etmesini iste
             *    Bilirse oyunu bitir
             *    Bilemezse 3. adıma dön
             */

            bool isGameOver = false;
            
            string[] words = { "ayna", "masa", "tarantula", "endoplazmikretikulum" };
            while (!isGameOver)
            {

                string selectedWord = chooseWord(words);
                int guessLetterCount = selectedWord.Length/2+1, guessWordCount = 3; //Guessing word and letter counts
                string puzzle = replaceToStar(selectedWord);
                Console.WriteLine($"Çözmeniz gereken" +
                    $" kelime {selectedWord.Length} harften oluşuyor. Harf Hakkınız: {guessLetterCount}, Kelime Hakkınız: {guessWordCount}\n" +
                    $"\n--------------\n");
                Console.WriteLine(puzzle);
                bool isWordFinding = false;
                while (!isWordFinding)
                {
                    Console.WriteLine("Bir harf giriniz");
                    string letter = Console.ReadLine();
                    bool isLetterExistInWord = checkLetterInWord(selectedWord, letter, ref guessLetterCount);
                    if (isLetterExistInWord)
                    {
                        puzzle = replaceStarToLetter(selectedWord, puzzle, letter);
                        Console.WriteLine(puzzle);
                    }
                    else if(guessLetterCount==0)    //if count is 0, game is over.
                    {
                        Console.WriteLine("Harf bulunamadı, deneme hakkınız kalmamıştır.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Harf bulunamadı. Kalan hakkınız :  {guessLetterCount}");
                    }

                    Console.WriteLine("Kelimeyi tahmin etmek ister misin? (E/H)");
                    string answerForGuess = Console.ReadLine();
                    if (answerForGuess.ToUpper() == "E")
                    {
                        Console.WriteLine("Tahmininizi giriniz:");
                        string guess = Console.ReadLine();
                        isWordFinding = CompareGuessAndSelectedWord(guess, selectedWord,ref guessWordCount);
                        if (isWordFinding)
                        {
                            Console.WriteLine("Tebrikler. Doğru bildiniz!");
                            break;
                        }
                        else if(guessWordCount == 0) //If count is 0, game is over.
                        {
                            Console.WriteLine("Yanlış kelime! Deneme hakkınız kalmamıştır.");
                            break;
                        }
                        else
                            Console.WriteLine($"Yanlış Kelime. Kalan kelime deneme hakkınız : {guessWordCount}");

                    }
                }
                Console.WriteLine(puzzle);
                Console.WriteLine("Oyuna devam mı (E/H)?");
                isGameOver = Console.ReadLine().ToUpper() == "H";
            }
        }

        private static bool CompareGuessAndSelectedWord(string guess, string selectedWord, ref int guessWordCount)//If its not equal, count down guessWordCount.
        {
            if(guess == selectedWord)
            {
                Console.WriteLine($"Tebrikler. Doğru tahmin ettiğiniz kelime : {guess}");
                return true;
            }
            else
            {
                guessWordCount--;
                return false;
            }
        }


        /// <summary>
        /// Belirli kelimelerin içinden rastgele kelime seçer
        /// </summary>
        /// <param name="words">kelimelerin bulunduğu koleksiyon</param>
        /// <returns></returns>
        static string chooseWord(string[] words)
        {
            Random random = new Random();
            string word = words[random.Next(0, words.Length)];
            return word;
        }

        private static string replaceToStar(string selectedWord)
        {
            string puzzleResult = string.Empty;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                puzzleResult += "*";
            }
            return puzzleResult;
        }

        /// <summary>
        /// Bu metod ile bir kelimede bir harf olup olmadığını bulursunuz.
        /// Kelimede harf yok ise, tahmin sayısı bir azaltılır.
        /// </summary>
        /// <param name="selectedWord">Kaynak kelime</param>
        /// <param name="letter">Aranacak harf</param>
        /// <returns></returns>
        private static bool checkLetterInWord(string selectedWord, string letter, ref int guessLetterCount)
        {
            if (selectedWord.Contains(letter))
                return true;
            else
            {
                guessLetterCount--;
                return false;
            }
        }

        private static string replaceStarToLetter(string selectedWord, string puzzle, string letter)
        {
            int startIndex = 0;
            char[] puzzleStars = puzzle.ToCharArray();
            while (selectedWord.IndexOf(letter, startIndex) != -1)
            {
                int findingIndex = selectedWord.IndexOf(letter, startIndex);
                puzzleStars[findingIndex] = Convert.ToChar(letter);
                startIndex = findingIndex + 1;

            }

            string result = string.Empty;
            foreach (var item in puzzleStars)
            {
                result += item.ToString();
            }

            return result;

        }
    }
}
