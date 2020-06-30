<?php
    header('Content-type: text/json');
    $retorno = array();
    switch($_POST['uf'])
    {
        case 1: //Paraná
            $retorno = array(11 => "Curitiba", 12 =>"Foz do Iguaçu", 13 => "Ponta Grossa", 14 => "Maringá");
        break;
        case 2: //São Paulo
            $retorno = array(21 => "São Paulo", 22 =>"Santo André", 23 => "São Bernardo", 24 => "São Caetano");
        break;
        case 3: //Rio de Janeiro
            $retorno = array(31 => "Rio de Janeiro", 32 =>"Angra dos Reis", 33 => "Niterói", 34 => "Terezópolis");
        break;
        case 4: //Minas Gerais
            $retorno = array(41 => "Três Corações", 42 =>"Diamantina", 43 => "Ouro Negro", 44 => "Belo Horizonte");
        break;
    }
        echo json_encode($retorno);
?>