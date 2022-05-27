using SQLite;
using System;

namespace AppToDoList.Model
{
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }  
        public string Valor_Estimado { get; set; }
        public string Valor_Pago { get; set; }
    }
}
