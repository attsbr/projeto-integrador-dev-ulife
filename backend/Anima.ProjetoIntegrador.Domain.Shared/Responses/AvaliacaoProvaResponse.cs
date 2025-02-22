﻿namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AvaliacaoProvaResponse : BaseResponse
    {
        public string? ProvaId { get; set; }
        public string? NomeProva { get; set; }
        public string? NomeAvaliacao { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
    }
}
