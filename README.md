# Controle de Estoque (WinForms, .NET Framework 4.8)

Aplicativo desktop MDI para gestão de estoque, com cadastros base e validações de negócio, utilizando SQL Server.

## Funcionalidades

- Cadastro de Produtos
  - Campos: nome, descrição, foto, unidade de medida, categoria, subcategoria, preço de venda.
  - Validações de negócio na inclusão/alteração (ex.: campos obrigatórios, preço > 0).
- Cadastros base
  - Categorias e Subcategorias
  - Unidades de Medida
- Consultas e seleção
  - Telas de consulta/seleção (pop-ups) para categorias e subcategorias.
- Configuração de Banco de Dados
  - Tela para configurar servidor, banco, usuário e senha.
  - Persistência em `system.config` (um valor por linha: Servidor, Banco, Usuário, Senha).
  - Teste de conexão automático ao iniciar.
- Interface
  - Padrão MDI (múltiplas janelas).
  - Formulário base de cadastro com controle de botões e estados (Inserir, Alterar, Excluir, Salvar, Cancelar).

## Arquitetura em camadas

- `GUI`: Windows Forms (MDI), formulários de cadastro/consulta.
- `Business`: regras de negócio e validações (ex.: `BusinessProduto`).
- `DAL`: acesso a dados e conexão (`DALConexao`, `DALProduto`).
- `Modelo`: entidades de domínio (ex.: `ModelProduto`).
- `Utils`: utilitários de UI e enums.

## Pré-requisitos

- Windows e Visual Studio 2022
- .NET Framework 4.7.2
- SQL Server (Express/Developer) acessível

## Como executar

1. Abra a solução no Visual Studio.
2. Defina o projeto `GUI` como inicial (__Set as Startup Project__).
3. Compile a solução (__Build Solution__).
4. Execute (__Start Debugging__).
5. Configure o banco em Configuração > Banco de Dados e salve (gera o arquivo `system.config`).
6. Use os menus para acessar:
   - Cadastros: Categoria, Subcategoria, Unidade de Medida, Produto.
   - Consultas (pop-ups) para apoio ao cadastro.

## Observações

- As imagens de produto são armazenadas em bytes.
- Mensagens de validação são retornadas pela camada de negócio via exceções.
- Recomenda-se ignorar `system.config` no controle de versão (adicionar ao `.gitignore`).

## Estrutura

- `GUI/`
- `Business/`
- `DAL/`
- `Modelo/`
- `Utils/`
