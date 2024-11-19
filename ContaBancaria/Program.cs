using ContaBancaria;

ContaPoupanca poupanca = new ContaPoupanca("Vinicius", 10000000, 1.2);
ContaCorrente corrente = new ContaCorrente("Thulio", 1, 1);

GestaoConta gestao = new GestaoConta();
gestao.Adicionar(poupanca);
gestao.Adicionar(corrente);

poupanca.Transferir(10, corrente);

gestao.Listar();