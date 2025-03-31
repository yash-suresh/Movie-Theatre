/*Requirements:

You are creating a booking system for a movie theatre.

- 8 rows of 10 seats each.
- Each seat is initially empty.
- Each seat will be labelled from A to H, and 1 to 10 e.g C5, F7
- Seating will be filled out from back to front, front row being A, last row being H. 
- When a group books  tickets, they must be seated together as much as possible.
- Group size cannot be greater than 10

Bonus: Create a seat 'wrapping' arrangement for group sizes larger than 10,
ensuring that the group is sat as close to each other as possible

*/

using System.Xml.Serialization;
using MovieTheatre;


class Program
{

    static void Main()
    {

        Theatre application = new Theatre();
        application.Run();

        try{

            Console.WriteLine("Welcome to Giffard Park Theatre\nHow many tickets do you want?\n");
            string input = Console.ReadLine();
            if(int.Parse(input) > 10)
            {
                Console.WriteLine("No more than 10 tickets can purchase at once!");

            }
            else if(int.Parse(input) < 0)
            {
                throw new ArgumentException("Please enter a valid numerical value");
            }
            else if(!int.TryParse(input, out int numTickets))
            {
                throw new ArgumentException("Please enter a valid numerical value");
            } 
            else
            {
                Console.WriteLine("Here are your assigned seats\n");
                foreach(string s in application.AssignSeats(int.Parse(input)))
                {
                    Console.WriteLine(s);
                }
            }  
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("\n\nThank you for using Giffard Park Theatre\n\n");
        }
    }
    
}

























































