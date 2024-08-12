using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_arrays.Main
{
    public class Core
    {
        // The block of code below is a method definition. So far, you've been using methods created by other people
        // such as .length() and .charAt(n)
        // From this exercise on, you'll be writing code inside methods very often! Methods are a container for a specific
        // piece of logic that the class can run. For now, just implement your solutions between the comments that look like:
        // WRITE YOUR CODE BETWEEN THIS LINE...
        // ... AND THIS LINE
        // See the example method below
        public void example()
        {
            //TODO: 1. Print the word "Hello"
            // WRITE YOUR CODE BETWEEN THIS LINE...
            Console.WriteLine("Hello");
            // ... AND THIS LINE
        }

        public int[] one()
        {
            //throw new NotImplementedException();
            int[] numbers = { 42, 13, 17, 91 };

            // 1. Values contained in an array are each stored at a unique numeric index, starting from 0 ascending in order.
            // E.g. The first value is at index 0, the second at index 1, the third at index 3.
            // Using an index, change the number 17 in the numbers array to 68
            // WRITE YOUR CODE BETWEEN THIS LINE...
            numbers[2] = 68;

            // ... AND THIS LINE

            return numbers;
        }

        public String two()
        {
            //throw new NotImplementedException();
            String[] teachers = { "Nathan", "Ed", "Dave", "Carlo", "Lewis", "Jules", "John", "Chris", "Nigel" };

            //TODO: 2. Using an array index, change the value of the teacher variable below to be the fourth
            // teacher contained in the teachers array
            // WRITE YOUR CODE BETWEEN THIS LINE...

            String teacher = new String(teachers[3]);

            // ... AND THIS LINE

            return teacher;
        }

        public String[] three()
        {
            //throw new NotImplementedException();
            //TODO: 3. Create a string array named cars that contains three names of car manufacturers: Audi, BMW and Dodge
            // WRITE YOUR CODE BETWEEN THIS LINE...

            String[] cars = { "Audi", "BMW", "Dodge" };

            // ... AND THIS LINE

            return cars;
        }

        public int four()
        {
            //throw new NotImplementedException();
            int[] numbers = { 42, 13, 17, 91 };

            // TODO 4. Using array indices, set the value of the result variable below to the sum of every number in the numbers array
            // WRITE YOUR CODE BETWEEN THIS LINE...

            int result = numbers.Sum();

            // ... AND THIS LINE

            return result;
        }

        public float[] five()
        {
            //throw new NotImplementedException();
            //TODO: 5. Create an array called floats that contains 3 floating point numbers: 9.62, 23.17 and 3.14
            // WRITE YOUR CODE BETWEEN THIS LINE...

            float[] floats = { 9.62f, 23.17f, 3.14f };

            // ... AND THIS LINE

            return floats;
        }
    }
}
