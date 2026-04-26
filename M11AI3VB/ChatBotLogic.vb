Public Module ChatBotLogic
    Private ReadOnly RandomReplies As New List(Of String) From {
        "Sorry, I have no idea. Could you please rephrase?",
        "What an interesting question! Let me explain it to you in detail.",
        "According to my comprehension, the answer to this question is...",
        "You just came up with a good perspective, and I think...",
        "Let me help you analyze this case...",
        "Based on your description, I suggest you...",
        "This question involves multiple aspects, I will explain them one by one...",
        "I understand your idea, let me provide some information for you...",
        "This question is a bit complex, let me help you analyze it..."
    }

    Private ReadOnly FixedReplies As New List(Of (keys As String(), reply As String)) From {
        ({"hello", "hi", "hey"}, "Hello! I'm Monoeleven AI, nice to meet you."),
        ({"thanks", "thank you"}, "You're welcome!"),
        ({"who are you"}, "I'm Monoeleven AI, your personal assistant."),
        ({"time"}, $"It's {Date.Now}."),
        ({"bye", "goodbye"}, "Goodbye! Have a nice day!"),
        ({"weather"}, "I'm not sure about the weather. You can check a weather app for more information."),
        ({"how are you"}, "Fine, thank you! And you?"),
        ({"i am fine", "i'm fine"}, "That's good to hear!"),
        ({"help", "what can you do"}, "I can answer questions, provide information, and have conversations with you. Feel free to ask me anything!"),
        ({"name", "your name"}, "My name is Monoeleven AI, but you can call me Mono11 for short."),
        ({"version"}, "I'm currently running version 1.0.1 of the Monoeleven Chatbot Template."),
        ({"creator", "who made you"}, "I was created using the Monoeleven Chatbot Template, a VB.NET project designed for building conversational AI interfaces."),
        ({"joke", "tell me a joke"}, "Why don't programmers like nature? It has too many bugs!"),
        ({"ai", "artificial intelligence"}, "Artificial Intelligence is a fascinating field! I'm an example of conversational AI designed to assist with various tasks."),
        ({"vb.net", "visual basic"}, "VB.NET is a great programming language! This chatbot template was built using VB.NET with MonoGame for the user interface."),
        ({"monogame"}, "MonoGame is a fantastic framework for building cross-platform games and applications. This chatbot uses it for the UI rendering."),
        ({"programming", "code"}, "Programming is like solving puzzles with logic! I can help you with programming concepts and best practices."),
        ({"chatbot", "chat bot"}, "Chatbots like me are designed to simulate conversation with human users. I'm here to help answer your questions!"),
        ({"monoeleven", "mono11"}, "Monoeleven is the name of this chatbot template project. It's designed to be a starting point for building conversational AI interfaces.")
    }

    Public ReadOnly Property ChatbotReply(userMessage As String) As String
        Get
            userMessage = userMessage.ToLower().Trim()

            For Each keysReply In FixedReplies
                With keysReply
                    If Aggregate k In .keys Into Any(userMessage.Contains(k)) Then Return .reply
                End With
            Next

            Return RandomReplies(Random.Shared.Next(RandomReplies.Count))
        End Get
    End Property
End Module