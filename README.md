
# Teste NSTECH

API de autentica��o desenvolvida utilizando o .NET 8 e Identity com rotas pr�-definidas pelo mesmo, foi implementado um service de Email para que fosse poss�vel o envio de c�digo e link para confirma��o.

DB: SQLServer Express (para teste, altere a "DefaultConnection" em appsettings.json para a string de conex�o do seu DB)

Para que a quest�o do envio de email funcionasse, utilizei um server de SMTP local chamado smtp4dev, para execut�-lo localmente, instale-o com o seguinte comando no shell:

dotnet tool install -g Rnwood.Smtp4dev

Para rodar o server execute:

smtp4dev

Assim ser� poss�vel abrir o seu dashboard na porta mencionada na inicializa��o


PS: Achei que teria mais tempo mas n�o tive mais que poucas horas esse final de semana para realizar esse sistema, o Front n�o foi desenvolvido por esse motivo. Tentei inclusive fazer o mais compacto e espec�fico poss�vel nesse pouco tempo, sem me alongar em criar camadas em projetos diferentes, tentei deixar o mais organizado e de f�cil manuten��o poss�vel no �nico projeto da Web Api.

N�o sei se ser� poss�vel avaliar minha experi�ncia com um projeto simples desse, por�m estou aberto para qualquer d�vida decorrente da mesma.