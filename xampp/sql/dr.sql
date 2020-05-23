-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2020 at 06:52 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dr`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `all user` ()  BEGIN
	SELECT * FROM user;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `check user` (IN `Prs_cod` INT, IN `Pasc` INT)  BEGIN
DECLARE temp int ;
if EXISTS (SELECT * from user where pr_cod = Prs_cod) THEN
	SELECT pass into temp from user where pr_cod = Prs_cod;
    if temp = Pasc then
    	SELECT 'successfuly' as message;
        
     ELSE
        SELECT 'wrong user or pass' as message;
        
     end if;
end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `check_sync` (IN `dep_id` INT, IN `mach_id` INT)  BEGIN
SELECT id from syncdepmach WHERE departeman_id = dep_id AND machin_id = mach_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count departeman` ()  NO SQL
BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM departman as message;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count machine` ()  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM machine as message;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count_test` (IN `machine_id` INT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM tests WHERE machine = machine_id;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count_tests_users` ()  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM tests_users ;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count_test_all` ()  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM tests;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `count_user` ()  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM user;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `departman id` (IN `dep_name` TEXT)  BEGIN
DECLARE temp text ;

SELECT id INTO temp FROM departman WHERE departman = dep_name;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `departman name` (IN `id_dep` INT)  BEGIN
DECLARE temp text ;

SELECT departman INTO temp FROM departman WHERE id = id_dep;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `edit_answer` (IN `test_idd` INT, IN `user_idd` INT, IN `date_id` DATETIME, IN `user_answ` TEXT)  BEGIN
UPDATE `tests_users` SET `date`=date_id,`user_answer`=user_answ WHERE test_id = test_idd and user_id = user_idd;
SELECT 'edit successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `get_test` (IN `test_id` INT)  BEGIN
SELECT * from tests WHERE id = test_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_departman` (IN `dep_name` TEXT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM departman;
INSERT INTO `departman`(`id`, `departman`) VALUES (temp,dep_name);
SELECT 'create successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_machine` (IN `machine_name` TEXT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM machine;
INSERT INTO `machine`(`id`, `machine`) VALUES (temp,machine_name);
SELECT 'create successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_sync_dep_mach` (IN `dep_id` INT, IN `machin_id` INT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM syncdepmach;
INSERT INTO `syncdepmach`(`id`, `departeman_id`, `machin_id`) VALUES (temp,dep_id,machin_id);
SELECT 'create successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_test` (IN `name_qus` TEXT, IN `machine_id` INT, IN `qus` TEXT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM tests;
INSERT INTO `tests`(`id`, `name`, `machine`, `question`) VALUES (temp,name_qus,machine_id,qus);
SELECT 'create successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_user` (IN `Pr_cod` INT, IN `Pass` INT, IN `Permission` INT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM user;
INSERT INTO `user`(`id`, `pr_cod`, `pass`, `permission`) VALUES (temp,Pr_cod,Pass,Permission);
SELECT 'create successfull' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_users_answ` (IN `Test_id` INT, IN `User_id` INT, IN `Date` DATETIME, IN `User_answer` TEXT)  BEGIN
DECLARE temp int ;
SELECT COUNT(id) INTO temp FROM tests_users ;
INSERT INTO `tests_users`(`id`,`test_id`,`user_id`,`date`,`user_answer`) VALUES (temp,Test_id,User_id,Date,User_answer);
SELECT 'ok' as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `lastlogin` (IN `lastlogin` DATETIME, IN `pr_code` INT)  BEGIN
UPDATE `user` set `last_login`= lastlogin WHERE pr_cod=pr_code;
#SELECT lastlogin as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `machine id` (IN `machine_id` TEXT)  BEGIN
DECLARE temp text ;

SELECT id INTO temp FROM machine WHERE machine = machine_id;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `machine name` (IN `id_machine` INT)  NO SQL
BEGIN
DECLARE temp text ;

SELECT machine INTO temp FROM machine WHERE id = id_machine;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `name_user` (IN `id_id` INT)  BEGIN
DECLARE temp text ;
SELECT pr_cod INTO temp FROM user WHERE id = id_id;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `search_test` (IN `test_idd` INT, IN `user_idd` INT)  BEGIN
SELECT id from tests_users WHERE test_id=test_idd and user_id=user_idd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_answer` (IN `test_idd` INT, IN `user_idd` INT)  BEGIN
SELECT date,user_answer FROM tests_users WHERE test_id = test_idd and user_id = user_idd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `syncdepmach1` (IN `dep_id` INT)  BEGIN
SELECT machin_id FROM syncdepmach WHERE departeman_id = dep_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sync_test_user` (IN `test_idd` INT)  BEGIN
SELECT user_id FROM tests_users WHERE test_id = test_idd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sync_user_test` (IN `user_idd` INT)  BEGIN
SELECT test_id FROM tests_users WHERE user_id = user_idd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `test _id` (IN `qus_name` TEXT)  BEGIN
DECLARE temp text ;

SELECT id INTO temp FROM tests WHERE name = qus_name;
SELECT temp as message;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `test_machine_id` (IN `machine_id` INT)  BEGIN
SELECT id FROM tests WHERE machine = machine_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userper` (IN `Prs_cod` INT)  BEGIN
SELECT permission from user where pr_cod = Prs_cod;     
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `user_id` (IN `pr_code` INT)  BEGIN
DECLARE temp text ;
SELECT id INTO temp FROM user WHERE pr_cod = pr_code;
SELECT temp as message;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `departman`
--

CREATE TABLE `departman` (
  `id` int(11) NOT NULL,
  `departman` text COLLATE utf8_persian_ci NOT NULL DEFAULT 'emptydepartman'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `departman`
--

INSERT INTO `departman` (`id`, `departman`) VALUES
(0, 'lar'),
(1, 'shiraz'),
(2, 'حامد'),
(3, 'رضا');

-- --------------------------------------------------------

--
-- Table structure for table `machine`
--

CREATE TABLE `machine` (
  `id` int(11) NOT NULL,
  `machine` text COLLATE utf8_persian_ci NOT NULL DEFAULT 'emptymachine'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `machine`
--

INSERT INTO `machine` (`id`, `machine`) VALUES
(0, 'loder'),
(1, 'terayli'),
(2, 'شستا');

-- --------------------------------------------------------

--
-- Table structure for table `syncdepmach`
--

CREATE TABLE `syncdepmach` (
  `id` int(11) NOT NULL,
  `departeman_id` int(11) NOT NULL,
  `machin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `syncdepmach`
--

INSERT INTO `syncdepmach` (`id`, `departeman_id`, `machin_id`) VALUES
(0, 0, 1),
(1, 0, 0),
(2, 1, 1),
(3, 1, 0),
(4, 2, 2),
(5, 0, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tests`
--

CREATE TABLE `tests` (
  `id` int(11) NOT NULL,
  `name` text COLLATE utf8_persian_ci NOT NULL,
  `machine` int(11) NOT NULL,
  `question` text COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tests`
--

INSERT INTO `tests` (`id`, `name`, `machine`, `question`) VALUES
(0, 'salamat', 0, 'سلام'),
(1, 'فیک', 2, 'سیشسیخبرهزطر؟'),
(2, 'asd', 1, 'dasdasd'),
(3, 'salamt', 0, 'sadsd');

-- --------------------------------------------------------

--
-- Table structure for table `tests_users`
--

CREATE TABLE `tests_users` (
  `id` int(11) NOT NULL,
  `test_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `user_answer` text COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tests_users`
--

INSERT INTO `tests_users` (`id`, `test_id`, `user_id`, `date`, `user_answer`) VALUES
(0, 0, 999, '2018-11-01 20:55:11', 'احوال تو تو من'),
(1, 2, 999, '2020-05-23 08:17:03', 'WQEQE'),
(2, 0, 2, '2020-05-23 08:29:59', 'yes'),
(3, 1, 999, '2020-05-23 09:03:49', 'نه');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `pr_cod` int(11) NOT NULL,
  `pass` int(11) NOT NULL DEFAULT 1234,
  `permission` int(11) NOT NULL DEFAULT 0,
  `last_login` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `pr_cod`, `pass`, `permission`, `last_login`) VALUES
(0, 999, 1234, 1, '2020-05-23 09:03:16'),
(1, 1, 1, 999, '2020-05-23 09:20:57'),
(2, 2, 2, 1, '2020-05-23 08:29:41');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `departman`
--
ALTER TABLE `departman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `machine`
--
ALTER TABLE `machine`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `syncdepmach`
--
ALTER TABLE `syncdepmach`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tests`
--
ALTER TABLE `tests`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tests_users`
--
ALTER TABLE `tests_users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
