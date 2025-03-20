// Benjamin Johnson, Lab 6 Typing Trainer, March 20th
Console.Clear();

// Greeting and Instructions
Console.WriteLine(@"
                                      Welcome to the Typing Trainer!
You'll be given a short story to type out. If you make a mistake, you will not be able to go back and fix it.
                 Once you're done, your Words Per Minute and Accuracy will be given to you.");


// Phrases for the reader to type
string[] phrases = new string[5] {
    "The clock struck twelve as the train rumbled through the foggy valley. Emily gripped her ticket, heart racing. A shadowy figure approached, whispering, \"This isn\'t your train.\" But the doors had locked. The train kept moving, faster and faster, until the stars blurred.",
    "James found an old typewriter in the attic. Each key he pressed revealed a hidden letter. M-E-E-T-M-E-A-T-D-A-W-N. Was someone leaving him a message? He checked the paper again, but the words had vanished. Only the sound of typing remained.",
    "Waves crashed against the shore as Lena climbed the spiral staircase. The lighthouse beacon flickered, casting eerie shadows. A sudden gust of wind slammed the door shut. A whisper echoed, \"The light must never go out.\" But the oil was nearly gone.",
    "Marcus tapped his smartwatch. The screen glowed: SYSTEM ERROR—TIME LOOP ENGAGED. He blinked. The coffee cup tipped over again. The phone rang again. He had lived this moment before. Could he break the cycle before it repeated forever?",
    "Ella ran her fingers along the stone wall, searching for an exit. The labyrinth twisted endlessly. A distant growl made her quicken her pace. Then, a torch flickered; someone else was there. \"Help me!\" she called. The flame went out."
};

// Random Generator for picking a phrase
Random rand = new Random();
string phrase;
phrase = phrases[rand.Next(0,5)];
Console.Write(phrase);

// Sets the cursors position to the start of the phrase
Console.SetCursorPosition(0, 4); 

Console.ReadKey();