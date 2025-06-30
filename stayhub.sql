-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 26-Jun-2025 às 04:59
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `stayhub`
--
CREATE DATABASE IF NOT EXISTS `stayhub` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `stayhub`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `financeiro_entrada`
--

CREATE TABLE IF NOT EXISTS `financeiro_entrada` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `hospede` varchar(100) NOT NULL,
  `quarto` varchar(20) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `forma_pagamento` varchar(50) NOT NULL,
  `data_cadastro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `idx_data` (`data`),
  KEY `idx_hospede` (`hospede`),
  KEY `idx_quarto` (`quarto`),
  KEY `idx_forma_pagamento` (`forma_pagamento`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Extraindo dados da tabela `financeiro_entrada`
--

INSERT INTO `financeiro_entrada` (`id`, `data`, `hospede`, `quarto`, `valor`, `forma_pagamento`, `data_cadastro`, `data_atualizacao`) VALUES
(1, '2024-01-15', 'João Silva', '101', '150.00', 'Cartão de Crédito', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(2, '2024-01-16', 'Maria Santos', '102', '180.00', 'Dinheiro', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(3, '2024-01-17', 'Pedro Costa', '103', '200.00', 'PIX', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(4, '2024-01-18', 'Ana Oliveira', '201', '160.00', 'Cartão de Débito', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(5, '2024-01-19', 'Carlos Ferreira', '202', '190.00', 'Cartão de Crédito', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(6, '2024-01-20', 'Lucia Pereira', '203', '170.00', 'PIX', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(7, '2024-01-21', 'Roberto Lima', '301', '220.00', 'Dinheiro', '2025-06-26 02:32:24', '2025-06-26 02:32:24'),
(8, '2024-01-22', 'Fernanda Rocha', '302', '185.00', 'Cartão de Crédito', '2025-06-26 02:32:24', '2025-06-26 02:32:24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `financeiro_saida`
--

CREATE TABLE IF NOT EXISTS `financeiro_saida` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `descricao` text NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `data_cadastro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `idx_data` (`data`),
  KEY `idx_descricao` (`descricao`(100))
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `hospedes`
--

