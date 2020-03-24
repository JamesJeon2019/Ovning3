using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
   abstract class UserError
    {

      public abstract string  UEMessage()
        {
            Console.WriteLine(" You tried to use a text input in a numericonly field.This fired an error!" );
        }

    }

   

}
