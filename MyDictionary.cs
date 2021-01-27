using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev6
{
    class MyDictionary<Name,Number>
    {
        Number[] numbers;
        Name[] names;

        Number[] tempNumbers;
        Name[] tempNames;

        public MyDictionary()
        {
            numbers = new Number[0];
            names = new Name[0];

        }

        public void Add(Name sName, Number sNumber)
        {
            tempNumbers = numbers;
            tempNames = names;

            names = new Name[names.Length + 1];
            numbers = new Number[numbers.Length + 1];

            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }
            names[names.Length - 1] = sName;

            for (int i = 0; i < tempNumbers.Length; i++)
            {
                numbers[i] = tempNumbers[i];
            }
            numbers[numbers.Length - 1] = sNumber;

            Console.WriteLine(sName + " "+ sNumber + " eklendi!");
        }

    }
}
