-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 05, 2023 at 05:24 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `date_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `USERNAME` varchar(12) NOT NULL,
  `PASSWORD` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`USERNAME`, `PASSWORD`) VALUES
('ada', 'ada'),
('admin', 'admin'),
('admin2', 'admin2'),
('jihan', 'jihan');

-- --------------------------------------------------------

--
-- Table structure for table `identitas`
--

CREATE TABLE `identitas` (
  `ID` int(4) NOT NULL,
  `NIK` int(17) NOT NULL,
  `NAMA` varchar(50) NOT NULL,
  `TANGGAL` datetime NOT NULL,
  `JUMLAH_JIWA` int(3) NOT NULL,
  `KUALITAS` int(5) NOT NULL,
  `TOTAL` float NOT NULL,
  `PEMBAYARAN` float NOT NULL,
  `KEMBALIAN` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `identitas`
--

INSERT INTO `identitas` (`ID`, `NIK`, `NAMA`, `TANGGAL`, `JUMLAH_JIWA`, `KUALITAS`, `TOTAL`, `PEMBAYARAN`, `KEMBALIAN`) VALUES
(12127, 90911191, 'Restu', '2023-04-02 19:06:22', 2, 15000, 60000, 250000, 190000),
(12130, 90912876, 'Azrul', '2023-04-29 09:35:39', 6, 30000, 774000, 800000, 26000),
(12131, 90912551, 'Jihan', '2023-04-03 09:36:11', 7, 25000, 752500, 800000, 47500),
(12132, 90912550, 'Ayu Aria', '2023-04-04 10:27:48', 4, 15000, 120000, 500000, 380000),
(12137, 90912550, 'Ayu Aria3', '2023-04-08 10:51:55', 1, 15000, 30000, 80000, 50000),
(12138, 12, 'ad', '2023-05-05 20:29:26', 1, 12000, 0, 60000, 60000);

-- --------------------------------------------------------

--
-- Table structure for table `jenis`
--

CREATE TABLE `jenis` (
  `jenis` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jenis`
--

INSERT INTO `jenis` (`jenis`) VALUES
(12000),
(15000),
(20000),
(25000),
(30000),
(35000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`USERNAME`);

--
-- Indexes for table `identitas`
--
ALTER TABLE `identitas`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `identitas`
--
ALTER TABLE `identitas`
  MODIFY `ID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12139;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
