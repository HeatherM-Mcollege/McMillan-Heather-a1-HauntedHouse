//Initial story setting
using System.ComponentModel.Design;

Console.WriteLine("Your legs tremble as you approach the infamous Mayhem Manor.");
Console.WriteLine("You curse your friends for daring you to do this, everyone knows this house is haunted");
Console.WriteLine("As you traverse the front steps, each feeling higher then the last, you take a deep breath.");
Console.WriteLine();

//Choice to knock
Console.WriteLine("Do you enter?");
string input = Console.ReadLine();

if (input == "YES")
{
    Console.WriteLine("You enter the house.");
}
else if (input == "NO")
{
    Console.WriteLine("You turn to leave, but stop as you picture your friends laughing faces.");
    Console.WriteLine("You have to do this. Your pride depends on it.");
}
else //Reprompt in case of invalid
{
    Console.WriteLine("This choice is Invalid. Please type YES or NO");
    string secondInput = Console.ReadLine();

    if (secondInput == "YES")
    {
        Console.WriteLine("You enter the house.");
    }
    else
    {
        Console.WriteLine("You shake your head, steeling your nerves at your hesitation.");
        Console.WriteLine("You have to do this. Your pride depends on it.");
    }
}

Console.WriteLine();
Console.WriteLine("You slowly push open the door, the sounds of the outside world dulling.");
Console.WriteLine("Blinking while adjusting to the dim lights, the stale air floods your nostrils.");
Console.WriteLine("The foyer seems pulled out of a cliche victorian manor, tall and dark.");
Console.WriteLine("Dust litters the floorboards and cobwebs drape the walls");
Console.WriteLine("Noticing a large painting hung above a cabinet at the back of the room you pause.");
Console.WriteLine();
Console.WriteLine("Which one of the following would you like to do; INSPECT the painting, SEARCH the Cabinet, or MOVE to the next room?");

//If else variable for room options/ invalid options
string decision = Console.ReadLine();

if (decision == "INSPECT")
{
    Console.WriteLine("Walking up to the painting an elderly woman glares back at you, her demeanor ridden with disgust.");
    Console.WriteLine("Scowling back at the image you turn moving on to the next room.");
}
else if (decision == "SEARCH")
{
    Console.WriteLine("Approaching the cabinet you notice most of the doors have locks.");
    Console.WriteLine("With a few attempts you confirm them to be unopenable");
    Console.WriteLine("One door however remains slighly ajar, appearing jammed");
    Console.WriteLine("You yank it a bit too roughly causing it to fall to the floor a Knife clattering out.");
    Console.WriteLine();
    Console.WriteLine("Do you take it?");
    Console.WriteLine();
    string knife = Console.ReadLine();
     if (knife == "YES")
     {
        Console.WriteLine("Having taken the knife you move on to the next room.");
     }
     else if (knife == "NO")
     {
        Console.WriteLine("Leaving the Knife you move on to the next room.");
     }
     else
     {
        Console.WriteLine("Choice is invalid choose YES or NO");
        Console.WriteLine();
        string takeKnife = Console.ReadLine();
        if (takeKnife == "YES")
        {
            Console.WriteLine("You take the Knife");
        }
        else
        {
            Console.WriteLine("Gripping the knife it shakes in your hands.");
            Console.WriteLine("This doesnt feel right. You drop the knife leaving it behind as you go to the next room.");
        }
     }
}
else if (decision == "MOVE")
{
    Console.WriteLine("You move onto the next room, not seeing anything of personal interest.");
}
else //Main reprompt incase of invalid answers
{
    Console.WriteLine("Invalid answer, You must chooseto INSPECT, SEARCH, or MOVE");
    Console.WriteLine();
    string secondDecision = Console.ReadLine();
    if (secondDecision == "INSPECT")
    {
        Console.WriteLine("Walking up to the painting an elderly woman glares back at you, her demeanor ridden with disgust.");
        Console.WriteLine("Scowling back at the image you turn moving on to the next room.");
    }
    else if (secondDecision == "SEARCH")
    {
        Console.WriteLine("As you approach the cabinet, you notice most of the doors have locks.");
        Console.WriteLine("With a few attempts you confirm them to be unopenable");
        Console.WriteLine("One door however remains slighly ajar, appearing jammed");
        Console.WriteLine("You yank it a bit too roughly causing it to fall to the floor a knife clattering out.");
        Console.WriteLine();
        Console.WriteLine("Do you take it?");
        string secondKnife = Console.ReadLine();
        if (secondKnife == "YES")
        {
            Console.WriteLine("Having taken the knife you move on to the next room.");
        }
        else if (secondKnife == "NO")
        {
            Console.WriteLine("Leaving the knife you move on to the next room.");
        }
        else
        {
            Console.WriteLine("Choice is invalid choose YES or NO");
            Console.WriteLine();
            string takeKnife = Console.ReadLine();
            if (takeKnife == "YES")
            {
                Console.WriteLine("You take the Knife");
            }
            else
            {
                Console.WriteLine("Gripping the knife it shakes in your hands.");
                Console.WriteLine("This doesnt feel right. You drop the knife leaving it behind as you go to the next room.");
            }
        }
    }
    else if (secondDecision == "MOVE")
    {
        Console.WriteLine("You move onto the next room, not seeing anything of personal interest.");
    }
    else //forced answer if continued failed prompts
    {
        Console.WriteLine("Your body freezes up, the tension of the manor getting to you.");
        Console.WriteLine("Whatever you wanted to do before you cast it aside, choosing to move on to the next room.");
    }
}

