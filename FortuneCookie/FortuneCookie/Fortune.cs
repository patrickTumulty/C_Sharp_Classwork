using System;
using System.Collections.Generic;
using static System.Console;

namespace FortuneCookie
{
    public class Fortune
    {
        Random random = new Random();
        List<int> randomNum = new List<int>();
        string[] fortunes = 
        {
            "A faithful friend is a strong defense.",
            "A fresh start will put you on your way.",
            "A person of words and not deeds is like a garden full of weeds.",
            "Demand more from yourself, others respect you deeply.",
            "Determination is what you need now.",
            "Don’t let your limitations overshadow your talents.",
            "Feeding a cow with roses does not get extra appreciation.",
            "If a true sense of value is to be yours it must come through service.",
            "If certainty were truth, we would never be wrong.",
            "If you continually give, you will continually have.",
            "If you look in the right places, you can find some good offerings.",
            "If you think you can do a thing or think you can’t do a thing, you’re right.",
            "If you wish to see the best in others, show the best of yourself.",
            "If you’re feeling down, try throwing yourself into your work.",
            "Imagination rules the world.",
            "In the end all things will be known.",
            "It is better to deal with problems before they arise.",
            "It is honorable to stand up for what is right, however unpopular it seems.",
            "It is worth reviewing some old lessons.",
            "It takes courage to admit fault.",
            "It’s time to get moving. Your spirits will lift accordingly.",
            "Listen to everyone. Ideas come from everywhere.",
            "Living with a commitment to excellence shall take you far.",
            "The human mind, once stretched by a new idea, never regains the original dimensions.",
            "Miles are covered one step at a time.",
            "The end of something marks the start of something new.",
            "New people will bring you new realizations.",
            "Now is the time to try something new.",
            "Physical activity will dramatically improve your outlook today.",
            "Pandas like eating bamboo, but I prefer mine dipped in chocolate.",
            "Practice makes perfect.",
            "Protective measures will prevent costly disasters.",
            "Put your mind into planning today. Look into the future.",
            "Rest has a peaceful effect on your physical and emotional health.",
            "Savor your freedom – it is precious.",
            "Sift through your past to get a better idea of the present.",
            "Success is a journey, not a destination.",
            "Swimming is easy. Staying afloat is hard.",
            "Take the high road.",
            "Stand up again after falling.",
            "The only people who never fail are those who never try.",
            "The person who will not stand for something will fall for anything.",
            "The philosophy of one century is the common sense of the next.",
            "There is no mistake so great as that of being always right.",
            "There is no such thing as an ordinary cat.",
            "Things don’t just happen; they happen just.",
            "Those who care will make the effort.",
            "You are a person of another time.",
            "You are almost there.",
            "You can see a lot just by looking.",
            "You can’t steal second base and keep your foot on first.",
            "You have an active mind and a keen imagination.",
            "You have the power to write your own fortune.",
            "Your dreams are worth your best efforts to achieve them.",
            "Your leadership qualities will be tested and proven.",
            "Your mind is a great asset.",
            "Your talents will be recognized and suitably rewarded."
        };

        public Fortune()
        {
            int number = random.Next(fortunes.Length);
            string fortune = fortunes[number];
            //Format(fortune);
            //int[] LuckyNumbers = { 1, 2, 3 };
            for (int i = 0; i < 6; i++)
            {
                int rand = random.Next(99);
                randomNum.Add(rand);
            }
            Format(fortune, randomNum);
        }

        //public void Format(string message)
        //{
        //    BackgroundColor = ConsoleColor.White;
        //    ForegroundColor = ConsoleColor.Blue;
        //    Write("\n\n");
        //    Border(message.Length);
        //    WriteLine(message);
        //    Border(message.Length);
        //    Write("\n\n");
        //    ResetColor();
        //}

        public void Format(string message, List<int> _luckyNumbers)
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Blue;
            string numbers = "Lucky Numbers: " + _luckyNumbers[0] + " " + _luckyNumbers[1] + " " + _luckyNumbers[2] + " " + _luckyNumbers[3] + " " + _luckyNumbers[4];
            Write("\n\n");
            Border(message.Length);
            WriteLine(message);
            WriteLine("Lucky Numbers: " + numbers);
            Border(message.Length);
            Write("\n\n");
            ResetColor();
        }

        public void Border(int spaces)
        {
            if (spaces > 36)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Write("=");
                }
            }
            else
            {
                for (int i = 0; i < 36; i++)
                {
                    Write("=");
                }
            }

            Write("\n");
        }
    }
}
