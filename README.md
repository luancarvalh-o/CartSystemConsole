# CartSystem

Este projeto é um sistema simples de carrinho de compras desenvolvido em C# com foco em prática de conceitos fundamentais de programação.
Feito para treinar:
* Programação Orientada a Objetos
* Encapsulamento
* Uso de coleções

## Estrutura do Projeto

```
CartSystem/
│
├── Program.cs
│
├── Models/
│   ├── Product.cs
│   ├── ItemCart.cs
│   └── Cart.cs
│
├── Services/
│   ├── CartService.cs
│   └── DiscountService.cs
│
└── Data/
    └── Data.cs
```

## Funcionalidades

* Listar produtos disponíveis
* Adicionar produtos ao carrinho
* Criar novos produtos automaticamente caso não existam
* Remover produtos do carrinho
* Visualizar itens do carrinho
* Calcular total da compra
* Aplicar desconto no checkout

## Como Executar

1. Clone o repositório:

```
git clone https://github.com/seu-usuario/shopping-cart.git
```

2. Acesse a pasta do projeto:

```
cd CartSystem
```

3. Execute o projeto:

```
dotnet run
```

## Exemplo de Uso

```
1 - List Products
2 - Add to Cart
3 - View Cart
4 - Remove Product
5 - Checkout
0 - Exit
```

## Regras do Sistema

* Produtos com o mesmo nome são agrupados no carrinho
* A quantidade é somada se o produto já existir
* Não é permitido adicionar quantidade menor ou igual a zero
* Produtos novos são criados automaticamente ao serem adicionados
