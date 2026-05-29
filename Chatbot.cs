using System;
using System.Collections.Generic;
using System.Text;

namespace cyber_security_bottttt
{
    class ChatBot
    {
        Password password = new Password();
        Phishing phishing = new Phishing();
        SafeBrowsing safeBrowsing = new SafeBrowsing();
        Emotion emotion = new Emotion();

        public string GetResponse(string input)
        {
            string emo = emotion.GetEmotion(input);

            input = input.ToLower();

            string response = input switch
            {
                "how are you" => "I'm functioning perfectly 😊",
                "purpose" => "My purpose is to teach cyber security awareness.",
                "topics" => "Passwords, Phishing, Safe Browsing.",
                "password safety" => password.GetInfo(),
                "phishing" => phishing.GetInfo(),
                "safe browsing" => safeBrowsing.GetInfo(),
                "exit" => "Goodbye 👋 Stay safe online!",
                _ => "Invalid option."
            };

            return string.IsNullOrEmpty(emo)
                ? response
                : response + "\n" + emo;
        }
    }
}
