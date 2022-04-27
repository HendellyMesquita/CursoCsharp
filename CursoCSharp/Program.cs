using System;
using System.Collections.Generic;
using CursoCSharp.Api;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Excecoes;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"ATALHOS - Fundamentos", PrimeiroPrograma.Executar},
                {"COMENTARIOS - Fundamentos", Comentario.Executar},
                {"CONSTANTES E VARIAVEIS - Fundamentos", VariaveisEConstantes.Executar},
                {"CONVERSÃO - Fundamentos", Conversao.Executar},
                {"FORMATAÇÃO NUMERICO - Fundamentos", FormatandoNumero.Executar},
                {"INFERENCIA - Fundamentos", Inferencia.Executar},
                {"INTERPOLAÇÃO - Fundamentos", Interpolação.Executar},
                {"LENDO DADOS DO CONSOLE - Fundamentos", LendoDados.Executar},
                {"NOTAÇÃO PONTO - Fundamentos", NotacaoPonto.Executar},
                {"OPERADOR ARITIMETICO - Fundamentos", OperadorAritimeico.Executar},
                {"OPERADOR ATRIBUIÇÃO - Fundamentos", OperadorAtribuicao.Executar},
                {"OPERADOR LOGICO - Fundamentos", OperadorLogico.Executar},
                {"OPERADOR RELACIONAL - Fundamentos", OperadorRelacional.Executar},
                {"OPERADOR TERNARIO - Fundamentos", OperadorTernario.Executar},
                {"OPERADOR UNITARIO - Fundamentos", OperadorUnario.Executar },

                //Estruturas De Controle
                {"BREAK - Estruturas De Controle", Break.Executar },
                {"CONTINUE - Estruturas De Controle", Continue.Executar },
                {"ESTRUTURA DO WHILE - Estruturas De Controle", EstruturaDoWile.Executar },
                {"ESTRUTURA FOR - Estruturas De Controle", EstruturaFor.Executar },
                {"ESTRUTURA FOREACH - Estruturas De Controle", EstruturaForEach.Executar },
                {"ESTRUTURA IF - Estruturas De Controle", EstruturaIF.Executar },
                {"ESTRUTURA IF/ELSE - Estruturas De Controle", ExtruturaIfElse.Executar },
                {"ESTRUTURA IF/ELSEIF - Estruturas De Controle", EstruturaIfElseIf.Executar },
                {"ESTRUTURA SWITCH - Estruturas De Controle", EstruturaSwitch.Executar },
                {"ESTRUTURA WHILE - Estruturas De Controle", EstruturaWhile.Executar },

                //Classes E Metodos
                {"ATRIBUTOS ESTATICOS - Classes e Metodos", AtributosEstaticos.Executar },
                {"CONSTRUTORES - Classes e Metodos", Construtores.Executar },
                {"DESAFIO ATRIBUTOS - Classes e Metodos", DesafioAtributo.Executar },
                {"ENUNS - Classes e Metodos", Enumeradores.Executar },
                {"GET SET - Classes e Metodos", GetSet.Executar },
                {"MEMBROS - Classes e Metodos", Membros.Executar },
                {"MEMBROS COM RETORNO - Classes e Metodos", MetodosComRetorno.Executar },
                {"METODOS ESTATICOS - Classes e Metodos", MetodosEstaticos.Executar },
                {"PARAMS - Classes e Metodos", Params.Executar },
                {"PARAMETROS NOMEADOS - Classes e Metodos", ParmetrosNomeados.Executar },
                {"PARAMETROS PADRÃO - Classes e Metodos", ParametroPadrao.Executar },
                {"PARAMETROS POR REFERENCIA - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"PROPS - Classes e Metodos", Props.Executar },
                {"READONLY - Classes e Metodos", Readonly.Executar },
                {"STRUCT - Classes e Metodos", Struct.Executar },
                {"STRUCT VS CLASSES - Classes e Metodos", StructVsClasse.Executar },
                {"VALOR VS REFERENCIA - Classes e Metodos", ValorVsRerefencia.Executar },
               
                //Colecoes
                {"COLEÇÃO ARRAY - Coleções", ColecaoArray.Executar },
                {"COLEÇÃO ARRAY LIST - Coleções", ColecaoArrayList.Executar },
                {"COLEÇÃO DICTIONARY - Coleções", ColecaoDictionary.Executar },
                {"COLEÇÃO IGUALDADE - Coleções", ColecaoIgualdade.Executar },
                {"COLEÇÃO LIST - Coleções", ColecaoList.Executar },
                {"COLEÇÃO QUEUE - Coleções", ColecaoQueue.Executar },
                {"COLEÇÃO SET - Coleções", ColecaoSet.Executar },
                {"COLEÇÃO STACK - Coleções", ColecaoStack.Executar },
             
                //OO
                {"ABSTRATO - OO", Abstrato.Executar },
                {"CONSTRUTOR THIS - OO", ConstrutorThis.Executar },
                {"ENCAPSULAMENTO - OO", Encapsulamento.Executar },
                {"HERANÇA - OO", Heranca.Executar },
                {"INTERFACE - OO", Interface.Executar },
                {"POLIMORFISMO - OO", Polimorfismo.Executar },
                {"SEALED - OO", Sealed.Executar },
               
                //Metodos e Funções 
                {"DELEGATE COMO PARAMETROS - Metodos e Funções", DelegatesComoParametros.Executar },
                {"DELEGATE FUNC ANONIMA - Metodos e Funções", DelegateFuncAnonima.Executar },
                {"EXEMPLO LAMBDA - Metodos e Funções", ExemploLambda.Executar },
                {"LAMBDA DELEGATE - Metodos e Funções", LambdasDelegate.Executar },
                {"METODOS DE EXTENÇÃO - Metodos e Funções", MetodosDeExtensao.Executar },
                {"USANDO DELEGATE - Metodos e Funções", UsandoDelegate.Executar },
                
                //Exceções
                {"Primeira execao - Exceções", PrimeiraExcecao.Executar },
                {"Execoes Personalizadas - Exceções", ExecoesPersonalizadas.Executar },
                
                //API
                {"DIRETORIOS - Api", Diretorios.Executar },
                {"EXEMPLO DATA TIME - Api", ExemploDataTime.Executar },
                {"EXEMPLO DIRECTORY INFO - Api", ExemploDirectoryInfo.Executar },
                {"EXEMPLO FILE INFO - Api", ExemploFileInfo.Executar },
                {"EXEMPLO PATH - Api", ExemploPath.Executar },
                {"EXEMPLO TIMESPAN - Api", ExemploTimeSpan.Executar },
                {"LENDO ARQUIVOS - Api", LendoArquivos.Executar },
                {"PRIMEIRO ARQUIVO - Api", PrimeiroArquivo.Executar },

                //Topicos Avançados
                {"DYNAMICS - Topicos Avançados", Dynamics.Executar },
                {"GENERICOS - Topicos Avançados", Genericos.Executar },
                {"LINQ1 - Topicos Avançados", LINQ1.Executar },
                {"LINQ2 - Topicos Avançados", LINQ2.Executar },
                {"NULLABLES - Topicos Avançados", Nullables.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}