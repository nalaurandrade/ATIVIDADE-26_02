using Faturamento;
using System;

Cliente _cliente;
_cliente = new Cliente();

_cliente.Nome = "João";
_cliente.Cpf = "56646";
_cliente.Status = "Ativo";

Console.Write(_cliente.Nome);

Console.Read();

Cliente _cliente2 = new Cliente();

_cliente2 = _cliente;

Console.Write(_cliente2.Nome);