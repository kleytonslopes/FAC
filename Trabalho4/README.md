
### Cadastro de Colaboradores


 ![Step1](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step1.png)

![Step2](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step2.png)

![Step3](https://raw.githubusercontent.com/kleytonslopes/FAC/master/Trabalho4/step3.png)

----------

#### Regras de Negócio:

-   Campo **Empresa**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 100 Caracteres
    
-   Campo **Filial**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 100 Caracteres
    
-   Campo **Nome Completo**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Data de Nascimento**
    
    -   Tipo `date`
        
    -   Obrigatório
        
    -   Não aceitar a data maior que a Atual
    
-   Campo **Nacionalidade**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 50 Caracteres
    
-   Campo **Grau de Instrução**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 100 Caracteres
    
-   Campo **Nome da Mãe**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Numero de Dependentes**
    
    -   Tipo `number`
        
    -   Aceitar apenas Numeros
        
    -   Limite de 3 Digitos
    
-   Campo **Estado civil**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 50 Caracteres
    
-   Campo **CPF**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Aceitar apenas Numeros
        
    -   Mascara `###.###.###-##`
        
    -   Limite de 14 Caracteres
    
-   Campo **Nome do Cônjuge**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Numero de Filhos**
    
    -   Tipo `number`
        
    -   Aceitar apenas Numeros
        
    -   Limite de 3 Digitos
    
-   Campo **Endereço**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Numero** (**_Nº_**)
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Aceitar Numeros e Letras
        
    -   Limite de 20 Caracteres
    
-   Campo **Bairro**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Município**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **UF**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Aceitar apenas Letras
        
    -   Limite de 2 Caracteres
    
-   Campo **CEP**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Aceitar apenas Numeros
        
    -   Mascara `#####-###`
        
    -   Limite de 9 Caracteres
    
-   Campo **Fone Residencial**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Aceitar apenas Numeros
        
    -   Mascara `(##) ####-####`
        
    -   Limite de 14 Caracteres
    
-   Campo **Fone Celular**
    
    -   Tipo `text`
        
    -   Aceitar apenas Numeros
        
    -   Mascara `(##) #-####-####`
        
    -   Limite de 16 Caracteres
    
-   Campo **Naturalidade**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 50 Caracteres
    
-   Campo **Numero de Serie**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Limite de 100 Caracteres
    
-   Campo **Data de Expedição**
    
    -   Tipo `date`
        
    -   Obrigatório
        
    -   Não aceitar a data maior que a Atual
    
-   Campo **Nº da carteira de Identidade**
    
    -   Tipo `number`
        
    -   Obrigatório
        
    -   Aceitar apenas Numeros
        
    -   Limite de 20 Digitos
    
-   Campo **Data de Emissão**
    
    -   Tipo `date`
        
    -   Obrigatório
        
    -   Não aceitar a data maior que a Atual
    
-   Campo **Órgão emissor**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 10 Caracteres
    
-   Campo **Nome do Pai**
    
    -   Tipo `text`
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Departamento**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Função**
    
    -   Tipo `text`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Horário de trabalho**
    
    -   Tipo `time`
        
    -   Obrigatório
        
    -   Upercase
        
    -   Limite de 150 Caracteres
    
-   Campo **Salário inicial**
    
    -   Tipo `number`
        
    -   Obrigatório
        
    -   Mascara `###.###.###,##`
        
    -   Limite de 14 Caracteres
    
-   Campo **Sexo**
    
    -   Tipo `radio`
        
    -   Obrigatório
        
    -   Valores `Masculino`, `Feminino` e `Outro`
        
    -   Permitiro a seleção de apenas uma opção
    
-   Campo **Primeiro emprego?**
    
    -   Tipo `checkbox`
        
    -   Valor `Sim`
