using System;

namespace Apteka_SDA
{
    class Resha
    {
        static void Main(string[] args)
        {
            ClassLibrary.Cl_farm farm = new ClassLibrary.Cl_farm();
            farm.SetFarm();

            farm.writeFarm();

            farm.GiveBigNum();

            farm.GiveSumm();
            // лдорлролр
        }
    }
}
