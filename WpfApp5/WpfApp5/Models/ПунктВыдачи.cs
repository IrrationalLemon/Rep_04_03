using System;
using System.Collections.Generic;

namespace WpfApp5.Models;

public partial class ПунктВыдачи
{
    public int Код { get; set; }

    public string Адрес { get; set; } = null!;

    public virtual ICollection<Заказ> Заказs { get; set; } = new List<Заказ>();
}
