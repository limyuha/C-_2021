-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        10.6.4-MariaDB - mariadb.org binary distribution
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- winform 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `winform` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `winform`;

-- 테이블 winform.book 구조 내보내기
CREATE TABLE IF NOT EXISTS `book` (
  `book_no` int(11) NOT NULL,
  `isbn` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`book_no`),
  KEY `FK_book_bookinfo` (`isbn`),
  CONSTRAINT `FK_book_bookinfo` FOREIGN KEY (`isbn`) REFERENCES `bookinfo` (`isbn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 테이블 데이터 winform.book:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `book` DISABLE KEYS */;
/*!40000 ALTER TABLE `book` ENABLE KEYS */;

-- 테이블 winform.bookinfo 구조 내보내기
CREATE TABLE IF NOT EXISTS `bookinfo` (
  `isbn` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `cat_no` int(11) NOT NULL,
  `author` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `pub` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `pub_dt` date NOT NULL,
  `book_nm` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`isbn`),
  KEY `FK__category` (`cat_no`),
  CONSTRAINT `FK__category` FOREIGN KEY (`cat_no`) REFERENCES `category` (`cat_no`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='도서정보테이블';

-- 테이블 데이터 winform.bookinfo:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `bookinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `bookinfo` ENABLE KEYS */;

-- 테이블 winform.category 구조 내보내기
CREATE TABLE IF NOT EXISTS `category` (
  `cat_no` int(11) NOT NULL,
  `cat_nm` varchar(50) NOT NULL,
  PRIMARY KEY (`cat_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='도서분류테이블';

-- 테이블 데이터 winform.category:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

-- 테이블 winform.issue 구조 내보내기
CREATE TABLE IF NOT EXISTS `issue` (
  `issue_no` int(11) NOT NULL,
  `mem_no` int(11) NOT NULL,
  `issue_dt` date NOT NULL,
  `issue_text` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`issue_no`),
  KEY `FK_issue_member` (`mem_no`),
  CONSTRAINT `FK_issue_member` FOREIGN KEY (`mem_no`) REFERENCES `member` (`mem_no`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='이슈테이블';

-- 테이블 데이터 winform.issue:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `issue` DISABLE KEYS */;
/*!40000 ALTER TABLE `issue` ENABLE KEYS */;

-- 테이블 winform.member 구조 내보내기
CREATE TABLE IF NOT EXISTS `member` (
  `mem_no` int(11) NOT NULL,
  `mem_nm` varchar(12) NOT NULL,
  `pw` varchar(12) NOT NULL,
  `mem_grade` char(3) NOT NULL,
  `phone_no` char(11) NOT NULL,
  PRIMARY KEY (`mem_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='회원테이블';

-- 테이블 데이터 winform.member:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
/*!40000 ALTER TABLE `member` ENABLE KEYS */;

-- 테이블 winform.rental 구조 내보내기
CREATE TABLE IF NOT EXISTS `rental` (
  `rent_no` int(11) NOT NULL,
  `book_no` int(11) NOT NULL,
  `mem_no` int(11) NOT NULL,
  `rent_dt` date NOT NULL,
  `return_dt` date NOT NULL,
  `return_yn` char(1) NOT NULL,
  `ext` char(1) NOT NULL,
  PRIMARY KEY (`rent_no`),
  KEY `FK_rental_book` (`book_no`),
  KEY `FK_rental_member` (`mem_no`),
  CONSTRAINT `FK_rental_book` FOREIGN KEY (`book_no`) REFERENCES `book` (`book_no`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_rental_member` FOREIGN KEY (`mem_no`) REFERENCES `member` (`mem_no`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='대여테이블';

-- 테이블 데이터 winform.rental:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `rental` DISABLE KEYS */;
/*!40000 ALTER TABLE `rental` ENABLE KEYS */;

-- 테이블 winform.reserve 구조 내보내기
CREATE TABLE IF NOT EXISTS `reserve` (
  `mem_no` int(11) NOT NULL,
  `book_no` int(11) NOT NULL,
  `res_dt` datetime NOT NULL,
  PRIMARY KEY (`mem_no`,`book_no`,`res_dt`) USING BTREE,
  KEY `FK_reserve_book` (`book_no`),
  CONSTRAINT `FK_reserve_book` FOREIGN KEY (`book_no`) REFERENCES `book` (`book_no`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_reserve_member` FOREIGN KEY (`mem_no`) REFERENCES `member` (`mem_no`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='예약테이블';

-- 테이블 데이터 winform.reserve:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `reserve` DISABLE KEYS */;
/*!40000 ALTER TABLE `reserve` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
