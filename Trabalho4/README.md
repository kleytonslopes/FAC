
### Cadastro de Colaboradores


 ![Step1](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step1.png)

![Step2](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step2.png)

![Step3](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step3.png)

----------

#### Regras de Negócio:

| Nome do Campo                | Tipo     | Regras                                                       | Obrigatório |
| ---------------------------- | -------- | ------------------------------------------------------------ | ----------- |
| Empresa                      | text     | Upercase.<br />100 Caracteres Limites.                       | Sim         |
| Filial                       | text     | Upercase.<br />Limite de 100 Caracteres.                     | Sim         |
| Nome Completo                | text     | Upercase.<br />Limite de 150 Caracteres.                     | Sim         |
| Data de Nascimento           | date     | Não aceitar a data maior que a Atual.                        | Sim         |
| Nacionalidade                | text     | Upercase.<br />Limite de 50 Caracteres.                      | Sim         |
| Grau de Instrução            | text     | Upercase.<br />Limite de 100 Caracteres.                     | Não         |
| Nome da Mãe                  | text     | Upercase.<br />Limite de 150 Catacteres.                     | Sim         |
| Numero de Dependentes        | number   | Aceitar apenas Numeros.<br />Limite de 3 Digitos.            | Não         |
| Estado Civil                 | text     | Upercase.<br />Limite de 50 Caracteres.                      | Não         |
| CPF                          | text     | Aceita apenas Numeros.<br />Limite de 14 Caracteres.<br />Utiliza a Mascara. `###.###.###-##` | Sim         |
| Nome do Cônjuge              | text     | Upercase.<br />Limite de 150 Caracteres.<br />Inicia desabilitado, e é habilitado quando o Estado Civil for Casado. | Não         |
| Numero de Filhos             | number   | Aceitar apenas Numeros.<br />Limite de 3 Digitos.            | Não         |
| Endereço                     | text     | Upercase.<br />Limite de 150 Caracteres.<br />Inicia desabilitado, e é habilitado quando o CEP não é encontrado. | Sim         |
| Numero                       | text     | Upercase.<br />Aceita apenas numeros e Letras.<br />Limite de 20 Caracteres. | Sim         |
| Bairro                       | text     | Upercase.<br />Limite de 150 Caracteres.<br />Inicia desabilitado, e é habilitado quando o CEP não é encontrado. | Sim         |
| Município                    | text     | Upercase.<br />Limite de 150 Caracteres.<br />Inicia desabilitado, e é habilitado quando o CEP não é encontrado. | Sim         |
| UF                           | text     | Upercase.<br />Aceita apenas Letras<br />Limite de 2 Caracteres.<br />Inicia desabilitado, e é habilitado quando o CEP não é encontrado. | Sim         |
| CEP                          | text     | Aceita apenas Numeros.<br />Utiliza a Mascara `#####-###`<br />Limite de 9 Caracteres.<br />Preenche os campos, Municipio, Bairro, UF e Endereço consumindo uma API (viacep).<br />Caso o CEP não seja encontrado na API, libera os campos para preenchimento manual. | Sim         |
| Fone Residencial             | text     | Aceita apenas Numeros.<br />Utiliza a Mascara `(##) ####-####`<br />Limite de 14 Caracteres. | Sim         |
| Fone Celular                 | text     | Aceita apenas Numeros.<br />Utiliza a Mascara `(##) #-####-####`.<br />Limite de 16 Caracteres. | Não         |
| Naturalidade                 | text     | Upercase.<br />Limite de 50 Caracteres.                      | Não         |
| Numero de Serie              | text     | Limite de 100 Caracteres.                                    | Sim         |
| Data de Expedição            | date     | Não aceitar a data maior que a atual.                        | Sim         |
| Nº da carteira de Identidade | number   | Aceita aepnas Numero.<br />Limite de 20 Digitos.             | Sim         |
| Data de Emissão              | date     | Não aceitar a data maior que a Atual.                        | Sim         |
| Órgão Emissor                | text     | Upercase.<br />Limite de 10 Caracteres.                      | Sim         |
| Nome do Pai                  | text     | Upercase.<br />Limite de 150 Caracteres.                     | Não         |
| Departamento                 | text     | Upercase.<br />Limite de 150 Caracteres.                     | Sim         |
| Função                       | text     | Upercase.<br />Limite de 150 Caracteres.                     | Sim         |
| Horário de trabalho          | time     | Aceita apenas Numeros.<br />Utiliza a Mascara `##:##`,<br />Limite de 6 Caracteres. | Sim         |
| Salário Iinicial             | number   | Aceita apenas Numeros.<br />Utiliza a Mascara `###.###.###,##`<br />Limite de 14 Caracteres | Sim         |
| Sexo                         | select   | Upercase.<br />Conter as Opções: OUTRO, MASCULINO, FEMININO.<br />Permitir apenas a seleção de uma opção | Sim         |
| Primeiro Emprego             | checkbox | Ter a descrição "Sim"                                        | Não         |
|                              |          |                                                              |             |
