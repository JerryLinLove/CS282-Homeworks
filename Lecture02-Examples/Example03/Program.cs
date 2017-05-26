using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = 
                @"select * from Table
                    where id > 10
                    ";
            Console.WriteLine(sql);

            string path = "C:\\xampp\\htdoc\\"; //==> 要打兩個 // 因為 /有含意，故字串出現 / 則要打//
            Console.WriteLine(path);

            string path2 = @"C:\xampp\htdoc\";  // ==> 若@"則直接顯示字串，故 / 只會出現 / 不需要打 //
            Console.WriteLine(path2);
        }
    }
}
