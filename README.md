# ExercicioVisitor - Gerador de Relatórios de Monitoramento Ambiental

Este projeto aplica o padrão de projeto **Visitor** para resolver a necessidade de gerar diferentes formatos de saída para os dados coletados pelas PCDs (Plataformas de Coleta de Dados) na Amazônia. 

Este exercício é uma continuação da linha de raciocínio dos projetos anteriores, focando agora em como adicionar novas operações a uma estrutura de objetos existente sem precisar modificá-la.

## O Problema
No nosso sistema de monitoramento, temos diferentes classes de dados (como `RegistroTemperatura` e `RegistroPH`). Com o tempo, surgiu a necessidade de exportar esses dados de várias formas: um relatório formatado para humanos (**PDF**) e um formato para integração entre sistemas (**JSON**).

Se colocássemos a lógica de exportação dentro das classes de dados, elas ficariam "poluídas" e difíceis de manter. O **Visitor** resolve isso separando o algoritmo de formatação da estrutura do objeto.

## Arquitetura da Solução:

O padrão foi implementado seguindo a estrutura discutida em aula:

1.  **IVisitor**: Interface que define o contrato de "visita" para cada tipo de dado.
2.  **IRegistro**: Interface que define o método `Aceitar(IVisitor visitor)`, permitindo o Double Dispatch.
3.  **Elementos Concretos (`Registros.cs`)**: Classes `RegistroTemperatura` e `RegistroPH`. Elas apenas guardam os dados e aceitam o visitante.
4.  **Visitantes Concretos (`Relatorios.cs`)**: 
    - `RelatorioPDFVisitor`: Implementa a lógica de formatação em texto amigável (simulando um PDF).
    - `RelatorioJSONVisitor`: Implementa a lógica de formatação em chaves e valores (padrão JSON).

## Por que usar Visitor aqui?
A principal vantagem aplicada neste exercício foi o princípio de **Aberto/Fechado (OCP)**. 
- **Aberto para extensão:** Se o professor pedir para gerar um relatório em XML ou CSV, basta eu criar uma nova classe de Visitor.
- **Fechado para modificação:** Eu nunca mais precisarei mexer nas classes de Temperatura ou PH para adicionar novos formatos de relatório.

## Como Executar:
O repositório contém o arquivo `.csproj`, então é só colocar no terminal:
```bash
dotnet run
