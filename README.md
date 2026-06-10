# Teste DSIN - Dev.

**Nome:** Gabriel Trindade  
**Data:** 10/06/2026  
**Hora Início:** 19h  
**Hora Entrega:**  
**Vaga:** Desenvolvedor de Software Sênior

---

## Perfil

### A – Experiência em Desenvolvimento Web

Sim, possuo experiência em Desenvolvimento Web. Trabalho principalmente com C# e .NET (ASP.NET MVC, .NET Core, Blazor), JavaScript e React no front-end, além de Python com FastAPI. Ao longo da minha carreira, desenvolvi plataformas web modulares, APIs REST, automações de processos e sistemas full-stack, sempre com foco em escalabilidade e boas práticas de arquitetura.

### B – Experiência em Desenvolvimento Desktop

Não possuo experiência formal em Desenvolvimento Desktop. Minha atuação tem sido voltada principalmente para sistemas web, back-end e arquiteturas distribuídas.

### C – Experiência em Desenvolvimento Mobile

Não possuo experiência em Desenvolvimento Mobile nativo. Porém, já desenvolvi um PWA (Progressive Web App) — uma aplicação web responsiva e acessível via dispositivos móveis — além de soluções de chatbot voltadas para canais de atendimento ao cliente com uso em ambientes mobile.

### D – Experiência em Banco de Dados

Sim, possuo experiência com Banco de Dados. Trabalho principalmente com SQL Server, além de ter experiência com PostgreSQL, MySQL e Redis. Utilizei bancos de dados em diversos projetos ao longo da minha carreira, desde sistemas de gestão e automação de processos até aplicações com IA, onde também trabalhei com Vector Databases em pipelines RAG.

---

## Como executar

> Não é necessário ter .NET instalado — apenas Docker.

```bash
# Build
docker build -t dsin-logic-teste-grt .

# Executar (menu interativo)
docker run -it dsin-logic-teste-grt
```

O menu exibe todas as questões disponíveis. Digite o número da questão e interaja via terminal.

---

## Questões

### Questão 1 — Cálculo de Salário Líquido

> Faça um algoritmo que calcule o salário líquido de um trabalhador em função da quantidade de horas por dia, do preço da hora trabalhada e dos dias trabalhados no mês. Considerar um desconto de 3% sobre o salário bruto.

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao01.cs`](src/DsinLogicTesteGrt/Questoes/Questao01.cs)

---

### Questão 2 — Validação de Valores

> Faça um algoritmo que receba 4 valores inteiros A, B, C e D. Dados os valores, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B, e ainda, se ambos C e D forem positivos e A for par, escrever "Valores aceitos", se não escrever "Valores não aceitos".

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao02.cs`](src/DsinLogicTesteGrt/Questoes/Questao02.cs)

---

### Questão 3 — Decomposição em Notas

> Faça um algoritmo que receba um valor inteiro e calcule o menor número de notas possíveis no qual o valor pode ser decomposto (200, 100, 50, 20, 10, 5, 2 e 1).

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao03.cs`](src/DsinLogicTesteGrt/Questoes/Questao03.cs)

---

### Questão 4 — Equação AX + BX + C = 1

> Faça um algoritmo que receba 3 valores inteiros A, B e C e calcule o valor de X na expressão AX + BX + C = 1. Se A e B forem 0 e C diferente de 1, imprimir "solução impossível".

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao04.cs`](src/DsinLogicTesteGrt/Questoes/Questao04.cs)

---

### Questão 5 — Placa Mercosul

> Faça um algoritmo que receba uma placa e imprima qual o padrão (Brasil/Mercosul) e a versão correspondente no outro padrão.

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao05.cs`](src/DsinLogicTesteGrt/Questoes/Questao05.cs)

---

### Questão 6 — Sequência de 1 a N

> Construa um algoritmo que recebe N e gera uma sequência de 1 a N avaliando: número perfeito, múltiplo de 3, múltiplo de 5, raiz quadrada inteira.

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao06.cs`](src/DsinLogicTesteGrt/Questoes/Questao06.cs)

---

### Questão 7 — Título Centralizado e Formatado

