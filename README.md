Sistema Interativo com Coleta de Itens e Persistência de Dados (C#)

Projeto desenvolvido em C# com foco em lógica de sistemas interativos,
manipulação de estado, eventos e persistência de dados via I/O.

Embora implementado em Unity, o foco principal do projeto está na
estrutura de código, organização e lógica.

Funcionalidades Principais

Interface do Usuário (UI)
- Exibição dinâmica da pontuação
- Contador de tempo de execução da aplicação
- Botões de ação:
  - Salvar estado
  - Carregar estado
  - Resetar dados

Persistência de Dados (I/O)
- Salvamento de dados via leitura e escrita em arquivos
- Dados persistidos:
  - Posição do usuário (Vector3)
  - Pontuação
- Uso da pasta `StreamingAssets/Data`

  Sistema de Itens
- Itens configuráveis por variáveis:
  - Cor
  - Escala
  - Valor de pontuação
- Detecção de colisão baseada em eventos
- Ação automática ao ser coletado (destruição + atualização de estado)

Gerenciamento de Pontuação
- Sistema centralizado de score
- Atualização em tempo real via UI
- Pontuações positivas e negativas


Tecnologias e Conceitos
- Linguagem: C#
- Programação orientada a objetos
- Eventos e detecção de colisão
- Gerenciamento de estado
- Entrada e saída de arquivos (I/O)
- Organização modular de código
- UI reativa

  

Objetivo do Projeto
Projeto acadêmico desenvolvido para praticar conceitos fundamentais
de desenvolvimento de software, como lógica, persistência de dados,
interação com o usuário e organização de sistemas.

Observação
Este repositório contém apenas os scripts principais do projeto,
com foco em análise de código. Não é necessário instalar Unity
para leitura e compreensão.
