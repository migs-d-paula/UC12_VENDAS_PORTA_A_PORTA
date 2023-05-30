-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30/05/2023 às 03:22
-- Versão do servidor: 10.4.22-MariaDB
-- Versão do PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `porta_a_porta`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cadastro_clientes`
--

CREATE TABLE `cadastro_clientes` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `cpf` varchar(50) NOT NULL,
  `telefone` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `cadastro_produtos`
--

CREATE TABLE `cadastro_produtos` (
  `id` int(11) NOT NULL,
  `produto` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `senha` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `login`
--

INSERT INTO `login` (`id`, `usuario`, `senha`) VALUES
(1, 'MIGUEL', '13032006');

-- --------------------------------------------------------

--
-- Estrutura para tabela `vendas`
--

CREATE TABLE `vendas` (
  `id` int(11) NOT NULL,
  `fk_produto` int(11) NOT NULL,
  `fk_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `vendas_realizadas`
--

CREATE TABLE `vendas_realizadas` (
  `id` int(11) NOT NULL,
  `fk_vendas` int(11) NOT NULL,
  `hora` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cadastro_clientes`
--
ALTER TABLE `cadastro_clientes`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `cadastro_produtos`
--
ALTER TABLE `cadastro_produtos`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `vendas`
--
ALTER TABLE `vendas`
  ADD KEY `vendas_cliente` (`fk_cliente`),
  ADD KEY `vendas_produto` (`fk_produto`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_clientes`
--
ALTER TABLE `cadastro_clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cadastro_produtos`
--
ALTER TABLE `cadastro_produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `vendas`
--
ALTER TABLE `vendas`
  ADD CONSTRAINT `vendas_cliente` FOREIGN KEY (`fk_cliente`) REFERENCES `cadastro_clientes` (`id`),
  ADD CONSTRAINT `vendas_produto` FOREIGN KEY (`fk_produto`) REFERENCES `cadastro_produtos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
