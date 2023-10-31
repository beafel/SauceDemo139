Feature: Selecionar Produto na Loja

  @Compra
  Scenario: Selecao de Produto com Sucesso
    Given que acesso a pagina inicial do site
    When preencho o usuario como "standard_user"
    And a senha "sauce_secret" e clico no botão Login
    Then exibe "Products" no titulo da secao
    When adiciono o produto "Sauce Labs Backpack" ao carrinho
    And clico no icone do carrinho de compras
    Then verifico o titulo da secao "Your Cart"
    And a quantidade "1"
    And o produto "Sauce Labs Backpack"
    And o valor "$29.99"
