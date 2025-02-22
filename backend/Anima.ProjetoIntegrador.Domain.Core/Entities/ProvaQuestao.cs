﻿using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public class ProvaQuestao : Entity
    {
        public Guid? ProvaId { get; set; }
        public virtual Prova? Prova { get; set; }
        public Guid? QuestaoId { get; set; }
        public virtual Questao? Questao { get; set; }
    }
}
