
# Teste NSTECH

API de autenticação desenvolvida utilizando o .NET 8 e Identity com rotas pré-definidas pelo mesmo, foi implementado um service de Email para que fosse possível o envio de código e link para confirmação.

DB: SQLServer Express (para teste, altere a "DefaultConnection" em appsettings.json para a string de conexão do seu DB)

Para que a questão do envio de email funcionasse, utilizei um server de SMTP local chamado smtp4dev, para executá-lo localmente, instale-o com o seguinte comando no shell:

dotnet tool install -g Rnwood.Smtp4dev

Para rodar o server execute:

smtp4dev

Assim será possível abrir o seu dashboard na porta mencionada na inicialização


PS: Achei que teria mais tempo mas não tive mais que poucas horas esse final de semana para realizar esse sistema, o Front não foi desenvolvido por esse motivo. Tentei inclusive fazer o mais compacto e específico possível nesse pouco tempo, sem me alongar em criar camadas em projetos diferentes, tentei deixar o mais organizado e de fácil manutenção possível no único projeto da Web Api.

Não sei se será possível avaliar minha experiência com um projeto simples desse, porém estou aberto para qualquer dúvida decorrente da mesma.