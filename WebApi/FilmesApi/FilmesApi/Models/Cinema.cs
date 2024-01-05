﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }


    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }

    public int EnderecoId { get; set; }
    public virtual Endereco Endereco { get; set; }// mostra relação que exite 1:1

    public virtual ICollection<Sessao> Sessoes { get; set; }
}
