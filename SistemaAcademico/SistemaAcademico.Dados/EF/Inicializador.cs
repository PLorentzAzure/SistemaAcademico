using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using static SistemaAcademico.Dominio.Base.Servico;

namespace SistemaAcademico.Dados.EF
{
    internal class Inicializador :  DropCreateDatabaseIfModelChanges<ContextoEntity>
    {
        protected override void Seed(ContextoEntity contexto)
        {
            new List<Curso>
            {
                new Curso { Nome = "Ciência da Computação" },
                new Curso { Nome = "Engenharia da Computação" },
                new Curso { Nome = "Engenharia de Software" },
                new Curso { Nome = "Sistemas de Informação" },
            }.Adicionar(contexto);

            new List<Disciplina>
            {
                new Disciplina {Nome = "Algoritmos e Estruturas de Dados I" },
                new Disciplina {Nome = "Algoritmos e Estruturas de Dados II" },
                new Disciplina {Nome = "Algoritmos e Estruturas de Dados III" },
                new Disciplina {Nome = "Cálculo I" },
                new Disciplina {Nome = "Cálculo II" },
                new Disciplina {Nome = "Cálculo III" },
                new Disciplina {Nome = "Cálculo IV" },
                new Disciplina {Nome = "Banco de Dados I" },
                new Disciplina {Nome = "Banco de Dados II" },
                new Disciplina {Nome = "Matemática Discreta I" },
                new Disciplina {Nome = "Matemática Discreta II" },
                new Disciplina {Nome = "Filosofia I" },
                new Disciplina {Nome = "Filosofia II" },
                new Disciplina {Nome = "Cultura Religiosa I" },
                new Disciplina {Nome = "Cultura Religiosa II" },
                new Disciplina {Nome = "Seminário I" },
                new Disciplina {Nome = "Seminário II" },
                new Disciplina {Nome = "Seminário III" },
                new Disciplina {Nome = "Seminário IV" },
                new Disciplina {Nome = "Redes de Computadores I" },
                new Disciplina {Nome = "Redes de Computadores II" },
                new Disciplina {Nome = "Teoria Geral da Administração" },
                new Disciplina {Nome = "Introdução à computação" },
                new Disciplina {Nome = "Introdução à Engenharia" },
                new Disciplina {Nome = "Inteligência Artificial" },
                new Disciplina {Nome = "Introdução à computação" },
                new Disciplina {Nome = "Grafos" },
                new Disciplina {Nome = "Física Eletromagnética" },
                new Disciplina {Nome = "Fundamentos de Mecânica" },
                new Disciplina {Nome = "Gestão de Negócios" },
                new Disciplina {Nome = "Engenharia de Software" },
                new Disciplina {Nome = "Linguagens de Programação" },
            }.Adicionar(contexto);

            new List<Grade>
            {
                new Grade {Nome = "Ciência da Computação OF01", IdCurso = 1 },
                new Grade {Nome = "Ciência da Computação OF02", IdCurso = 1 },
                new Grade {Nome = "Engenharia da Computação OF01", IdCurso = 1 },
                new Grade {Nome = "Engenharia de Software OF01", IdCurso = 1 },
                new Grade {Nome = "Sistemas de Informação OF01", IdCurso = 1 },
                new Grade {Nome = "Sistemas de Informação OF01", IdCurso = 1 }
            }.Adicionar(contexto);

            new List<GradeDisciplina>
            {
                // Ciencia da computação - Oferta 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 4 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 10 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 5 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 11 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 17 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 14}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 6 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 18 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 3 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 7 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 9 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 15 },

                // Ciencia da computação - Oferta 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 4 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 10 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 5 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 11 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 17 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 20}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 6 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 18 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 3 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 7 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 9 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 21 },

                // Engenharia da Computação - Oferta 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 4 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 10 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 24 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 5 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 11 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 28 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 20}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 6 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 29 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 3 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 7 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 32 },

                // Engenharia de Software - Oferta 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 12},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 24 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 32},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 17 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 20}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 13 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 27},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 18 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 30 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 19 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 9 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 22 },

                // Sistemas de Informação - Oferta 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 12},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 23 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 12},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 17 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 20}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 13 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 27 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 18 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 30 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 19 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 9 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 21 },

                // Sistemas de Informação - Oferta 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 1 }, // Período 1
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 12},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 16 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 23 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 2 }, // Período 2
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 12},
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 8 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 17 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 20}, // Período 3
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 14 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 27 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 18 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 10 }, // Período 4
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 19 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 9 },
                new GradeDisciplina {IdGrade = 1, IdDisciplina = 21 },


            }.Adicionar(contexto);

            new List<Usuario>
            {
                new Usuario {Login= "harry", Senha = "$2a$08$Q1KFtweicHfp1LLztxiSWO2sdX6Hv9LootUhkuEN71qwphkuElfVC" },  // Senha = 123456
                new Usuario {Login= "vinicius", Senha = "$2a$08$Q1KFtweicHfp1LLztxiSWO2sdX6Hv9LootUhkuEN71qwphkuElfVC" },  // Senha = 123456
                new Usuario {Login= "renato", Senha = "$2a$08$Q1KFtweicHfp1LLztxiSWO2sdX6Hv9LootUhkuEN71qwphkuElfVC" },  // Senha = 123456

                new Usuario {Login= "marco", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "davi", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "guta", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "alessandro", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456
                new Usuario {Login= "artur", Senha= "$2a$08$EMgN29i6OLLiqy.Zj6XKbuiluLZibX2Eqz6txGk8mFNxjeTdHmvKK" },  // Senha = 123456

            }.Adicionar(contexto);

            new List<Professor>
            {
                new Professor {Nome= "Marco Aurélio", IdUsuario = 4 },
                new Professor {Nome= "Davi Melazo", IdUsuario = 5 },
                new Professor {Nome= "Maria Augusta", IdUsuario = 6 },
                new Professor {Nome= "Alessandro Kieras", IdUsuario = 7 },
                new Professor {Nome= "Artur Mol", IdUsuario = 8 }

            }.Adicionar(contexto);


            new List<Aluno> // TODO: Impedir professor e aluno com mesmo usuário?
            {
                new Aluno {Nome= "Harry Potter", IdUsuario = 1 },
                new Aluno {Nome= "Vinícius Amaral", IdUsuario = 2 },
                new Aluno {Nome= "Renato", IdUsuario = 3 }
            }.Adicionar(contexto);

            new List<Oferta>
            {
                // Apenas Ofertas em Ciência da Computação - OF 02
                new Oferta {IdGradeDisciplina = 17, IdProfessor = 1 },
                new Oferta {IdGradeDisciplina = 18, IdProfessor = 2 },
                new Oferta {IdGradeDisciplina = 19, IdProfessor = 3 },
                new Oferta {IdGradeDisciplina = 20, IdProfessor = 4 },
                new Oferta {IdGradeDisciplina = 21, IdProfessor = 5 },
                new Oferta {IdGradeDisciplina = 22, IdProfessor = 1 },
                new Oferta {IdGradeDisciplina = 23, IdProfessor = 2 },
                new Oferta {IdGradeDisciplina = 24, IdProfessor = 3 },
                new Oferta {IdGradeDisciplina = 25, IdProfessor = 4 },
                new Oferta {IdGradeDisciplina = 26, IdProfessor = 5 },
                new Oferta {IdGradeDisciplina = 27, IdProfessor = 1 },
                new Oferta {IdGradeDisciplina = 28, IdProfessor = 2 },
                new Oferta {IdGradeDisciplina = 29, IdProfessor = 3 },
                new Oferta {IdGradeDisciplina = 30, IdProfessor = 4 },
                new Oferta {IdGradeDisciplina = 31, IdProfessor = 5 },
                new Oferta {IdGradeDisciplina = 32, IdProfessor = 1 },
            }.Adicionar(contexto);

            new List<Matricula>
            {
                new Matricula {Periodo = 1, IdAluno = 1 },
                new Matricula {Periodo = 1, IdAluno = 2 },
                new Matricula {Periodo = 1, IdAluno = 3 },

                new Matricula {Periodo = 1, IdAluno = 1 },
                new Matricula {Periodo = 1, IdAluno = 2 },

                new Matricula {Periodo = 1, IdAluno = 1 },
                                                      
                new Matricula {Periodo = 1, IdAluno = 1 },
            }.Adicionar(contexto);

            new List<MatriculaOferta>
            {
                // Matrículas do Harry
                new MatriculaOferta {IdMatricula = 1, IdOferta = 1 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 2 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 3 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 4 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 5 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 6 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 7 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 8 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 9 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 10 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 11 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 12 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 13 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 14 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 15 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 16 },

                // Matrículas do Vinícius
                new MatriculaOferta {IdMatricula = 1, IdOferta = 1 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 2 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 3 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 4 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 5 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 6 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 7 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 8 },

                // Matrículas do Renato
                new MatriculaOferta {IdMatricula = 1, IdOferta = 1 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 2 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 3 },
                new MatriculaOferta {IdMatricula = 1, IdOferta = 4 }
            }.Adicionar(contexto);

            new List<Atividade>
            {
                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 1 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 2 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 2 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 2 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 2 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 2 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 3 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 3 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 4 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 4 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 4 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 4 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 4 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 5 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 5 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 6 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 6 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 6 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 6 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 6 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 7 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 7 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 8 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 8 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 8 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 8 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 8 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 9 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 9 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 10 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 10 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 10 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 10 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 10 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 11 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 11 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 12 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 12 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 12 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 12 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 12 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 13 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 13 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 13 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 13 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 1 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 13 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 13 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 14 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 14 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 14 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 14 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 14 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 5, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 5, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 20, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "TP 03", Valor= 5, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "TP 04", Valor= 5, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 20, IdOferta = 15 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 15 },

                new Atividade { Data = DateTime.Now, Nome = "TP 01", Valor= 10, IdOferta = 16 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 01", Valor= 30, IdOferta = 16 },
                new Atividade { Data = DateTime.Now, Nome = "TP 02", Valor= 10, IdOferta = 16 },
                new Atividade { Data = DateTime.Now, Nome = "Prova 02", Valor= 30, IdOferta = 16 },
                new Atividade { Data = DateTime.Now, Nome = "Trabalho Final", Valor= 20, IdOferta = 16 }
            }.Adicionar(contexto);

            new List<MatriculaAtividade>
            {
                // Atividades do Pedro - Período 1
                new MatriculaAtividade {IdAtividade = 1, IdMatriculaOferta = 1, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 2, IdMatriculaOferta = 1, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOferta = 1, Nota = 20 },
                new MatriculaAtividade {IdAtividade = 4, IdMatriculaOferta = 1, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 5, IdMatriculaOferta = 1, Nota = 0 },
                new MatriculaAtividade {IdAtividade = 6, IdMatriculaOferta = 1, Nota = 15 },
                new MatriculaAtividade {IdAtividade = 7, IdMatriculaOferta = 1, Nota = 20 },

                new MatriculaAtividade {IdAtividade = 8, IdMatriculaOferta = 2, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 9, IdMatriculaOferta = 2, Nota = 27 },
                new MatriculaAtividade {IdAtividade = 10, IdMatriculaOferta = 2, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 11, IdMatriculaOferta = 2, Nota = 15 },
                new MatriculaAtividade {IdAtividade = 12, IdMatriculaOferta = 2, Nota = 18 },

                new MatriculaAtividade {IdAtividade = 13, IdMatriculaOferta = 3, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 14, IdMatriculaOferta = 3, Nota = 2 },
                new MatriculaAtividade {IdAtividade = 15, IdMatriculaOferta = 3, Nota = 18 },
                new MatriculaAtividade {IdAtividade = 16, IdMatriculaOferta = 3, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 17, IdMatriculaOferta = 3, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 18, IdMatriculaOferta = 3, Nota = 14 },
                new MatriculaAtividade {IdAtividade = 19, IdMatriculaOferta = 3, Nota = 15 },

                new MatriculaAtividade {IdAtividade = 20, IdMatriculaOferta = 4, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 21, IdMatriculaOferta = 4, Nota = 25 },
                new MatriculaAtividade {IdAtividade = 22, IdMatriculaOferta = 4, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 23, IdMatriculaOferta = 4, Nota = 19 },
                new MatriculaAtividade {IdAtividade = 24, IdMatriculaOferta = 4, Nota = 20 },

                // Atividades do Pedro - Período 2
                new MatriculaAtividade {IdAtividade = 25, IdMatriculaOferta = 5, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 26, IdMatriculaOferta = 5, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 27, IdMatriculaOferta = 5, Nota = 19 },
                new MatriculaAtividade {IdAtividade = 28, IdMatriculaOferta = 5, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 29, IdMatriculaOferta = 5, Nota = 1 },
                new MatriculaAtividade {IdAtividade = 30, IdMatriculaOferta = 5, Nota = 14 },
                new MatriculaAtividade {IdAtividade = 31, IdMatriculaOferta = 5, Nota = 17 },

                new MatriculaAtividade {IdAtividade = 32, IdMatriculaOferta = 6, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 33, IdMatriculaOferta = 6, Nota = 25 },
                new MatriculaAtividade {IdAtividade = 34, IdMatriculaOferta = 6, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 35, IdMatriculaOferta = 6, Nota = 27 },
                new MatriculaAtividade {IdAtividade = 36, IdMatriculaOferta = 6, Nota = 17 },

                new MatriculaAtividade {IdAtividade = 37, IdMatriculaOferta = 7, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 38, IdMatriculaOferta = 7, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 39, IdMatriculaOferta = 7, Nota = 17 },
                new MatriculaAtividade {IdAtividade = 40, IdMatriculaOferta = 7, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 41, IdMatriculaOferta = 7, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 42, IdMatriculaOferta = 7, Nota = 16 },
                new MatriculaAtividade {IdAtividade = 43, IdMatriculaOferta = 7, Nota = 14 },

                new MatriculaAtividade {IdAtividade = 44, IdMatriculaOferta = 8, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 45, IdMatriculaOferta = 8, Nota = 23 },
                new MatriculaAtividade {IdAtividade = 46, IdMatriculaOferta = 8, Nota = 12 },
                new MatriculaAtividade {IdAtividade = 47, IdMatriculaOferta = 8, Nota = 27 },
                new MatriculaAtividade {IdAtividade = 48, IdMatriculaOferta = 8, Nota = 17 },

                 // Atividades do Pedro - Período 3
                new MatriculaAtividade {IdAtividade = 49, IdMatriculaOferta = 9, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 50, IdMatriculaOferta = 9, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 51, IdMatriculaOferta = 9, Nota = 20 },
                new MatriculaAtividade {IdAtividade = 52, IdMatriculaOferta = 9, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 53, IdMatriculaOferta = 9, Nota = 0 },
                new MatriculaAtividade {IdAtividade = 54, IdMatriculaOferta = 9, Nota = 15 },
                new MatriculaAtividade {IdAtividade = 55, IdMatriculaOferta = 9, Nota = 20 },

                new MatriculaAtividade {IdAtividade = 56, IdMatriculaOferta = 10, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 57, IdMatriculaOferta = 10, Nota = 27 },
                new MatriculaAtividade {IdAtividade = 58, IdMatriculaOferta = 10, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 59, IdMatriculaOferta = 10, Nota = 15 },
                new MatriculaAtividade {IdAtividade = 60, IdMatriculaOferta = 10, Nota = 18 },

                new MatriculaAtividade {IdAtividade = 61, IdMatriculaOferta = 11, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 62, IdMatriculaOferta = 11, Nota = 2 },
                new MatriculaAtividade {IdAtividade = 63, IdMatriculaOferta = 11, Nota = 18 },
                new MatriculaAtividade {IdAtividade = 64, IdMatriculaOferta = 11, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 65, IdMatriculaOferta = 11, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 66, IdMatriculaOferta = 11, Nota = 14 },
                new MatriculaAtividade {IdAtividade = 67, IdMatriculaOferta = 11, Nota = 15 },

                new MatriculaAtividade {IdAtividade = 68, IdMatriculaOferta = 12, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 69, IdMatriculaOferta = 12, Nota = 25 },
                new MatriculaAtividade {IdAtividade = 70, IdMatriculaOferta = 12, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 71, IdMatriculaOferta = 12, Nota = 19 },
                new MatriculaAtividade {IdAtividade = 72, IdMatriculaOferta = 12, Nota = 20 },

                // Atividades do Pedro - Período 4 (período atual)
                new MatriculaAtividade {IdAtividade = 73, IdMatriculaOferta = 13, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 74, IdMatriculaOferta = 13, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 75, IdMatriculaOferta = 13, Nota = 19 },
                new MatriculaAtividade {IdAtividade = 76, IdMatriculaOferta = 13, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 77, IdMatriculaOferta = 13, Nota = 1 },

                new MatriculaAtividade {IdAtividade = 80, IdMatriculaOferta = 14, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 81, IdMatriculaOferta = 14, Nota = 25 },
                new MatriculaAtividade {IdAtividade = 82, IdMatriculaOferta = 14, Nota = 10 },

                new MatriculaAtividade {IdAtividade = 85, IdMatriculaOferta = 15, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 86, IdMatriculaOferta = 15, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 87, IdMatriculaOferta = 15, Nota = 17 },

                new MatriculaAtividade {IdAtividade = 44, IdMatriculaOferta = 16, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 45, IdMatriculaOferta = 16, Nota = 23 },
                new MatriculaAtividade {IdAtividade = 46, IdMatriculaOferta = 16, Nota = 12 },

                // Atividades do Vinícius - Período 1
                new MatriculaAtividade {IdAtividade = 1, IdMatriculaOferta = 17, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 2, IdMatriculaOferta = 17, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOferta = 17, Nota = 18 },
                new MatriculaAtividade {IdAtividade = 4, IdMatriculaOferta = 17, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 5, IdMatriculaOferta = 17, Nota = 2 },
                new MatriculaAtividade {IdAtividade = 6, IdMatriculaOferta = 17, Nota = 20 },
                new MatriculaAtividade {IdAtividade = 7, IdMatriculaOferta = 17, Nota = 18 },

                new MatriculaAtividade {IdAtividade = 8, IdMatriculaOferta = 18, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 9, IdMatriculaOferta = 18, Nota = 30 },
                new MatriculaAtividade {IdAtividade = 10, IdMatriculaOferta = 18, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 11, IdMatriculaOferta = 18, Nota = 22 },
                new MatriculaAtividade {IdAtividade = 12, IdMatriculaOferta = 18, Nota = 15 },

                new MatriculaAtividade {IdAtividade = 13, IdMatriculaOferta = 19, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 14, IdMatriculaOferta = 19, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 15, IdMatriculaOferta = 19, Nota = 17 },
                new MatriculaAtividade {IdAtividade = 16, IdMatriculaOferta = 19, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 17, IdMatriculaOferta = 19, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 18, IdMatriculaOferta = 19, Nota = 18 },
                new MatriculaAtividade {IdAtividade = 19, IdMatriculaOferta = 19, Nota = 17 },

                new MatriculaAtividade {IdAtividade = 20, IdMatriculaOferta = 20, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 21, IdMatriculaOferta = 20, Nota = 26 },
                new MatriculaAtividade {IdAtividade = 22, IdMatriculaOferta = 20, Nota = 10 },
                new MatriculaAtividade {IdAtividade = 23, IdMatriculaOferta = 20, Nota = 20 },
                new MatriculaAtividade {IdAtividade = 24, IdMatriculaOferta = 20, Nota = 14 },

                // Atividades do Vinícius - Período 2 (período atual)
                new MatriculaAtividade {IdAtividade = 25, IdMatriculaOferta = 21, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 26, IdMatriculaOferta = 21, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 27, IdMatriculaOferta = 21, Nota = 19 },
                new MatriculaAtividade {IdAtividade = 28, IdMatriculaOferta = 21, Nota = 5 },

                new MatriculaAtividade {IdAtividade = 32, IdMatriculaOferta = 22, Nota = 7 },
                new MatriculaAtividade {IdAtividade = 33, IdMatriculaOferta = 22, Nota = 26 },
                new MatriculaAtividade {IdAtividade = 34, IdMatriculaOferta = 22, Nota = 10 },

                new MatriculaAtividade {IdAtividade = 37, IdMatriculaOferta = 23, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 38, IdMatriculaOferta = 23, Nota = 3 },
                new MatriculaAtividade {IdAtividade = 39, IdMatriculaOferta = 23, Nota = 18 },

                new MatriculaAtividade {IdAtividade = 44, IdMatriculaOferta = 24, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 45, IdMatriculaOferta = 24, Nota = 23 },

                // Atividades do Renato - Período 1 (período atual)
                new MatriculaAtividade {IdAtividade = 1, IdMatriculaOferta = 17, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 2, IdMatriculaOferta = 17, Nota = 4 },
                new MatriculaAtividade {IdAtividade = 3, IdMatriculaOferta = 17, Nota = 17 },
                new MatriculaAtividade {IdAtividade = 4, IdMatriculaOferta = 17, Nota = 4 },

                new MatriculaAtividade {IdAtividade = 8, IdMatriculaOferta = 18, Nota = 8 },
                new MatriculaAtividade {IdAtividade = 9, IdMatriculaOferta = 18, Nota = 27 },
                new MatriculaAtividade {IdAtividade = 10, IdMatriculaOferta = 18, Nota = 7 },

                new MatriculaAtividade {IdAtividade = 13, IdMatriculaOferta = 19, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 14, IdMatriculaOferta = 19, Nota = 5 },
                new MatriculaAtividade {IdAtividade = 15, IdMatriculaOferta = 19, Nota = 20 },

                new MatriculaAtividade {IdAtividade = 20, IdMatriculaOferta = 20, Nota = 9 },
                new MatriculaAtividade {IdAtividade = 21, IdMatriculaOferta = 20, Nota = 25 }
            }.Adicionar(contexto);

            new List<RetificacaoFalta>
            {
                // Faltas do Pedro no semestre atual (4º Período)
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 13, DataRequisicao = new DateTime(2016, 03, 15), DataFalta = new DateTime(2016, 03, 14), Justificativa = "Estava em conferência.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 14, DataRequisicao = new DateTime(2016, 03, 15), DataFalta = new DateTime(2016, 03, 14), Justificativa = "Estava em conferência.", Status = StatusServico.Aprovado },

                new RetificacaoFalta {IdMatricula = 1, IdOferta = 13, DataRequisicao = new DateTime(2016, 06, 1), DataFalta = new DateTime(2016, 05, 30), Justificativa = "Atestado médico apresentado à Secretaria Acadêmica.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 14, DataRequisicao = new DateTime(2016, 06, 1), DataFalta = new DateTime(2016, 05, 30), Justificativa = "Atestado médico apresentado à Secretaria Acadêmica.", Status = StatusServico.Pendente },
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 15, DataRequisicao = new DateTime(2016, 06, 1), DataFalta = new DateTime(2016, 05, 31), Justificativa = "Atestado médico apresentado à Secretaria Acadêmica.", Status = StatusServico.Pendente },
                new RetificacaoFalta {IdMatricula = 1, IdOferta = 16, DataRequisicao = new DateTime(2016, 06, 1), DataFalta = new DateTime(2016, 05, 31), Justificativa = "Atestado médico apresentado à Secretaria Acadêmica.", Status = StatusServico.Pendente },

                // Faltas do Vinícius no semestre atual (2º Período)
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 7, DataRequisicao = new DateTime(2016, 02, 14), DataFalta = new DateTime(2016, 02, 13), Justificativa = "Meu nome não estava na lista de chamada.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 8, DataRequisicao = new DateTime(2016, 02, 14), DataFalta = new DateTime(2016, 02, 13), Justificativa = "Meu nome não estava na lista de chamada.", Status = StatusServico.Aprovado },

                 // Faltas do Vinícius no semestre atual (2º Período)
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 2, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 4), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 3, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 4), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Pendente },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 2, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 5), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 4, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 5), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Aprovado },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 3, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 6), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Pendente },
                new RetificacaoFalta {IdMatricula = 2, IdOferta = 1, DataRequisicao = new DateTime(2016, 04, 10), DataFalta = new DateTime(2016, 04, 6), Justificativa = "Viajando a trabalho trabalho.", Status = StatusServico.Pendente },
            }.Adicionar(contexto);
        }
    }
}

