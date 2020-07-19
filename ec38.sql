-- phpMyAdmin SQL Dump
-- version 4.9.5deb2~bpo10+1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jul 19, 2020 at 11:47 PM
-- Server version: 10.3.22-MariaDB-0+deb10u1
-- PHP Version: 7.3.19-1~deb10u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ec38`
--
CREATE DATABASE IF NOT EXISTS `ec38` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `ec38`;

-- --------------------------------------------------------

--
-- Table structure for table `delovni_nalogi`
--

CREATE TABLE IF NOT EXISTS `delovni_nalogi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `st_kosov` int(11) NOT NULL,
  `opis` varchar(30) NOT NULL,
  `opombe` varchar(50) DEFAULT NULL,
  `cas_narocila` datetime NOT NULL,
  `rok_konca` datetime NOT NULL,
  `narocnik` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `kosi`
--

CREATE TABLE IF NOT EXISTS `kosi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `delovni_nalog` int(11) NOT NULL,
  `cas_vnosa` datetime NOT NULL,
  `opombe` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `kosi` (`delovni_nalog`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `luknje`
--

CREATE TABLE IF NOT EXISTS `luknje` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kos_id` int(11) NOT NULL,
  `radij` int(11) NOT NULL,
  `center_x` int(11) NOT NULL,
  `center_y` int(11) NOT NULL,
  `ploscina` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `luknje` (`kos_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kosi`
--
ALTER TABLE `kosi`
  ADD CONSTRAINT `kosi` FOREIGN KEY (`delovni_nalog`) REFERENCES `delovni_nalogi` (`id`);

--
-- Constraints for table `luknje`
--
ALTER TABLE `luknje`
  ADD CONSTRAINT `luknje` FOREIGN KEY (`kos_id`) REFERENCES `kosi` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
