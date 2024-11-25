# Git

Download do [Git](https://git-scm.com/downloads)

Crie a pasta aonde os seus arquivos dos seus repositórios serão baixados para o seu computador.

Como exemplo, no meu caso eu criei uma pasta chamada Repos_Git dentro dos Meus Documentos.

Nesta pasta, clique com o botão direito. Dentre as opções exibidas, aparecerão estas:


Clique em Open Git Bash here

git config --global user.name "Seu nome de usuário"
Para saber o seu nome de usuário, vá até o seu perfil no [Github](https://github.com/) e clique na sua foto, no canto direito superior:

No meu caso, é Marco87.

Após configurar o seu user.name, digite o seguinte comando:
git config --global user.email "seu e-mail de cadastro"

Com estes passos, seus usuário já estará configurado. Para conferir se deu tudo certo, digite o seguinte comando:
git config --list

Você verá o seu user.name e o seu user.email com as informações do seu perfil.

Pronto! Seu usuário já está configurado e você já pode usar o git no seu computador.


Se você tentar clonar algum repositório, verá essa mensagem de erro:
SSL certificate problem: unable to get local issuer certificate

ssh-keygen -t rsa -b 4096 -C "sem e-mail de cadastro"




![image](https://github.com/user-attachments/assets/41c40bdb-2796-447d-9e34-ebc970612a08)
