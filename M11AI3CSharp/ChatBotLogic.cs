namespace M11AI3CSharp;

public static class ChatBotLogic
{
    private static readonly List<string> RandomReplies =
    [
        "Sorry, I have no idea. Could you please rephrase?",
        "What an interesting question! Let me explain it to you in detail.",
        "According to my comprehension, the answer to this question is...",
        "You just came up with a good perspective, and I think...",
        "Let me help you analyze this case...",
        "Based on your description, I suggest you...",
        "This question involves multiple aspects, I will explain them one by one...",
        "I understand your idea, let me provide some information for you...",
        "This question is a bit complex, let me help you analyze it..."
    ];

    private static readonly List<(string[] keys, string reply)> FixedReplies =
    [
        (new[] { "hello", "hi", "hey" }, "Hello! I'm Monoeleven AI, nice to meet you."),
        (new[] { "thanks", "thank you" }, "You're welcome!"),
        (new[] { "who are you" }, "I'm Monoeleven AI, your personal assistant."),
        (new[] { "time" }, $"It's {DateTime.Now}."),
        (new[] { "bye", "goodbye" }, "Goodbye! Have a nice day!"),
        (new[] { "weather" }, "I'm not sure about the weather. You can check a weather app for more information."),
        (new[] { "how are you" }, "Fine, thank you! And you?"),
        (new[] { "i am fine", "i'm fine" }, "That's good to hear!"),
        (new[] { "help", "what can you do" }, "I can answer questions, provide information, and have conversations with you. Feel free to ask me anything!"),
        (new[] { "name", "your name" }, "My name is Monoeleven AI, but you can call me Mono11 for short."),
        (new[] { "version" }, "I'm currently running version 1.0.1 of the Monoeleven Chatbot Template."),
        (new[] { "creator", "who made you" }, "I was created using the Monoeleven Chatbot Template, a C# project designed for building conversational AI interfaces."),
        (new[] { "joke", "tell me a joke" }, "Why don't programmers like nature? It has too many bugs!"),
        (new[] { "ai", "artificial intelligence" }, "Artificial Intelligence is a fascinating field! I'm an example of conversational AI designed to assist with various tasks."),
        (new[] { "csharp", "c#", "c sharp" }, "C# is a great programming language! This chatbot template was built using C# with MonoGame for the user interface."),
        (new[] { "monogame" }, "MonoGame is a fantastic framework for building cross-platform games and applications. This chatbot uses it for the UI rendering."),
        (new[] { "programming", "code" }, "Programming is like solving puzzles with logic! I can help you with programming concepts and best practices."),
        (new[] { "chatbot", "chat bot" }, "Chatbots like me are designed to simulate conversation with human users. I'm here to help answer your questions!"),
        (new[] { "monoeleven", "mono11" }, "Monoeleven is the name of this chatbot template project. It's designed to be a starting point for building conversational AI interfaces.")
    ];

    public static string GetChatbotReply(string userMessage)
    {
        userMessage = userMessage.ToLower().Trim();
        
        foreach (var (keys, reply) in FixedReplies)
        {
            if (keys.Any(key => userMessage.Contains(key)))
            {
                return reply;
            }
        }

        return RandomReplies[Random.Shared.Next(RandomReplies.Count)];
    }
}