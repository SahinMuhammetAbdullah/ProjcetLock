-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                10.4.32-MariaDB - mariadb.org binary distribution
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- projectlock için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `projectlock` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci */;
USE `projectlock`;

-- tablo yapısı dökülüyor projectlock.employee
CREATE TABLE IF NOT EXISTS `employee` (
  `EmployeeId` int(11) NOT NULL AUTO_INCREMENT,
  `EmployeeFirstName` text NOT NULL,
  `EmployeeLastName` text NOT NULL,
  `EmployeeNumberOfTasksCompleted` int(11) NOT NULL DEFAULT 0,
  `EmployeeNumberOngoingTasks` int(11) NOT NULL DEFAULT 0,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`EmployeeId`) USING BTREE,
  KEY `FK_employee_users` (`UserId`),
  CONSTRAINT `FK_employee_users` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- Veri çıktısı seçilmemişti

-- tablo yapısı dökülüyor projectlock.project
CREATE TABLE IF NOT EXISTS `project` (
  `ProjectId` int(11) NOT NULL AUTO_INCREMENT,
  `ProjectName` text NOT NULL,
  `ProjectBeginDate` date NOT NULL,
  `ProjectEndDate` date NOT NULL,
  `UserId` int(11) NOT NULL,
  `TaskId` int(11) NOT NULL,
  PRIMARY KEY (`ProjectId`) USING BTREE,
  KEY `FK_project_user` (`UserId`) USING BTREE,
  KEY `FK_project_task` (`TaskId`),
  CONSTRAINT `FK_project_task` FOREIGN KEY (`TaskId`) REFERENCES `task` (`TaskId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_project_user` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- Veri çıktısı seçilmemişti

-- tablo yapısı dökülüyor projectlock.task
CREATE TABLE IF NOT EXISTS `task` (
  `TaskId` int(11) NOT NULL AUTO_INCREMENT,
  `TaskName` text NOT NULL,
  `TaskBeginDate` date NOT NULL,
  `ManDayValue` int(11) NOT NULL,
  `TaskEndDate` date NOT NULL,
  `TaskState` text NOT NULL,
  `EmployeeId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`TaskId`) USING BTREE,
  KEY `FK_task_employee` (`EmployeeId`) USING BTREE,
  KEY `FK_task_project` (`UserId`) USING BTREE,
  CONSTRAINT `FK_task_employee` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_task_users` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- Veri çıktısı seçilmemişti

-- tablo yapısı dökülüyor projectlock.users
CREATE TABLE IF NOT EXISTS `users` (
  `UserId` int(10) NOT NULL AUTO_INCREMENT,
  `UserFirstName` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `UserLastName` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `UserName` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `UserPassword` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`UserId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- Veri çıktısı seçilmemişti

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