Console.WriteLine();
Console.WriteLine("As you enter a heavy fog sets in at your feet.");
Console.WriteLine("You can feel that something is wrong, this room is off.");
Console.WriteLine("You shouldnt be here, all your instincts flare,the hair on you neck standing up.");
Console.WriteLine();
Console.WriteLine("CREEEEEEAK!");
Console.WriteLine();
Console.WriteLine("You whip around at the sudden sound. A large Zombie towering over you.");
Console.WriteLine();
Console.WriteLine("Do you have a Knife?");
Console.WriteLine();

//Unsure how to check knife variable from earlier now, backup idea console.writeline reprompt asking for knife
string weapon = Console.ReadLine();

if (weapon == "YES")
{
    Console.WriteLine("'Hi! Im fre-OW'");
    Console.WriteLine("You dont hear them finish having already stabbed the Zombie.");
    Console.WriteLine();
    //Zombie health variable, fight or leave alive option
    int health = 10;
    health -= 5;
        Console.WriteLine($"The Zombie has {health} health left. Do you stab them again?");
        Console.WriteLine();
        string stab = Console.ReadLine();
        if (stab == "YES")
        {
         Console.WriteLine("You stab the zombie a second time, hoping to end this nightmare.");
         health -= 5;
         Console.WriteLine($"The Zombie has {health} health left.Its over theyre dead.");
         Console.WriteLine("You run for the manor blood on your hands");
         Console.WriteLine("Vowing never to step foot in a haunted house again.");
        }
       else
       {
        Console.WriteLine("The knife slips from your hands as you tremble.");
        Console.WriteLine("'Gee that sure hurt! Good thing im dead already!'");
        Console.WriteLine("'My names Fred. Who are you?'");
        Console.WriteLine();
        string name = Console.ReadLine();
        Console.WriteLine($"'Hi {name} it's nice to meet you! It gets pretty lonely here so Im glad to have a new pal!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("~Many years later~");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Looking back on that day, you sure are glad you dropped that knife.");
        Console.WriteLine("Not only did you make a lifelong friend, but the look on your friends faces was hilarious!");
       }

        Console.WriteLine("You run from the manor, blood on your hands");
        Console.WriteLine("Vowing never to step foot in a haunted house again.");
}
else
{
    Console.WriteLine("You shake Knowing this is the end for you. you cower behind your hands waiting for the end.");
    Console.WriteLine("'Hi im Fred!'");
    Console.WriteLine("You look around, unsure who spoke. Eyes landing on the Zombie you face pales");
    Console.WriteLine("'Well? You know my name, whats yours?'");
    Console.WriteLine();
    string name = Console.ReadLine();
    Console.WriteLine($"'Hi {name} it's nice to meet you! It gets pretty lonely here so Im glad to have a new pal!");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("~Many years later~");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Looking back on that day, you sure are glad you went to the manor.");
    Console.WriteLine("Not only did you make a lifelong friend, but the look on your friends faces was hilarious!");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("THE END.");
