<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Guia de Configuração do Git</title>
</head>
<body>
    <h1>Guia de Configuração do Git</h1>

    <p>🖥️ Download do <a href="https://git-scm.com/downloads" target="_blank">Git</a></p>
    <p>🎨 Editor de <a href="https://readme.so/" target="_blank">README</a></p>
    <p>📂 Documentação do <a href="https://git-scm.com/docs/git/pt_BR" target="_blank">Git</a></p>

    <details>
        <summary><strong>Configurando o Git na sua máquina (Windows)</strong></summary>
        <p>Crie a pasta onde os seus arquivos dos seus repositórios serão baixados para o seu computador. Como exemplo, no meu caso, eu criei uma pasta chamada <strong>Repos_Git</strong> dentro dos Meus Documentos.</p>
        <p>Nesta pasta, clique com o botão direito. Dentre as opções exibidas, aparecerão estas:</p>
        <img src="https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8" alt="Menu de opções do Git">
        <p>Você pode clicar em <strong>Abrir no Terminal</strong> ou <strong>Open Git Bash here</strong>. Neste exemplo, usaremos a segunda opção.</p>
        <p>Digite o comando abaixo:</p>
        <pre><code>git config --global user.name "Seu nome de usuário"</code></pre>
        <p>Para saber o seu nome de usuário, vá até o seu perfil no <a href="https://github.com/" target="_blank">GitHub</a> e clique na sua foto, no canto direito superior:</p>
        <img src="https://github.com/user-attachments/assets/5b3e103f-8268-463a-8e34-9242e488031b" alt="Perfil do GitHub">
        <p>No meu caso, é <strong>Marco87</strong>.</p>
        <p>Após configurar o seu <code>user.name</code>, digite o seguinte comando:</p>
        <pre><code>git config --global user.email "seu e-mail de cadastro"</code></pre>
        <p>Com estes passos, seu usuário já estará configurado. Para conferir se deu tudo certo, digite o seguinte comando:</p>
        <pre><code>git config --list</code></pre>
        <p>Você verá o seu <code>user.name</code> e o seu <code>user.email</code> com as informações do seu perfil.</p>
        <p>Pronto! Seu usuário já está configurado e você já pode usar o Git no seu computador.</p>
    </details>

    <details>
        <summary><strong>Configurando o SSH na sua máquina (Windows)</strong></summary>
        <p>Navegue até a pasta onde o seu repositório está instalado e clique com o botão direito. Dentre as opções exibidas, aparecerão estas:</p>
        <img src="https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8" alt="Menu de opções do Git">
        <p>Você pode clicar em <strong>Abrir no Terminal</strong> ou <strong>Open Git Bash here</strong>. Neste exemplo, usaremos a segunda opção.</p>
        <p>Digite o comando abaixo:</p>
        <pre><code>ssh-keygen -t rsa -b 4096 -C "seu e-mail de cadastro"</code></pre>
        <p>Agora navegue até a sua pasta de usuários no Windows e entre na pasta <strong>.ssh</strong>. Este caminho normalmente é o seguinte: <code>C:\Users(ou Usuários)\Seu usuário\.ssh</code></p>
        <p>Esta pasta terá dois arquivos chamados <strong>id_rsa</strong>. Abra o arquivo com a extensão <strong>.pub</strong> e copie todo o código.</p>
        <p>Vá até o seu repositório <a href="https://github.com/" target="_blank">GitHub</a> e clique na sua foto, na parte superior esquerda. No menu que se abrir, clique em <strong>Settings</strong>.</p>
        <img src="https://github.com/user-attachments/assets/cc030b92-7b28-474f-848c-ebece66758ec" alt="Menu de configurações do GitHub">
        <p>Clique em <strong>SSH and GPG keys</strong></p>
        <img src="https://github.com/user-attachments/assets/b11d905b-b0ba-4832-901e-4c4c3b5476f4" alt="Opção de SSH and GPG keys">
        <p>Clique em <strong>New SSH key</strong></p>
        <img src="https://github.com/user-attachments/assets/1d0c2006-be03-42a4-9370-a8aff512d71a" alt="Opção de adicionar nova SSH key">
        <p>Defina um título para a sua chave e copie o código do arquivo <strong>id_rsa</strong> na caixa de texto <strong>key</strong>.</p>
        <img src="https://github.com/user-attachments/assets/d1526128-caab-4a28-abc0-f822077fdcc5" alt="Exemplo de adição de chave SSH">
        <p>Confirme a operação clicando no botão <strong>Add SSH key</strong>.</p>
        <p>Para testar se a operação teve êxito, vá até um de seus repositórios no seu <a href="https://github.com/" target="_blank">GitHub</a> (de preferência um que você queira baixar para o seu computador). Clique no botão <strong>Code</strong>, clique em <strong>SSH</strong> e copie o atalho que aparecer.</p>
        <img src="https://github.com/user-attachments/assets/f0b67473-23bc-4237-ab1a-90271ec798b5" alt="Opção para copiar o atalho SSH">
        <p>Agora vá até a pasta com os seus repositórios do Git e clique com o botão direito.</p>
        <img src="https://github.com/user-attachments/assets/dea9a0f1-8557-497a-ae62-d00457ba7ef8" alt="Menu de opções do Git">
        <p>Selecione <strong>Open Git Bash here</strong> e digite o comando abaixo no terminal:</p>
        <pre><code>git clone atalho_que_você_copiou</code></pre>
        <p>Se as configurações estiverem corretas, o seu repositório do GitHub será sincronizado com a sua máquina local.</p>
    </details>
</body>
</html>
