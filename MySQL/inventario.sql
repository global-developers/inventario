-- MySQL dump 10.13  Distrib 5.1.73, for Win64 (unknown)
--
-- Host: localhost    Database: inventario
-- ------------------------------------------------------
-- Server version	5.1.73-community

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
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Administrador','2015-07-07 19:17:18','2015-07-07 19:17:18'),(2,'Vendedor','2015-07-07 19:17:18','2015-07-07 19:17:18');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `migrations`
--

DROP TABLE IF EXISTS `migrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `migrations` (
  `migration` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `migrations`
--

LOCK TABLES `migrations` WRITE;
/*!40000 ALTER TABLE `migrations` DISABLE KEYS */;
INSERT INTO `migrations` VALUES ('2015_06_15_181045_create_categories_table',1),('2015_06_16_055856_create_products_table',1),('2015_06_16_131129_create_users_table',1),('2015_06_30_124235_create_ventas_table',1);
/*!40000 ALTER TABLE `migrations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `description` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `price` double(15,2) NOT NULL,
  `color` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `barcode` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `count` int(10) unsigned NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Secadora','Secadora 15Kg Mabe Blanca SMW817',1200.00,'blanca','SMW817SXGBB',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(2,'Central','Central de Vapor Jiffy',5000.00,'rojo','J2000',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(3,'Parrilla','Parrilla Kups Panini',2000.00,'blanco','PG700063',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(4,'Batidora','Batidora de inmersión con picador Oster',700.00,'blanca','Z612-13',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(5,'Oster Profesional','Oster Profesional',1400.00,'silver','KJ885-93',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(6,'Extractor','Extractor de uso rudo Turmix',800.00,'rojo','TU04',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(7,'Licuadora','Licuadora Reversible Oster',1500.00,'azul','BRLy07-S00',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(8,'Batidora','Batidora Black & Decker 5 Litros',700.00,'blanco','MX900',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(9,'Horno de Microondas','Horno de Microondas 1.1 Pies Cúbicos General Electric Profile',2700.00,'silver','PEB1152SFE',3,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(10,'Parrilla','Parrilla 70cm Teka Cristal',7000.00,'amarillo','ZLUX705GAIALTR',3,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(11,'Batidora','Batidora Oster Manual 6 Velocidades',500.00,'blanco','ZH88Q-47',3,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(12,'Aspiradora','Aspiradora Manual Koblenz',600.00,'azul','HV-120-A',3,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(13,'Batidora','Batidora Kitchen Aid 6.8 Litros Acero Inoxidable',900.00,'silver','KP26M1XNP',4,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(14,'Batidora','Batidora de Pedestal Oster 4 Litros Acero Inoxidable M2700-13',1400.00,'amarillo','M2700-13',4,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(15,'Sandwichera','Sandwichera Oster',600.00,'amarillo','XLL33-99',4,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(16,'Batidora','Batidora Kitchen Aid Artisan 5 Litros',800.00,'blanco','KSM150PSWH',5,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(17,'Batidora','Batidora Hamilton Beach',900.00,'roja','COSX66',5,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(18,'Extractor','Extractor de jugos Oster',700.00,'amarillo','LK77DR',5,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(19,'Batidora','Batidora Kitchen Aid',800.00,'rojo','KSM7581',5,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(20,'Parrilla','Parrilla Eléctrica 80cm Teka Inducción',2500.00,'negro','IRS843',6,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(21,'Cafetera','Cafetera Oster de 946 ml',350.00,'azul','3301',6,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(22,'Batidora','Batidora Kitchen Aid',900.00,'blanco','KSM150PSMC',6,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(23,'Licuadora','Licuadora Oster',1500.00,'roja','M4126-13',7,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(24,'Licuadora','Licuadora Oster 3 Velocidades',1100.00,'metal','M4655-813',7,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(25,'Batidora','Batidora Kitchen Aid Artisan 5.6 Litros Acero Inoxidable',750.00,'metal','Z99HSF',8,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(26,'Parrilla','Parrilla 30cm Teka Acero Inoxidable',3500.00,'metal','EM302G',8,'2015-07-07 19:17:18','2015-07-07 19:17:18');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `full_name` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `email` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `password` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `category_id` int(10) unsigned NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`),
  KEY `users_category_id_foreign` (`category_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Cristian Jaramillo','cristian_gerar@hotmail.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(2,'Cristian Jaramillo','cristian.gerar@gmail.com','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(3,'Andrea','andymenjos@gmail.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(4,'Monica','monicadlr18@hotmail.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 14:25:11'),(5,'Fausto Ryan','sydnee.leuschke@gmail.com','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(6,'Myah Littel','sigmund31@marvin.info','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(7,'Lempi Waelchi','marco76@hotmail.com','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(8,'Davon Hilpert','angela.harris@konopelski.com','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(9,'Zelda Williamson I','rschumm@yahoo.com','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(10,'Krystel Flatley','treutel.harmon@hotmail.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(11,'Hoyt Schinner','vokon@yahoo.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(12,'Chasity Lowe','crohan@gmail.com','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(13,'Leola Hilll','haley36@mills.org','s3cret',1,'2015-07-07 19:17:18','2015-07-07 19:17:18'),(14,'Prof. Arne Hintz II','aframi@beer.net','s3cret',2,'2015-07-07 19:17:18','2015-07-07 19:17:18');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(10) unsigned NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`),
  KEY `ventas_user_id_foreign` (`user_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-07-07 17:17:05
