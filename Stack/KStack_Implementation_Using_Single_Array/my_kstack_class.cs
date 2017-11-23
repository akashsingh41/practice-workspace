using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KStack_Implementation_Using_Single_Array
{
    class my_kstack_class
    {
        int[] array; //main array
        int[] top; //top of each stack array
        int[] next; //index of next element array

        int array_size; //size of main array
        int no_of_stacks; //no of stacks to be created( the 'k')
        int free_top; //index of top of stack of available indices

        public my_kstack_class(int no_of_stacks, int array_size) //Constructor
        {
            this.no_of_stacks = no_of_stacks;
            this.array_size = array_size;
            array = new int[array_size];
            top = new int[no_of_stacks];
            next = new int[array_size];


            // Initialize all stacks as empty
            for (int i = 0; i < no_of_stacks; i++)
                top[i] = -1;

            // Initialize all spaces as free
            free_top = 0;
            for (int i = 0; i < array_size - 1; i++)
                next[i] = i + 1;
            next[array_size - 1] = -1; // -1 is used to indicate end of free list
        }

        // A utility function to check if there is space available
        public bool isFull()
        {
            return (free_top == -1);
        }

        // To check whether stack number 'sn' is empty or not
        public bool isEmpty(int stack_no)
        {
            return (top[stack_no] == -1);
        }


        public void push(int item, int stack_no)// To push an item in stack_no; 0<stack_no<k-1
        {
            // Overflow check
            if (isFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            int i = free_top; // Store index of first free slot

            // Update index of free slot to index of next slot in free list
            free_top = next[i];

            // Update next of top and then top for stack number 'stack_no'
            next[i] = top[stack_no];
            top[stack_no] = i;

            // Put the item in array
            array[i] = item;
        }

        
        public int pop(int stack_no)//pop operation on stack number 'stack_no'
        {
            // Underflow check
            if (isEmpty(stack_no))
            {
                Console.WriteLine("Stack Underflow");
                return int.MaxValue;
            }

            // Find index of top item in that stack number 
            int i = top[stack_no];

            top[stack_no] = next[i]; // Change top to store next of previous top

            // Attach the previous top to the beginning of free list
            next[i] = free_top;
            free_top = i;

            // Return the previous top item
            return array[i];
        }

        public void print_kstack()
        {
            foreach (int x in array)
                Console.Write(x+" ");
        }
    }
}
