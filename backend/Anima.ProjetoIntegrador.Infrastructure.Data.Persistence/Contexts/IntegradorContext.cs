﻿using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts
{
#nullable disable
    public class IntegradorContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Alternativa> Alternativas{ get; set; }
        public DbSet<Aluno> Alunos{ get; set; }
        public DbSet<Avaliacao> Avaliacoes{ get; set; }
        public DbSet<AvaliacaoMatricula> AvaliacoesMatriculas{ get; set; }
        public DbSet<Matricula> Matriculas{ get; set; }
        public DbSet<Professor> Professores{ get; set; }
        public DbSet<Prova> Provas{ get; set; }
        public DbSet<ProvaQuestao> ProvasQuestoes{ get; set; }
        public DbSet<Questao> Questoes{ get; set; }
        public DbSet<Turma> Turmas{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<FolhaResposta> FolhaRespostas{ get; set; }

        public IntegradorContext(IConfiguration configuration)
        {
            _configuration = configuration;
#if DEBUG
            Database.EnsureCreated();
#endif
        }

        public IntegradorContext(DbContextOptionsBuilder builder) 
            : base(builder.Options)
        {
            Database.EnsureCreated();
        }
        public IntegradorContext(string connectionString)
            : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("IntegradorDb");

                optionsBuilder.UseSqlServer(connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlternativaConfiguration());
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new AvaliacaoConfiguration());
            modelBuilder.ApplyConfiguration(new AvaliacaoMatriculaConfiguration());
            modelBuilder.ApplyConfiguration(new MatriculaConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new ProvaConfiguration());
            modelBuilder.ApplyConfiguration(new ProvaQuestaoConfiguration());
            modelBuilder.ApplyConfiguration(new QuestaoConfiguration());
            modelBuilder.ApplyConfiguration(new TurmaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new FolhaRespostaConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