CREATE TABLE IF NOT EXISTS `hospedes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `rg` varchar(20) DEFAULT NULL,
  `endereco` varchar(150) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `data_nascimento` date DEFAULT NULL,
  `genero` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE IF NOT EXISTS `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `descricao` text,
  `categoria` varchar(50) NOT NULL,
  `data_cadastro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `idx_categoria` (`categoria`),
  KEY `idx_nome` (`nome`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `nome`, `preco`, `quantidade`, `descricao`, `categoria`, `data_cadastro`, `data_atualizacao`) VALUES
(1, 'Toalha de Banho', '25.90', 50, 'Toalha de banho 100% algodão, tamanho padrão', 'Roupas de Cama', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(2, 'Sabonete Líquido', '8.50', 100, 'Sabonete líquido para banheiro, 500ml', 'Higiene', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(3, 'Papel Higiênico', '12.00', 200, 'Papel higiênico folha dupla, 30m', 'Higiene', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(4, 'Café em Pó', '15.90', 30, 'Café em pó tradicional, 500g', 'Alimentos', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(5, 'Leite Condensado', '4.50', 40, 'Leite condensado, 395g', 'Alimentos', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(6, 'Detergente Líquido', '6.80', 25, 'Detergente líquido para louça, 500ml', 'Limpeza', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(7, 'Desinfetante', '9.90', 35, 'Desinfetante com fragrância, 1L', 'Limpeza', '2025-06-26 02:24:01', '2025-06-26 02:24:01'),
(8, 'Lâmpada LED', '18.50', 60, 'Lâmpada LED 9W, equivalente a 60W', 'Iluminação', '2025-06-26 02:24:01', '2025-06-26 02:24:01');

-- --------------------------------------------------------

--
-- Estrutura da tabela `quartos`
--

CREATE TABLE IF NOT EXISTS `quartos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numero` varchar(10) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `numero_camas` int(11) NOT NULL,
  `capacidade` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `numero` (`numero`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `quartos`
--

INSERT INTO `quartos` (`id`, `numero`, `tipo`, `preco`, `numero_camas`, `capacidade`, `created_at`, `updated_at`) VALUES
(1, '101', 'Simples', '250.00', 1, 2, '2025-06-26 03:18:26', '2025-06-26 03:19:21'),
(2, '202', 'Deluxe', '400.00', 2, 4, '2025-06-26 03:18:26', '2025-06-26 03:19:21'),
(3, '201', 'Executivo', '350.00', 1, 2, '2025-06-26 03:18:26', '2025-06-26 03:19:21');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE IF NOT EXISTS `servicos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `preco` decimal(10,2) NOT NULL,
  `descricao` text,
  `data_criacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `idx_nome` (`nome`),
  KEY `idx_categoria` (`categoria`),
  KEY `idx_preco` (`preco`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=21 ;

--
-- Extraindo dados da tabela `servicos`
--

INSERT INTO `servicos` (`id`, `nome`, `categoria`, `preco`, `descricao`, `data_criacao`, `data_atualizacao`) VALUES
(1, 'Limpeza de Quarto', 'Limpeza', '25.00', 'Serviço de limpeza diária do quarto', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(2, 'Lavanderia', 'Lavanderia', '15.00', 'Lavagem e passagem de roupas', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(3, 'Room Service', 'Alimentação', '35.00', 'Serviço de refeições no quarto', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(4, 'Wi-Fi Premium', 'Internet', '10.00', 'Acesso à internet de alta velocidade', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(5, 'Estacionamento', 'Estacionamento', '20.00', 'Vaga de estacionamento coberta', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(6, 'Academia', 'Lazer', '15.00', 'Acesso à academia do hotel', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(7, 'Piscina', 'Lazer', '0.00', 'Acesso gratuito à piscina', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(8, 'Spa', 'Bem-estar', '80.00', 'Sessão de spa e massagem', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(9, 'Transfer Aeroporto', 'Transporte', '50.00', 'Serviço de transfer do aeroporto', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(10, 'Guia Turístico', 'Turismo', '100.00', 'Serviço de guia turístico local', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(11, 'Aluguel de Bicicleta', 'Lazer', '25.00', 'Aluguel de bicicleta para passeios', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(12, 'Serviço de Babá', 'Cuidados', '30.00', 'Serviço de babá para crianças', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(13, 'Pet Friendly', 'Animais', '20.00', 'Taxa para hospedagem com animais', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(14, 'Cofre', 'Segurança', '5.00', 'Aluguel de cofre no quarto', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(15, 'Serviço de Concierge', 'Atendimento', '0.00', 'Serviço de concierge gratuito', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(16, 'Business Center', 'Negócios', '15.00', 'Acesso ao centro de negócios', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(17, 'Serviço de Valet', 'Estacionamento', '25.00', 'Serviço de valet parking', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(18, 'Serviço de Táxi', 'Transporte', '0.00', 'Chamada de táxi gratuita', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(19, 'Serviço de Limpeza Seca', 'Lavanderia', '45.00', 'Limpeza a seco de roupas', '2025-06-26 02:35:45', '2025-06-26 02:35:45'),
(20, 'Serviço de Cabeleireiro', 'Beleza', '60.00', 'Serviço de cabeleireiro no hotel', '2025-06-26 02:35:45', '2025-06-26 02:35:45');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `rg` varchar(20) DEFAULT NULL,
  `endereco` varchar(150) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `data_nascimento` date DEFAULT NULL,
  `cargo` varchar(50) DEFAULT NULL,
  `senha` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `cpf` (`cpf`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `cpf`, `rg`, `endereco`, `complemento`, `telefone`, `celular`, `data_nascimento`, `cargo`, `senha`) VALUES
(1, 'admin', 'admin@gmail.com', '111.111.111-11', '111111111', 'baker street', '221b', NULL, '11999999999', '2000-05-11', 'Administrador', 'admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
