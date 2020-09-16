-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Set-2020 às 01:57
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastroclientes`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `dadosclientes`
--

CREATE TABLE `dadosclientes` (
  `nome` text NOT NULL,
  `cpf` int(11) NOT NULL,
  `rg` int(7) NOT NULL,
  `nasc` text NOT NULL,
  `sexo` text NOT NULL,
  `email` text NOT NULL,
  `celular` int(11) NOT NULL,
  `endereco` text NOT NULL,
  `bairro` text NOT NULL,
  `municipio` text NOT NULL,
  `cep` int(8) NOT NULL,
  `uf` text NOT NULL,
  `idCliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `dadosclientes`
--

INSERT INTO `dadosclientes` (`nome`, `cpf`, `rg`, `nasc`, `sexo`, `email`, `celular`, `endereco`, `bairro`, `municipio`, `cep`, `uf`, `idCliente`) VALUES
('Pedro Silva', 5596305, 3548627, '26/10/1990', 'Masculino', 'pedro@gmail.com', 2147483647, 'Rua das Flores', 'Centro', 'São José', 88989502, 'SC', 5);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `dadosclientes`
--
ALTER TABLE `dadosclientes`
  ADD PRIMARY KEY (`idCliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `dadosclientes`
--
ALTER TABLE `dadosclientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
