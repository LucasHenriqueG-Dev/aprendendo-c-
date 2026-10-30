# Exercício 005 - Análise de Vetor

Assunto: vetores (arrays)  
Status: concluído

## Enunciado

Uma empresa deseja analisar uma sequência de valores registrados durante um determinado período. Para isso, foi desenvolvido um programa em C# que permite ao usuário informar a quantidade de valores que serão analisados e, em seguida, armazená-los em um vetor.

Depois de preencher o vetor, o usuário informa um valor X. O programa deve:

- a) contar quantos valores do vetor são maiores que X;
- b) contar quantos valores são menores que X;
- c) contar quantos valores são iguais a X;
- d) percorrer o vetor desde o primeiro elemento, realizando a soma dos valores, até que a soma seja maior ou igual a X;
- e) informar quantas posições do vetor foram necessárias para atingir o valor X.

## O que pratiquei

- Criação e preenchimento de vetores com `for`
- Contadores
- Laço `for` com condição de parada composta (`i < v.Length && soma < x`)

## Como rodar

```bash
cd desafios/exercicio005
dotnet run
```

## Solução

[Program.cs](./Program.cs)

---

[voltar para o início](../../README.md)
