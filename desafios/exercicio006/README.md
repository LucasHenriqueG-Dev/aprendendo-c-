# Exercício 006 - Two Sum (LeetCode #1)

Assunto: vetores e laços aninhados  
Status: concluído

## Enunciado

Dado um vetor de inteiros `nums` e um inteiro `target`, retorne os índices dos dois números cuja soma seja igual a `target`.

Considere que cada entrada tem exatamente uma solução e que não é possível usar o mesmo elemento duas vezes. A resposta pode ser retornada em qualquer ordem.

| Entrada | Saída | Explicação |
|---|---|---|
| `nums = [2,7,11,15]`, `target = 9` | `[0,1]` | `nums[0] + nums[1] == 9` |
| `nums = [3,2,4]`, `target = 6` | `[1,2]` | `nums[1] + nums[2] == 6` |
| `nums = [3,3]`, `target = 6` | `[0,1]` | `nums[0] + nums[1] == 6` |

Restrições: `2 <= nums.length <= 10⁴`, `-10⁹ <= nums[i] <= 10⁹`, `-10⁹ <= target <= 10⁹` e existe apenas uma resposta válida.

Desafio extra: dá para fazer um algoritmo com complexidade menor que O(n²)?

Tirado do [LeetCode](https://leetcode.com/problems/two-sum/)

## O que pratiquei

- Laços `for` aninhados para comparar pares de elementos
- Começar o segundo laço em `i + 1` para não repetir pares nem usar o mesmo elemento duas vezes

## Como rodar

```bash
cd desafios/exercicio006
dotnet run
```

## Solução

[Program.cs](./Program.cs)

---

[voltar para o início](../../README.md)
