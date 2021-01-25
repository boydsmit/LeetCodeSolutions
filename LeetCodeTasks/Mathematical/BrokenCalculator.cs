namespace LeetCodeTasks.Mathematical
{
    public class BrokenCalculator
    {
        /*
         * TASK: 991
         *
         * On a broken calculator that has a number showing on its display, we can perform two operations:
         *
         *   Double: Multiply the number on the display by 2, or;
         *   Decrement: Subtract 1 from the number on the display.
         *
         * Initially, the calculator is displaying the number X.
         *
         * Return the minimum number of operations needed to display the number Y.
         */
        
        public int BrokenCalc(int X, int Y) {
            if(X >= Y) 
            { 
                return X - Y;
            }
            else if(Y % 2 == 0) 
            {
                return 1 + BrokenCalc(X, Y / 2);
            }
            return 1 + BrokenCalc(X, Y + 1);
        }
    }
}