
using System;
using System.Collections;

using malEjemplo;

namespace Expo
{

    public class Program
    {

        static void Main(string[] args)
        {

            ArrayList telefonos = new ArrayList();

            telefonos.Add(new Zte("ZTE", 2019, 1000, 2));
            telefonos.Add(new Xiaomi("Xiaomi", 2019, 5000, 4));
            telefonos.Add(new Iphone("Iphone", 15, 20000, 8));


            for(object item in telefonos)
            {


            }

        }

    }

}

