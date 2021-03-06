using System.Collections.Generic;

using System;

namespace ProAgil.Domain
{
    public class Evento
    { 
        public int Id { get; set; }
        public string ImagemUrl { get; set; }
        public string Local { get; set; }
        public DateTime DataDoEvento { get; set; }
        public string Tema { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int QuantidadeDePessoas { get; set; }
        public List<Lote> Lotes { get; set; }
        public List<RedeSocial> ResdesSociais { get; set; }
        public List<PalestranteEvento> PalestrantesEventos { get; set; }
        
    }
}