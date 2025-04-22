-- MySQL dump 10.13  Distrib 5.7.14, for Win64 (x86_64)
--
-- Host: localhost    Database: restaurant
-- ------------------------------------------------------
-- Server version	5.7.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `должности`
--

DROP TABLE IF EXISTS `должности`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `должности` (
  `Код_должности` int(2) NOT NULL AUTO_INCREMENT,
  `Название_должности` varchar(10) NOT NULL,
  `Оклад` int(5) NOT NULL,
  PRIMARY KEY (`Код_должности`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `должности`
--

LOCK TABLES `должности` WRITE;
/*!40000 ALTER TABLE `должности` DISABLE KEYS */;
INSERT INTO `должности` VALUES (1,'Повар',45000),(2,'Официант',25000),(3,'Уборщица',23000),(4,'Директор',70000),(5,'Бухгалтер',35000),(6,'Экономист',30000),(7,'Швейцар',25000);
/*!40000 ALTER TABLE `должности` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `меню`
--

DROP TABLE IF EXISTS `меню`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `меню` (
  `Код_блюда` int(2) NOT NULL AUTO_INCREMENT,
  `Название_блюда` varchar(20) NOT NULL,
  `Код_состава` int(2) NOT NULL,
  `Ккал` int(3) NOT NULL,
  `Вес` int(4) NOT NULL,
  `Цена` int(4) NOT NULL,
  PRIMARY KEY (`Код_блюда`),
  UNIQUE KEY `Код состава` (`Код_состава`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `меню`
--

LOCK TABLES `меню` WRITE;
/*!40000 ALTER TABLE `меню` DISABLE KEYS */;
INSERT INTO `меню` VALUES (1,'Котлета куриная',1,185,200,90),(2,'Бифштекс с яйцом',2,326,150,120),(3,'Треска',3,79,150,115),(4,'Пюре',4,75,150,70),(5,'Макароны',5,220,150,50),(6,'Рис',6,360,150,70),(7,'Овощи',7,31,150,90),(8,'Тирамису',8,288,100,200),(9,'Медовик',9,311,100,150),(10,'Шоколад',10,285,100,120),(11,'Компот',11,93,200,50),(12,'Чай',12,140,200,30),(13,'Кофе',13,101,200,100);
/*!40000 ALTER TABLE `меню` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `оплата`
--

DROP TABLE IF EXISTS `оплата`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `оплата` (
  `Код_оплаты` int(3) NOT NULL AUTO_INCREMENT,
  `Сумма` int(11) NOT NULL,
  `Форма_оплаты` varchar(15) DEFAULT NULL,
  `Статус` varchar(15) NOT NULL,
  `Дата` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Код_оплаты`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `оплата`
--

LOCK TABLES `оплата` WRITE;
/*!40000 ALTER TABLE `оплата` DISABLE KEYS */;
INSERT INTO `оплата` VALUES (1,330,'наличные','оплачено','2022-05-28 19:04:39'),(2,530,'QR','оплачено','2022-05-28 19:05:55'),(3,390,'безналичные','оплачено','2022-05-28 19:06:24'),(4,350,'QR','оплачено','2022-05-28 19:07:04'),(5,165,'','не оплачено','2022-05-28 22:52:46'),(6,185,'QR','оплачено','2022-05-29 15:10:48'),(8,120,'','не оплачено','2022-05-29 18:32:53'),(9,50,'наличные','оплачено','2022-06-03 00:27:42');
/*!40000 ALTER TABLE `оплата` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `открытые_заказы`
--

DROP TABLE IF EXISTS `открытые_заказы`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `открытые_заказы` (
  `Код_заказа` int(3) NOT NULL AUTO_INCREMENT,
  `Код_стола` int(2) NOT NULL,
  `Код_оплаты` int(3) NOT NULL,
  PRIMARY KEY (`Код_заказа`),
  KEY `Код оплаты` (`Код_оплаты`),
  KEY `Kod_stola` (`Код_стола`),
  CONSTRAINT `открытые_заказы_ibfk_1` FOREIGN KEY (`Код_стола`) REFERENCES `столы` (`Код_стола`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `открытые_заказы_ibfk_2` FOREIGN KEY (`Код_оплаты`) REFERENCES `оплата` (`Код_оплаты`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `открытые_заказы`
--

LOCK TABLES `открытые_заказы` WRITE;
/*!40000 ALTER TABLE `открытые_заказы` DISABLE KEYS */;
INSERT INTO `открытые_заказы` VALUES (1,1,1),(2,2,2),(3,3,3),(4,4,4),(5,5,5),(8,8,8),(9,6,9);
/*!40000 ALTER TABLE `открытые_заказы` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `персонал`
--

DROP TABLE IF EXISTS `персонал`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `персонал` (
  `Код_сотрудника` int(2) NOT NULL AUTO_INCREMENT,
  `Код_должности` int(2) NOT NULL,
  `Фамилия` varchar(20) NOT NULL,
  `Имя` varchar(20) NOT NULL,
  `Отчество` varchar(20) NOT NULL,
  `Дата_рождения` date NOT NULL,
  PRIMARY KEY (`Код_сотрудника`),
  KEY `Код должности` (`Код_должности`),
  CONSTRAINT `персонал_ibfk_1` FOREIGN KEY (`Код_должности`) REFERENCES `должности` (`Код_должности`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `персонал`
--

LOCK TABLES `персонал` WRITE;
/*!40000 ALTER TABLE `персонал` DISABLE KEYS */;
INSERT INTO `персонал` VALUES (1,2,'Максимова','Дарья','Павловна','1990-01-01'),(2,2,'Мальцева','Наталья','Сергеевна','1999-04-03'),(3,1,'Григорьев','Максим','Антонович','1970-01-01'),(4,2,'Фоменко','Николай','Петрович','1992-06-01'),(5,2,'Нестеренко','Анастасия','Ивановна','1990-01-02'),(6,1,'Невеселов','Дмитрий','Викторович','1974-08-02'),(7,1,'Музычко','Валентина','Витальевна','1970-06-05'),(8,4,'Антонов','Михаил','Валерьевич','1970-12-12'),(9,3,'Остапова','Инна','Евгеньевна','1965-04-03'),(10,7,'Раскольников','Родион','Романович','1970-08-11'),(11,6,'Ермакова','Елизавета','Григорьевна','1973-02-01');
/*!40000 ALTER TABLE `персонал` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `пользователи`
--

DROP TABLE IF EXISTS `пользователи`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `пользователи` (
  `Код_пользователя` int(2) NOT NULL AUTO_INCREMENT,
  `логин` varchar(20) NOT NULL,
  `пароль` varchar(50) NOT NULL,
  PRIMARY KEY (`Код_пользователя`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `пользователи`
--

LOCK TABLES `пользователи` WRITE;
/*!40000 ALTER TABLE `пользователи` DISABLE KEYS */;
INSERT INTO `пользователи` VALUES (1,'root',''),(2,'admin','11');
/*!40000 ALTER TABLE `пользователи` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `склад`
--

DROP TABLE IF EXISTS `склад`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `склад` (
  `Код_ингредиента` int(2) NOT NULL AUTO_INCREMENT,
  `Название_ингредиента` varchar(20) NOT NULL,
  `Количество` int(5) NOT NULL,
  PRIMARY KEY (`Код_ингредиента`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `склад`
--

LOCK TABLES `склад` WRITE;
/*!40000 ALTER TABLE `склад` DISABLE KEYS */;
INSERT INTO `склад` VALUES (1,'Печенье савоярди',18921),(2,'Куриный фарш',13000),(3,'Говядина',14700),(4,'Яйцо',9520),(5,'Треска',8950),(6,'Картофель',24640),(7,'Молоко',9920),(8,'Масло сливочное',24925),(9,'Макароны',29702),(10,'Рис',23950),(11,'Тыква',14700),(12,'Брокколи',14800),(13,'Лук',14800),(14,'Сыр маскарпоне',14800),(15,'Пудра сахарная',9875),(16,'Вино сладкое',14920),(17,'Какао порошок',14950),(18,'Мед',14980),(19,'Мука',14580),(20,'Сода',14995),(21,'Сахар',14975),(22,'Соль',14973),(23,'Чай',14965),(24,'Кофе',14830),(25,'Сухофрукты',8800),(26,'Вода',99000);
/*!40000 ALTER TABLE `склад` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `состав`
--

DROP TABLE IF EXISTS `состав`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `состав` (
  `Код_состава` int(2) NOT NULL,
  `Код_ингредиента` int(2) NOT NULL,
  `Вес_ингредиента` int(4) NOT NULL,
  KEY `Код_ингредиента` (`Код_ингредиента`),
  KEY `Код_состава` (`Код_состава`),
  CONSTRAINT `состав_ibfk_1` FOREIGN KEY (`Код_ингредиента`) REFERENCES `склад` (`Код_ингредиента`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `состав_ibfk_2` FOREIGN KEY (`Код_состава`) REFERENCES `меню` (`Код_состава`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `состав`
--

LOCK TABLES `состав` WRITE;
/*!40000 ALTER TABLE `состав` DISABLE KEYS */;
INSERT INTO `состав` VALUES (1,2,100),(2,3,100),(2,4,50),(3,5,150),(4,6,120),(4,8,10),(4,7,20),(5,9,149),(5,22,1),(6,10,150),(7,15,15),(7,11,60),(7,12,40),(7,13,40),(7,22,5),(8,1,10),(8,14,25),(8,15,5),(8,4,30),(8,24,20),(8,16,10),(8,17,5),(9,4,30),(9,18,20),(9,21,15),(8,19,50),(9,8,10),(10,4,60),(10,8,25),(10,21,10),(10,19,20),(10,20,5),(10,17,10),(10,15,10),(10,8,10),(10,7,20),(11,25,100),(11,26,100),(12,23,5),(13,24,5);
/*!40000 ALTER TABLE `состав` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `столы`
--

DROP TABLE IF EXISTS `столы`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `столы` (
  `Код_стола` int(2) NOT NULL AUTO_INCREMENT,
  `Код_официанта` int(2) NOT NULL,
  `Статус` tinyint(1) NOT NULL,
  PRIMARY KEY (`Код_стола`),
  KEY `Kod_officianta` (`Код_официанта`),
  CONSTRAINT `столы_ibfk_1` FOREIGN KEY (`Код_официанта`) REFERENCES `персонал` (`Код_сотрудника`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `столы`
--

LOCK TABLES `столы` WRITE;
/*!40000 ALTER TABLE `столы` DISABLE KEYS */;
INSERT INTO `столы` VALUES (1,1,1),(2,1,1),(3,1,1),(4,1,1),(5,1,1),(6,2,1),(7,2,1),(8,2,1),(9,2,0),(10,2,0),(11,4,0),(12,4,0),(13,4,0),(14,4,0),(15,4,0),(16,5,0),(17,5,0),(18,5,0),(19,5,0),(20,5,0);
/*!40000 ALTER TABLE `столы` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `строка_заказа`
--

DROP TABLE IF EXISTS `строка_заказа`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `строка_заказа` (
  `Код_заказа` int(3) NOT NULL,
  `Код_блюда` int(2) NOT NULL,
  `Количество_порций` int(1) NOT NULL,
  KEY `Код блюда` (`Код_блюда`),
  KEY `Kod_zakaza` (`Код_заказа`),
  CONSTRAINT `строка_заказа_ibfk_1` FOREIGN KEY (`Код_блюда`) REFERENCES `меню` (`Код_блюда`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `строка_заказа_ibfk_2` FOREIGN KEY (`Код_заказа`) REFERENCES `открытые_заказы` (`Код_заказа`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `строка_заказа`
--

LOCK TABLES `строка_заказа` WRITE;
/*!40000 ALTER TABLE `строка_заказа` DISABLE KEYS */;
INSERT INTO `строка_заказа` VALUES (1,2,1),(1,6,1),(1,6,1),(1,6,1),(2,8,2),(2,12,1),(2,13,1),(3,1,1),(3,4,1),(3,8,1),(3,12,1),(4,3,2),(4,7,1),(4,12,1),(5,5,1),(5,3,1),(8,2,1),(9,5,1);
/*!40000 ALTER TABLE `строка_заказа` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-03  0:30:16
