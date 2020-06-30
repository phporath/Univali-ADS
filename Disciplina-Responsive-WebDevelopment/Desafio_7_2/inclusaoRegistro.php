$PDO = conecta_bd(); => OU OUTRO NOME DE FUNÇÃO DE CONEXÃO INFORMADA PELO ALUNO
$sql = "INSERT INTO produtos(descricao_produto,preco_produto) VALUES(:descricao_produto,:preco_produto)";
$stmt = $PDO->prepare($sql); 
$stmt->bindParam(':descricao_produto', $descricao_produto);
$stmt->bindParam(':preco_produto ', $preco_produto);
if ($stmt->execute())
    {
        header('Location: form_inclui.php'); => OU OUTRO NOME DE FORMULÁRIO INFORMADO PELO ALUNO
    }
    else
    {
        echo "Ocorreu um erro na inclusão de registro";
        print_r($stmt->errorInfo());
    }