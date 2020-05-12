using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    [Serializable]
    public class Results
    {
        [DisplayName("Имя")]public string Name { get; set; }
        [DisplayName("Результат")] public int Count { get; set; }

    }
}
