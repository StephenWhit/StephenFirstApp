using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenTestApp
{
    
    public class FirstClass
    {
        public RelayCommand printCommand { get; set; }
        public int counter;
        public int poopProperty
        {
            get
            {
                return 2 + counter++;
            }
            set
            {

            }
        }
        public FirstClass()
        {
            printCommand = new RelayCommand(printer);
            counter = 1;
        }
        public void printer(object parameter)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(poopProperty);
        }
    }
}
