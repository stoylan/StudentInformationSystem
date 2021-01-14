-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: studentinfo
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `lessonlog`
--

DROP TABLE IF EXISTS `lessonlog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lessonlog` (
  `i` int NOT NULL AUTO_INCREMENT,
  `ID` int DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Midterm` varchar(45) DEFAULT NULL,
  `Final` varchar(45) DEFAULT NULL,
  `Grade` varchar(3) DEFAULT NULL,
  `WordGrade` varchar(45) DEFAULT NULL,
  `OverallAverage` varchar(45) DEFAULT NULL,
  `Absent` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`i`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lessonlog`
--

LOCK TABLES `lessonlog` WRITE;
/*!40000 ALTER TABLE `lessonlog` DISABLE KEYS */;
INSERT INTO `lessonlog` VALUES (1,1,'Physic','25','55','0','-','75',NULL),(2,2,'Mathematic','31','100','72','BB','72','19'),(3,2,'Physic','40','100','76','-','75',NULL),(4,3,'Mathematic','100','90','94','AA','72','14'),(5,3,'Physic','50','80','68','DZ','75','25'),(6,3,'Chemistry','22','50','38','DZ','62','21'),(7,3,'Biology','22','52','0','-','37',NULL),(9,3,'English','90','100','96','AA','82','11'),(10,4,'Mathematic','31','100','72','BB','72','19'),(11,4,'Chemistry','90','80','84','DZ','62','24'),(12,4,'Biology','10','10','10','FF','37',NULL),(13,5,'Mathematic','33','100','73','BB','72','19'),(14,5,'Chemistry','33','100','73','DZ','62','24'),(15,5,'Biology','30','30','30','FF','37',NULL),(16,6,'Mathematic','11','100','64','BC','72','19'),(17,6,'Physic','80','80','80','BA','75','13'),(18,6,'Chemistry','31','31','30','FF','62','11'),(19,6,'Biology','31','100','72','DZ','37','17'),(21,6,'English','50','80','68','DZ','82','23');
/*!40000 ALTER TABLE `lessonlog` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-08 21:39:44
