# Projeto Contratos - Web Api

Projeto desenvolvido em .NET 5.0, API rest.

O projeto conta com Swagger para que todas as requisições que possam ser feitas sejam visiveis.

O InMemoryDb foi usado como banco de dados.

Aplicados princípios SOLID e Clean Code.

Testes unitários com nUnit para validar regra do campo status da prestação.

Foram criados repositórios e serviços genéricos.

Usando InMemoryCache, que funciona como um cache direto na memória, ou seja, se a aplicação for reiniciada ou parada esse cache é perdido. Há também como configurar o cache para ter um determinado tempo de vida.

Usando Feature Flags, que são configurações que permitem que você altere comportamentos ou "features" da aplicação sem a necessidade de reinicia-la.
