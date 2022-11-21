// TASK: The task is to explore different ways of putting two numbers together.

// Pay special attention when mixing texts with numbers!

Console.WriteLine(
    @"Engineering maths text
======================
one and one is:");

Console.WriteLine("a) " + 1 + 1 );
Console.WriteLine("b) " + (1 + 1) );
Console.WriteLine("c) " + "Mostly fun");

// Waiting for Enter
Console.ReadLine();


/* DISCUSSION:
 * 
 *   When you mix numbers with text, the result might appear different from what you
    expect!
    
    Let’s consider the first answer (a). The computer calculates the whole expression
    from left to right. First, it takes the text a) and a number (the first 1). It joins them
    together to be a) 1. Then, it takes this new text and the final number (the second 1) and
    again joins them together to obtain the text a) 11.

    The second answer (b) is different. The parentheses make the computer perform the
    addition of the numbers first, joining the text on the left only afterward.
    Sometimes it may be more transparent to precalculate the intermediate results and
    store them in variables.
 * 
 * 
 * 
 * 