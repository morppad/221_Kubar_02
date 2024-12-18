using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221_Kubar_02
{
    public static class Connection
    {
        private static Entities Context;
        public static Entities GetContext()
        {
            if (Context == null)
            {
                try { 
                    Context = new Entities();
                    Console.WriteLine("Контекст успешно создан.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка создания контекста: {ex.Message}");
                    throw;
                }
            }
            return Context;
        }
    }
}
