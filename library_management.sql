-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2024 at 11:41 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `ID` int(11) NOT NULL,
  `BookTitle` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `TotalCopies` int(11) NOT NULL,
  `Published` datetime NOT NULL,
  `Status` varchar(50) NOT NULL,
  `DataInsert` datetime NOT NULL,
  `DateDelete` datetime DEFAULT NULL,
  `DateUpdate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`ID`, `BookTitle`, `Author`, `TotalCopies`, `Published`, `Status`, `DataInsert`, `DateDelete`, `DateUpdate`) VALUES
(1, 'The Way of Masculine ', 'Joe Rogan', 26, '2021-01-28 22:24:26', 'Available', '2024-06-11 22:24:32', NULL, '2024-06-21 16:50:31'),
(2, '1984', 'George Orwell', 13, '1948-02-11 00:11:53', 'Available', '2024-06-12 00:12:23', NULL, '2024-06-21 16:50:23'),
(3, '48 Laws of Power', 'Robert Green', 8, '2024-06-12 00:17:06', 'Available', '2024-06-12 00:17:45', NULL, '2024-06-21 16:50:14'),
(5, 'Brothers Karamazov', 'Fedor Dostoevsky', 4, '1890-02-22 09:16:29', 'Available', '2024-06-13 09:17:59', NULL, '2024-06-21 12:52:53'),
(6, 'Rich Dad Poor Dad', 'Robert', 5, '2015-02-26 12:08:37', 'Available', '2024-06-21 12:09:24', NULL, NULL),
(7, 'To Kill a Mockingbird', 'Harper Lee', 0, '2000-02-02 12:49:40', 'Not Available', '2024-06-21 12:50:12', NULL, NULL),
(8, 'Never Split the Difference: Negotiating As If Your Life Depended On It', 'Chris Voss', 7, '2010-07-25 21:48:21', 'Available', '2024-06-23 21:49:00', NULL, NULL),
(9, 'Napoleon Hill\'s Path to Purpose', 'Napoleon Hill', 6, '2000-11-16 21:50:01', 'Available', '2024-06-23 21:54:40', NULL, NULL),
(10, 'The Art of Seduction', 'Robert Green', 1, '2001-07-06 21:54:41', 'Available', '2024-06-23 21:59:11', NULL, NULL),
(11, 'Meditations', 'Mark Avreliy', 0, '1753-12-23 08:05:40', 'Not Available', '2024-06-24 08:06:49', NULL, '2024-06-24 23:55:26');

-- --------------------------------------------------------

--
-- Table structure for table `booksregistrations`
--

CREATE TABLE `booksregistrations` (
  `ID` int(11) NOT NULL,
  `BookID` int(11) DEFAULT NULL,
  `ClientID` int(11) DEFAULT NULL,
  `RegistrationDate` datetime DEFAULT NULL,
  `ReturnDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `booksregistrations`
--

INSERT INTO `booksregistrations` (`ID`, `BookID`, `ClientID`, `RegistrationDate`, `ReturnDate`) VALUES
(1, 1, 1, '2024-06-21 17:18:00', '2024-06-25 00:04:01'),
(2, 7, 2, '2024-06-21 17:18:13', NULL),
(3, 2, 1, '2024-06-23 20:37:54', '2024-06-24 10:44:39'),
(4, 7, 3, '2024-06-23 20:56:24', '2024-07-05 20:56:07'),
(5, 10, 5, '2024-06-23 22:39:33', '2024-06-29 22:39:17'),
(6, 9, 4, '2024-06-23 22:39:44', '2024-06-25 00:25:30'),
(7, 11, 5, '2024-06-24 08:07:51', '2024-08-18 08:07:36'),
(8, 7, 6, '2024-06-24 23:55:58', '2024-06-28 23:55:40');

-- --------------------------------------------------------

--
-- Table structure for table `borrowedbookviewmodel`
--

CREATE TABLE `borrowedbookviewmodel` (
  `ID` int(11) NOT NULL,
  `ClientName` varchar(255) NOT NULL,
  `BookTitle` varchar(255) NOT NULL,
  `RegistrationDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `ID` int(11) NOT NULL,
  `FullName` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Contact` varchar(255) NOT NULL,
  `DateRegistered` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ID`, `FullName`, `Email`, `Contact`, `DateRegistered`) VALUES
(1, 'Mitko Mitchev', 'MitkoBombata@gmail.com', '0897911802', '0001-01-01 00:00:00'),
(2, 'Rashko Putev', 'RashkoSkalata@abv.bg', '0888888', '2024-06-21 16:50:56'),
(3, 'Waleed', 'Waleedkata@abv.bg', '0888888888', '2024-06-23 20:52:49'),
(4, 'Baldwin IV', 'Balduinkata@abv.bg', '0111111111', '2024-06-23 22:00:12'),
(5, 'Halil Pasha', 'Pashata@abv.bg', '555566666', '2024-06-23 22:00:44'),
(6, 'Emo Shaib', 'EMkata@abv.bg', '0236666', '2024-06-24 08:07:21');

-- --------------------------------------------------------

--
-- Table structure for table `issues`
--

CREATE TABLE `issues` (
  `id` int(11) NOT NULL,
  `issue_id` varchar(255) DEFAULT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `contact` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `book_title` varchar(255) DEFAULT NULL,
  `author` varchar(255) DEFAULT NULL,
  `status` varchar(255) NOT NULL,
  `issue_date` datetime DEFAULT NULL,
  `return_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `issues`
--

INSERT INTO `issues` (`id`, `issue_id`, `full_name`, `contact`, `email`, `book_title`, `author`, `status`, `issue_date`, `return_date`) VALUES
(1, 'AHSGD', 'Test Name', 'Test Contact', 'suleyman17nn@gmail.com', 'The Way of Masculine ', 'Joe Rogan', 'Return', '2024-06-13 01:57:36', '2024-06-15 01:57:36'),
(2, 'AHSGI55', 'Test Name2', 'Test Contact', 'suleyman17nn@gmail.com', 'The Way of Masculine ', 'Joe Rogan', 'Return', '2024-06-13 01:57:36', '2024-06-15 01:57:36');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `date_register` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `username`, `password`, `date_register`) VALUES
(1, 'marto@gmail.com', 'marto', 'marto123', '2024-06-06 09:43:17'),
(2, 'suleyman17nn@gmail.com', 'sulman', 'sulman', '2024-06-06 10:37:37'),
(3, 'daniLudiq123', 'bahtiludiq', 'ludiq', '2024-06-13 09:15:55'),
(4, '11111', '1111', '1111', '2024-06-19 15:31:32');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `booksregistrations`
--
ALTER TABLE `booksregistrations`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `BookID` (`BookID`),
  ADD KEY `ClientID` (`ClientID`);

--
-- Indexes for table `borrowedbookviewmodel`
--
ALTER TABLE `borrowedbookviewmodel`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `issues`
--
ALTER TABLE `issues`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `booksregistrations`
--
ALTER TABLE `booksregistrations`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `issues`
--
ALTER TABLE `issues`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `booksregistrations`
--
ALTER TABLE `booksregistrations`
  ADD CONSTRAINT `booksregistrations_ibfk_1` FOREIGN KEY (`BookID`) REFERENCES `books` (`ID`),
  ADD CONSTRAINT `booksregistrations_ibfk_2` FOREIGN KEY (`ClientID`) REFERENCES `clients` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
