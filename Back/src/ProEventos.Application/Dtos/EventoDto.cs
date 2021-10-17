using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio"),
        MinLength(3, ErrorMessage = "Tema deve ter 3 caracteres")]
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes {get; set;}
        public IEnumerable<RedeSocialDto> RedeSociais {get; set;}
        public IEnumerable<PalestranteDto> Palestrantes {get; set;}
    }
}