> Escreva um programa que imprima um título formatado e centralizado recebido em 2 partes (superior e inferior).

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao07.cs`](src/DsinLogicTesteGrt/Questoes/Questao07.cs)

---

### Questão 8 — Matriz Caracol

> Elabore um algoritmo que construa uma matriz quadrada de tamanho N em formato de caracol.

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao08.cs`](src/DsinLogicTesteGrt/Questoes/Questao08.cs)

---

### Questão 9 — SQL: Alternativas Corretas

```sql
SELECT CDCLICODIGO, CDCLINOME, CDCLICEP
FROM CDCLIENTE
WHERE CDCLIBAIRRO = 'PACARAIMA' AND
(
    (CDCLIUF = 'ES' AND CDCLICIDADE = 'PORTO DE MOZ')
    OR
    (CDCLIUF = 'DF' AND CDCLICIDADE = 'URUARA')
)
```

**[X]** Será retornado o código, o nome e o CEP dos clientes que moram no bairro PACARAIMA e, são da cidade PORTO DE MOZ do estado do Espírito Santos **ou** são da cidade URUARA do Distrito Federal.

**[ ]** ~~Será retornado o código, o nome e o CEP dos clientes que moram no bairro PACARAIMA e são da cidade PORTO DE MOZ do estado do Espírito Santos **e** são da cidade URUARA do Distrito Federal.~~ — Incorreta: o operador entre os grupos é `OR`, não `AND`. Um cliente não pode estar em duas cidades ao mesmo tempo.

**[X]** Será retornado o código, o nome e o CEP dos clientes que moram no bairro PACARAIMA e, são da cidade URUARA do Distrito Federal **ou** são da cidade PORTO DE MOZ do estado do Espírito Santos. — Correta: mesma lógica da primeira, com a ordem das cidades invertida (`OR` é comutativo).

**[ ]** ~~Será retornado o código, o nome, o CEP **e a data de nascimento**...~~ — Incorreta: o `SELECT` não retorna data de nascimento.

---

### Questão 10 — DER (Diagrama Entidade Relacionamento)

**A) Relacionamento entre CDCLIENTE → LCATENDIMENTO:**

**[X] 0:N (Zero a muitos)** — Um cliente pode existir sem nenhum atendimento (mínimo = 0), mas pode ter vários ao longo do tempo (máximo = N).

**B) Afirmações corretas:**

**[ ]** ~~Um cliente pode ser atendido por um funcionário que não possua um nome cadastrado~~ — `CPFNOME` é `NOT NULL`, portanto todo funcionário deve ter nome.

**[ ]** ~~Nenhum atendimento pode possuir a mesma data e hora~~ — Não há constraint `UNIQUE` em `LCADATAHORIATEND`.

**[ ]** ~~Um cliente pode ser atendido sem um funcionário~~ — `LCAFUNCIONARIO` é `NOT NULL`, logo é obrigatório.

**[X]** Um cliente pode ser atendido por vários funcionários, sendo um funcionário por vez. — Cada registro em `LCATENDIMENTO` tem um único `LCAFUNCIONARIO`, mas um cliente pode ter múltiplos registros.

**[X]** Todo atendimento requer que exista um cliente e um funcionário cadastrado previamente. — `LCACLIENTE` e `LCAFUNCIONARIO` são ambos `NOT NULL` e FKs.

---

### Questão 11 — Consultas SQL

**A) Clientes que não foram atendidos:**

```sql
SELECT C.CDCLINOME
FROM CDCLIENTE C
LEFT JOIN LCATENDIMENTO L ON C.CDCLICODIGO = L.LCACLIENTE
WHERE L.LCACLIENTE IS NULL
```

**B) Funcionários e quantidade de atendimentos (incluindo zero):**

```sql
SELECT F.CPFNOME, COUNT(L.LCAFUNCIONARIO) AS QUANTIDADE
FROM CDFUNCIONARIO F
LEFT JOIN LCATENDIMENTO L ON F.CDFCODIGO = L.LCAFUNCIONARIO
GROUP BY F.CDFCODIGO, F.CPFNOME
```

