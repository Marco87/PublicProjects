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


