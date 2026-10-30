# Exercício 007 - Sistema de Eleição

Assunto: vetores paralelos e validação de entrada  
Status: concluído

## Enunciado

Faça um programa em C# para uma eleição de **N candidatos**.

**Requisitos:**

- `N` deve estar entre **5 e 10**;
- cada candidato deve possuir nome, número, votos e idade.

**Funcionalidades:**

- a) armazenar os dados dos `N` candidatos;
- b) registrar os votos dos `N` eleitores;
- c) definir os candidatos vencedores:
  - por quantidade de votos;
  - em caso de empate, o candidato de maior idade será o vencedor.

## O que pratiquei

- Validação de entrada com `while`
- Vetores paralelos (nome, número, idade e votos na mesma posição)
- Contagem de votos brancos (0) e nulos (número que não existe)
- Busca do maior valor com critério de desempate

## Como rodar

```bash
cd desafios/exercicio007
dotnet run
```

## Solução

[Program.cs](./Program.cs)

---

[voltar para o início](../../README.md)
