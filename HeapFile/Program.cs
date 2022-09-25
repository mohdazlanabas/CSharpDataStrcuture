namespace HeapFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Cow betsy = new Cow();
 
            // betsy is in stack point to new Cow which is in the Heap
            Cow georgy = new Cow();
            // georgy is in stack point to new Cow which is in the Heap with different address
            Cow clone = betsy;
            // clone is on the stack vut pointing to same address as betsy
            int MeInt = 8;
            Cow c = new Cow();

  
        }
    }
        class Cow
        {
            int mooCount;
            // primitives goes on the stack and it is in the stack, not point to heap
            bool butchered;
            // once Cow is instantiate, the primitives moves to Heap

    }
}