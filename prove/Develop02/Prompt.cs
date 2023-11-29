using System;

    public class  Prompt
    {
        public List<string> or_prompts = new List<string>();


        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, or_prompts.Count());

            string prompt = or_prompts[number];

            return prompt;

        }
    }  