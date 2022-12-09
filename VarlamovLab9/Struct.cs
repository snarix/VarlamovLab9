using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace VarlamovLab9
{
    struct Sprint
    {
        public string FIO { get; set; }
        public int Number { get; set; }
        public int Result { get; set; }


        public Sprint(string fio, int number, int result)
        {
            FIO = fio;
            Number = number;
            Result = result;
        }

        
        public override string ToString()
        {
            return $" {FIO}, {Number}, {Result}"; ;
        }
    }
}
