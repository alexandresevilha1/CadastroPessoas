using PFS_UC12___EncontroRemoto2.classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.Nome = "Alexandre";
novaPf.dataNasc = new DateTime(2000, 01, 01);
novaPf.Cpf = "1234567890";
novaPf.rendimento = 5000.5f;

novoEnd.logradouro = "Vicente de Caravalho";
novoEnd.numero = 305;
novoEnd.complemento = "rua 2";
novoEnd.endComercial = false;

novaPf.Endereco = novoEnd;

Console.WriteLine($"Nome:{novaPf.Nome}");
Console.WriteLine($"Cpf:{novaPf.Cpf}");
Console.WriteLine($"Endereco:{novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}");

Console.WriteLine(@$"
Nome: {novaPf.Nome}
CPF: {novaPf.Cpf}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
");


// novaPf.rendimento = 10000.5f;

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.rendimento}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Rendimento " + novaPf.rendimento);

// Console.WriteLine($"{novaPf.ValidarDataNasc(new DateTime(2010, 01, 01))}");

Console.WriteLine($"{novaPf.ValidarDataNasc("01/01/00")}");


PessoaJuridica metodoPJ = new PessoaJuridica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco endPJ = new Endereco();

novaPJ.Nome = "Nome PJ";
novaPJ.razaoSocial = "Razão social Pj";
novaPJ.Cnpj = "00.000.000/0001-00";
novaPJ.rendimento = 10000.5f;

endPJ.logradouro = "Endereço qualquer";
endPJ.numero = 157;
endPJ.complemento = "rua qualquer";
endPJ.endComercial = true;

novaPJ.Endereco = endPJ;

Console.WriteLine(@$"
Nome: {novaPJ.Nome}
Razão Social: {novaPJ.razaoSocial}
CNPJ: {novaPJ.Cnpj}
CNPJ Válido: {metodoPJ.ValidarCnpj(novaPJ.Cnpj)}

");



Console.WriteLine(metodoPJ.ValidarCnpj("00.000.000/00001-00"));