**C) Clientes atendidos no 1º bimestre ou 2º semestre de 2011:**

```sql
SELECT C.CDCLINOME, L.LCADATAHORIATEND
FROM CDCLIENTE C
INNER JOIN LCATENDIMENTO L ON C.CDCLICODIGO = L.LCACLIENTE
WHERE
    (L.LCADATAHORIATEND >= '2011-01-01' AND L.LCADATAHORIATEND < '2011-03-01')
    OR
    (L.LCADATAHORIATEND >= '2011-07-01' AND L.LCADATAHORIATEND < '2012-01-01')
```

---

### Questão 12 — Programe um Pato

Implementado em [`src/DsinLogicTesteGrt/Questoes/Questao12.cs`](src/DsinLogicTesteGrt/Questoes/Questao12.cs)

---

### Questão 13 — Gestão de Prazo

Ao perceber que o primeiro relatório consumiu 6 dos 10 dias disponíveis, essa situação já teria sido comunicada à gestão durante o desenvolvimento — não apenas ao final. A decisão de dedicar mais tempo ao relatório 1 teria sido tomada em conjunto, reconhecendo que ele era o de maior prioridade ou complexidade.

Com 4 dias restantes e mais 2 relatórios de complexidade similar, somados aos 3 dias exigidos pelo setor de testes, a entrega completa dentro do prazo original não é viável. Nesse cenário, as ações seriam:

1. **Comunicar imediatamente a gestão** com transparência sobre a situação, apresentando os números reais: tempo restante vs. esforço necessário.
2. **Priorizar junto à gestão** quais dos dois relatórios restantes têm maior impacto para a reunião do cliente, garantindo que o mais crítico seja entregue primeiro.
3. **Avaliar a possibilidade de alocação de mais pessoas** — com a ressalva de que isso só funciona se o conhecimento necessário for transferível. Onboarding emergencial pode custar mais tempo do que economiza.
4. **Negociar o prazo ou o escopo** com o cliente se necessário, sendo franco: é melhor alinhar expectativas do que entregar algo incompleto ou com qualidade comprometida.

A base de tudo é **transparência e comunicação proativa** — o problema não surge no dia 6, ele é gerenciado desde o início.

---

### Questão 14 — Análise de Impacto de Alteração

**A) Análise para auxiliar o suporte:**

- Identificar em quais relatórios a divergência ocorre e quais campos estão envolvidos.
- Verificar **quando** começou — se coincide com a data da atualização, já é um forte indicador.
- Checar se há padrão: apenas clientes que passaram a omitir os campos opcionais após a atualização.
- Comparar registros pré e pós atualização para entender se produtos sem categoria, descrição ou grupo estão sendo ignorados ou mal calculados nos relatórios.

**B) Diagnóstico e ações:**

O diagnóstico mais provável é que os relatórios foram construídos assumindo esses campos sempre preenchidos — em joins, agrupamentos ou filtros. Ao se tornarem opcionais, produtos cadastrados sem esses dados passaram a ser contabilizados incorretamente.

**Ações:**

1. Investigar o histórico de commits para rastrear exatamente o que foi alterado.
2. Revisar as queries dos relatórios verificando dependência dos campos agora opcionais.
3. Corrigir tratando nulos — `COALESCE`, filtros explícitos ou ajuste na lógica de agrupamento.
4. Avaliar com o negócio se faz sentido manter os campos opcionais ou reverter a decisão.
5. Comunicar os clientes com transparência sobre o problema e prazo de correção.

**Reflexão além do problema imediato:**

Ao receber essa demanda, o ideal teria sido questionar o porquê da obrigatoriedade original. Mas na prática, nem sempre o desenvolvedor tem esse contexto — especialmente em sistemas legados onde as decisões não foram documentadas. Isso evidencia algo maior: a importância de manter documentação viva e decisões registradas, para que qualquer desenvolvedor consiga entender o impacto antes de alterar uma regra de negócio. Não basta questionar — é preciso ter onde buscar a resposta. Cada alteração como essa deveria gerar um registro da decisão tomada, para que o próximo desenvolvedor não precise descobrir o impacto 40 dias depois através de um chamado de suporte.

---
