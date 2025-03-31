using System.Collections;
using MovieTheatre;

public class Theatre
{

    Stack<Seating> seatStack = new Stack<Seating>();
    int availableSeats;
    
    public void Run()
    {
        InitialiseSeats();
    }

    private void InitialiseSeats()
    {
        for(char i = 'H'; i >= 'A'; i --)
        {
            for(int j = 10; j >= 1; j --)
            {
                
                string seatNum = i + j.ToString();
                seatStack.Push(new Seating(seatNum));
                availableSeats ++;

            }
        }
    }

    public List<string> AssignSeats(int input)
    {
        List<string> bookings = new List<string>();

        
            while(input > 0)
            {
                bookings.Add(seatStack.Pop().seatNumber);
                input --;
                availableSeats --;
            }
        

       return bookings;
    
    }

}