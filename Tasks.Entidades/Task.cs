using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Entidades
{
    public class Task
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        public bool Completa { get; set; }

        public DateTime Data { get; set; }

        public Task(long id, string descricao, bool completa)
        {
            Id = id;
            Descricao = descricao;
            Completa = completa;
            Data = descricao.Length > 5 ? DateTime.Now : DateTime.MinValue;
        }
    }

}
