-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2019 at 11:54 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 5.6.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_facebook`
--

-- --------------------------------------------------------

--
-- Table structure for table `chitiet`
--

CREATE TABLE `chitiet` (
  `Date` int(11) NOT NULL,
  `NAME` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `LINK` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `chitiet`
--

INSERT INTO `chitiet` (`Date`, `NAME`, `LINK`, `created_at`, `updated_at`) VALUES
(0, 'NAME', 'LINK', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '1', 'https://www.facebook.com/nga.tin.14/posts/1292943024177003', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '2', 'https://www.facebook.com/nga.tin.14/posts/1292290600908912', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '3', 'https://www.facebook.com/nga.tin.14/posts/1288794831258489', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '4', 'https://www.facebook.com/nga.tin.14/posts/1120965144708126', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '5', 'https://www.facebook.com/search/posts/?q=nga%20t%C3%ACn%20Gi%E1%BA%A5y%20%C4%83n%20g%E1%BA%A5u%20tr%C3%BAc%20170k&epa=SEARCH_BOX', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '6', 'https://www.facebook.com/nga.tin.14/posts/1290880031049969', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '7', 'https://www.facebook.com/nga.tin.14/posts/1252208501583789', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '8', 'https://www.facebook.com/nga.tin.14/posts/1252326451571994', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '9', 'https://www.facebook.com/nga.tin.14/posts/1276419975829308', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '10', 'https://www.facebook.com/nga.tin.14/posts/1293393504131955', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '11', 'https://www.facebook.com/nga.tin.14/posts/1256992087772097', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '12', 'https://www.facebook.com/nga.tin.14/posts/1291540290983943', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '13', 'https://www.facebook.com/nga.tin.14/posts/1256994091105230', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '14', 'https://www.facebook.com/nga.tin.14/posts/1253408531463786', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '15', 'https://www.facebook.com/nga.tin.14/posts/1292952854176020', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '16', 'https://www.facebook.com/nga.tin.14/posts/1253108608160445', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '17', 'https://www.facebook.com/nga.tin.14/posts/1256997844438188', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '18', 'https://www.facebook.com/nga.tin.14/posts/1256998827771423', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '19', 'https://www.facebook.com/nga.tin.14/posts/1083595631778411', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '20', 'https://www.facebook.com/nga.tin.14/posts/1292969467507692', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '21', 'https://www.facebook.com/nga.tin.14/posts/1257001601104479', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '22', 'https://www.facebook.com/nga.tin.14/posts/1075288732609101', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '23', 'https://www.facebook.com/nga.tin.14/posts/1291287151009257', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '24', 'https://www.facebook.com/nga.tin.14/posts/1273170282820944', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '25', 'https://www.facebook.com/nga.tin.14/posts/1290877544383551', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '26', 'https://www.facebook.com/nga.tin.14/posts/1291439064327399', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '27', 'https://www.facebook.com/nga.tin.14/posts/1288340737970565', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, '28', 'https://www.facebook.com/nga.tin.14/posts/1291439064327399', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '29', 'https://www.facebook.com/nga.tin.14/posts/1292969467507692', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '30', 'https://www.facebook.com/nga.tin.14/posts/1292927320845240', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '31', 'https://www.facebook.com/nga.tin.14/posts/1292928677511771', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '32', 'https://www.facebook.com/nga.tin.14/posts/1292930604178245', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '33', 'https://www.facebook.com/nga.tin.14/posts/1292932670844705', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '34', 'https://www.facebook.com/nga.tin.14/posts/1292935964177709', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '35', 'https://www.facebook.com/photo.php?fbid=1292939224177383&set=a.1241538429317463&type=3&theater', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '36', 'https://www.facebook.com/photo.php?fbid=1292940137510625&set=a.1241538429317463&type=3&theater', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '37', 'https://www.facebook.com/nga.tin.14/posts/1292941310843841', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '38', 'https://www.facebook.com/nga.tin.14/posts/1292943024177003', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '39', 'https://www.facebook.com/nga.tin.14/posts/1292945007510138', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '40', 'https://www.facebook.com/nga.tin.14/posts/1292946304176675', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '41', 'https://www.facebook.com/nga.tin.14/posts/1292947420843230', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '42', 'https://www.facebook.com/nga.tin.14/posts/1292951570842815', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '43', 'https://www.facebook.com/nga.tin.14/posts/1292952854176020', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '44', 'https://www.facebook.com/nga.tin.14/posts/1292954520842520', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '45', 'https://www.facebook.com/nga.tin.14/posts/1292955964175709', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '46', 'https://www.facebook.com/nga.tin.14/posts/1292956944175611', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '47', 'https://www.facebook.com/nga.tin.14/posts/1292958290842143', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '48', 'https://www.facebook.com/nga.tin.14/posts/1292960114175294', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '49', 'https://www.facebook.com/nga.tin.14/posts/1292961567508482', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '50', 'https://www.facebook.com/nga.tin.14/posts/1292963960841576', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '51', 'https://www.facebook.com/nga.tin.14/posts/1292965684174737', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '52', 'https://www.facebook.com/nga.tin.14/posts/1292967807507858', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, '53', 'https://www.facebook.com/nga.tin.14/posts/1292949687509670', '0000-00-00 00:00:00', '0000-00-00 00:00:00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
