-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2024 at 01:34 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `finals`
--

-- --------------------------------------------------------

--
-- Table structure for table `addbooks`
--

CREATE TABLE `addbooks` (
  `ID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Upload` date NOT NULL,
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addbooks`
--

INSERT INTO `addbooks` (`ID`, `Title`, `Author`, `Upload`, `Status`) VALUES
(1, 'Atomic Habits', 'James Clear', '2024-07-03', 'Available'),
(2, 'Democracy', 'John Dewey', '2024-07-03', 'Available'),
(3, 'The Alchemist', 'Paulo Coelho', '2024-07-11', 'Available'),
(4, 'Savage Inqualities', 'Jonathan Kozol', '2024-07-03', 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `issued`
--

CREATE TABLE `issued` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Contact` int(100) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `issued`
--

INSERT INTO `issued` (`ID`, `Name`, `Contact`, `Title`, `Author`, `Date`, `Status`) VALUES
(1, 'Patriz', 2147483647, 'Atomic Habits', 'James Clear', '2024-07-03', 'Borrowed'),
(2, 'Patriz', 2147483647, 'Democracy', 'John Dewey', '2024-07-18', 'Returned');

-- --------------------------------------------------------

--
-- Table structure for table `loginusers`
--

CREATE TABLE `loginusers` (
  `Name` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loginusers`
--

INSERT INTO `loginusers` (`Name`, `Username`, `Password`) VALUES
('Patriz', 'pat', 'patriz');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addbooks`
--
ALTER TABLE `addbooks`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `issued`
--
ALTER TABLE `issued`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addbooks`
--
ALTER TABLE `addbooks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `issued`
--
ALTER TABLE `issued`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
