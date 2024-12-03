# Git

🖥️Download do [Git](https://git-scm.com/downloads)

🎨Editor de [README](https://readme.so/)

📂Documentação do [Git](https://git-scm.com/docs/git/pt_BR)


<details>
<summary><strong>Configurando o Git na sua máquina (Windows)</strong></summary>
Crie a pasta aonde os seus arquivos dos seus repositórios serão baixados para o seu computador.
Como exemplo, no meu caso eu criei uma pasta chamada Repos_Git dentro dos Meus Documentos.

Nesta pasta, clique com o botão direito. Dentre as opções exibidas, aparecerão estas:

![image](https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8)

Você pode clicar em **Abrir no Terminal** ou  **Open Git Bash here**. Neste exemplo usaremos a segunda opção.

Digite o comando abaixo:

```git config --global user.name "Seu nome de usuário"```

Para saber o seu nome de usuário, vá até o seu perfil no [GitHub](https://github.com/) e clique na sua foto, no canto direito superior:
![image](https://github.com/user-attachments/assets/5b3e103f-8268-463a-8e34-9242e488031b)

No meu caso, é **Marco87**.

Após configurar o seu user.name, digite o seguinte comando:

```git config --global user.email "seu e-mail de cadastro"```

Com estes passos, seus usuário já estará configurado. Para conferir se deu tudo certo, digite o seguinte comando:

```git config --list```

Você verá o seu user.name e o seu user.email com as informações do seu perfil.

Pronto! Seu usuário já está configurado e você já pode usar o git no seu computador.

</details>

<details>
<summary><strong>Configurando o SSH na sua máquina (Windows)</strong></summary>

Navegue até a pasta onde o seu repositório está instalado e clique com o botão direito. Dentre as opções exibidas, aparecerão estas:

![image](https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8)

Você pode clicar em **Abrir no Terminal** ou  **Open Git Bash here**. Neste exemplo usaremos a segunda opção.

Digite o comando abaixo:

```ssh-keygen -t rsa -b 4096 -C "sem e-mail de cadastro"```

Agora navegue até a sua pasta de usuários no Windows e entre na pasta **.ssh**. Este caminho normalmente é o seguinte: C:\Users(ou Usuários)\Seu usuário\.ssh

Esta pasta terá dois arquivos chamados **id_rsa**. Abra o arquivo com a extensão **.pub** e copie todo o código.

Vá até o seu repositório [GitHub](https://github.com/) e clique na sua foto, na parte superior esquerda. No menu que se abrir, clique em **Settings**.

![image](https://github.com/user-attachments/assets/cc030b92-7b28-474f-848c-ebece66758ec)

Clique em **SSH and GPG keys**

![image](https://github.com/user-attachments/assets/b11d905b-b0ba-4832-901e-4c4c3b5476f4)

Clique em **New SSH key**

![image](https://github.com/user-attachments/assets/1d0c2006-be03-42a4-9370-a8aff512d71a)

Defina um título para a sua chave e copie o código do arquivo **id_rsa** na caixa de texto **key**.

![image](https://github.com/user-attachments/assets/d1526128-caab-4a28-abc0-f822077fdcc5)

Confirme a operação clicando no botão **Add SSH key**.

Para testar se a operação teve êxito, vá até um de seus repositórios no seu [GitHub](https://github.com/) (de preferência um que você queira baixar para o seu computador). Clique no botão **Code**, clique em **SSH** e copie o atalho que aparecer.

![image](https://github.com/user-attachments/assets/f0b67473-23bc-4237-ab1a-90271ec798b5)


Agora vá até a pasta com os seus repositórios do git e clique com o botão direito.

![image](https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8)

Selecione **Open Git Bash here** e digite o comando abaixo no terminal:

```git clone atalho_que_você_copiou```

Se as configurações estiverem corretas, o seu repositório do GitHub será sincronizado com a sua máquina local.

</details>


<details>
<summary><strong>Criando o fork de um repositório</strong></summary>

Fork é a cópia de um repositório, e esta prática permite modificações de código independente do projeto original. É bastante usado para colaboração, testes e contribuições de projetos de código aberto.

Os passos são bem simples. Vá até o repositório que você deseja criar o fork. Neste exemplo eu estou no GitHub da [Microsoft](https://github.com/microsoft), e vou simular um fork no repositório do [VS Code](https://github.com/microsoft/vscode).

Na tela do repositório, procure pelo botão **Fork** e clique sobre ele.
![image](https://github.com/user-attachments/assets/d0225c8a-621f-4e74-ba1a-6a3bb67c4b84)

Uma tela como a imagem abaixo será carregada:
![image](https://github.com/user-attachments/assets/9ac39464-10fb-4350-83a9-e5cba7be57bb)


Note que é possível você alterar o nome e a descrição do repositório que serão criados no seu perfil.

Clique em **Create fork** para confirmar a operação.
</details>

<details>
<summary><strong>Criando uma página no GitHub Pages</strong></summary>

O GitHub Pages é o serviço de hospedagem do GitHub. Por ele é possível publicar sites por meio de arquivos HTML, CSS e JavaScript diretamente de um repositório.

É possível utilizar um repositório existente ou criar um novo para esta finalidade. Neste exemplo criaremos um novo.

***Se você já tem um repositório, ignore os próximos passos. Mais adiante avisarei de onde você pode prosseguir***

No seu [GitHub](https://github.com/), clique na sua foto de perfil, na parte superior à direita, e clique em **Your Repositories**.

(Lembrando que há outros caminhos para a criação de um novo repositório. Sinta-se à vontade para usar qualquer um deles)

![image](https://github.com/user-attachments/assets/14f1f4f1-ea00-4f4e-9974-c2edcb818ffe)

Na tela que aparecer, clique em **New**

![image](https://github.com/user-attachments/assets/8771e8c3-b2fe-4948-9700-1b46a5f96ea4)

Vou nomear o meu repositório como **site_exemplo** e deixa-lo **Public**. Você pode nomear o seu repositório com um nome que reflita o site que você vai hospedar.

![image](https://github.com/user-attachments/assets/933997ef-ea90-4925-bd94-c218984bc3f3)

Clique em **Create repository**.

Seu repositório está criado. Agora nós vamos carregar uma página simples em HTML. 

Copie o código abaixo:

```
<html>
  <head><title>Título do meu site</title></head>
  <body>Meu site no GitHub</body>
</html>
```

Agora salve com o nome **index.html**, e em tipo marque a opção **Todos os arquivos**.

![image](https://github.com/user-attachments/assets/7f213ac3-312d-4ddf-92ea-1a61fd63f5b4)

Volte ao seu repositório e clique em **uploading an existing file** para carregar o arquivo que você acabou de criar.

![image](https://github.com/user-attachments/assets/8f7a842f-167a-40f4-9b97-25d4f904205c)

Você vai notar que o seu repositório passara a ter o arquivo **site.html**.

![image](https://github.com/user-attachments/assets/74b1114a-c47c-483f-8647-b920659bdffb)


***Para você que já tem um repositório, pode começar a partir daqui***

Agora vamos dar forma ao nosso site.

Clique em **Settings**

![image](https://github.com/user-attachments/assets/f12e0765-e519-4ccf-a86f-5d6f159a3b52)

Na sessão **Code and automation**, clique em **Pages**.

![image](https://github.com/user-attachments/assets/3ef0856e-143b-42c6-9dea-50c89ac561b2)

Em **Build and deployment**, na sessão **branch**, selecione a opção **main*** (normalmente a opção None vem selecionada por padrão) e ao lado selecione a opção **root** caso esta ainda não esteja marcada.

Clique em **Save**.

![image](https://github.com/user-attachments/assets/6660c946-746c-4a48-a2e9-a1efbc8f9feb)

Será gerada uma url com domínio **github.io**. Pode ser que demorem alguns minutos.

Quando o processo estiver pronto, você verá uma mensagem como esta, no topo da sua página:

![image](https://github.com/user-attachments/assets/2326f271-bd76-415b-9515-32ce22a1223d)

Se mesmo após a url ser gerada a mensagem de erro aparecer, é porque o seu site ainda está sendo publicado. Em breve ele estará disponível.

![image](https://github.com/user-attachments/assets/95511f78-0bde-406a-9c34-4a161429b244)

</details>
