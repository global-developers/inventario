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
INSERT INTO `categories` VALUES (1,'Administrador','2015-06-24 09:53:17','2015-06-24 09:53:17'),(2,'Vendedor','2015-06-24 09:53:17','2015-06-24 09:53:17');
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
INSERT INTO `migrations` VALUES ('2015_06_15_181045_create_categories_table',1),('2015_06_16_055856_create_products_table',1),('2015_06_16_131129_create_users_table',1);
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
  `price` double(15,2) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=101 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Cassin and Sons',932.20,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(2,'Weber Group',791.11,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(3,'Beer-Hermann',421.18,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(4,'Carter-Murray',101.01,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(5,'Yost, Maggio and Runolfsdottir',118.55,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(6,'Mante-Schoen',6.14,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(7,'Crist, Carter and Baumbach',336.11,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(8,'Funk-Boyer',359.61,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(9,'Cassin, Boehm and Strosin',315.94,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(10,'Streich, Heller and Hane',303.80,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(11,'Cole-Corwin',223.00,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(12,'Walker Group',660.91,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(13,'Barton, Murphy and Pouros',790.69,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(14,'Barrows, Wintheiser and Bailey',64.91,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(15,'Wilkinson and Sons',863.86,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(16,'Gislason-Fahey',482.12,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(17,'Stoltenberg LLC',949.52,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(18,'Haag, Stiedemann and Brakus',714.01,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(19,'Rosenbaum, Macejkovic and Kirlin',458.83,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(20,'Watsica, Schaden and D\'Amore',538.29,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(21,'Runolfsson-Koss',252.11,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(22,'Donnelly and Sons',748.90,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(23,'Nikolaus, Hickle and Gutkowski',221.07,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(24,'Koss Ltd',10.57,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(25,'Daugherty, Moore and Torphy',16.60,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(26,'Johns, Denesik and Kub',321.66,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(27,'Green-Howell',613.77,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(28,'Lang-Douglas',55.17,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(29,'Brekke Group',915.49,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(30,'Anderson-Kiehn',394.90,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(31,'Tromp-Kertzmann',860.44,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(32,'Leannon, O\'Connell and Mayer',278.49,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(33,'Predovic-Dickens',558.96,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(34,'Morissette-Braun',515.34,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(35,'Sawayn LLC',349.45,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(36,'Schaden-Nitzsche',754.57,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(37,'Bradtke LLC',210.61,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(38,'Mills Group',889.36,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(39,'Treutel-Braun',987.84,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(40,'Harber Ltd',661.34,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(41,'Borer-Kemmer',692.38,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(42,'Hintz, Vandervort and Durgan',851.61,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(43,'Ebert-Nienow',21.20,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(44,'Reichert Inc',376.50,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(45,'Skiles PLC',244.77,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(46,'Davis-Haley',470.81,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(47,'Wunsch, Osinski and Steuber',55.62,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(48,'Ward, Barton and Schiller',490.38,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(49,'Pfeffer Ltd',443.96,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(50,'Kilback, Buckridge and Rutherford',110.91,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(51,'Murazik Inc',525.02,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(52,'Barrows Group',826.20,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(53,'Von Group',26.08,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(54,'Prosacco, Goyette and Berge',162.26,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(55,'Berge, Hagenes and Langosh',985.63,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(56,'Gulgowski Ltd',936.13,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(57,'Bode Group',369.68,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(58,'Collier, Padberg and Homenick',786.26,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(59,'Mante, Nienow and Von',855.47,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(60,'Terry-Brown',566.35,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(61,'Upton PLC',614.84,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(62,'Towne-Fay',819.94,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(63,'Ratke and Sons',726.34,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(64,'Yundt, Price and Herman',406.63,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(65,'Bode-Feest',128.89,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(66,'Kuhn LLC',93.69,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(67,'Little-Nader',487.36,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(68,'Feil-Krajcik',459.71,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(69,'Greenfelder Ltd',959.11,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(70,'Upton-Hettinger',386.07,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(71,'Hudson Ltd',99.65,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(72,'Becker-Koch',304.09,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(73,'Borer, Botsford and DuBuque',49.20,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(74,'Terry and Sons',60.27,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(75,'Schuppe, Waelchi and Daniel',100.51,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(76,'Ferry-Harber',55.54,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(77,'Kerluke-Herzog',844.88,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(78,'Volkman and Sons',609.04,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(79,'Effertz, Bayer and Bayer',735.91,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(80,'McGlynn-Lowe',275.11,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(81,'Aufderhar, Oberbrunner and Herzog',942.82,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(82,'Hansen-Yost',883.68,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(83,'Mann-Ortiz',198.00,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(84,'Bartell, Nicolas and Veum',73.28,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(85,'Batz-Fay',249.12,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(86,'Jacobson, Bergnaum and Will',507.14,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(87,'Emard, Hane and Welch',570.41,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(88,'Morissette-Kuphal',594.67,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(89,'Hintz-Padberg',185.32,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(90,'Harvey Ltd',367.88,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(91,'Streich Ltd',403.17,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(92,'Hoeger LLC',951.27,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(93,'Hyatt PLC',665.25,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(94,'Halvorson LLC',306.52,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(95,'Sauer, Bednar and Waters',728.09,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(96,'Watsica, Schultz and Strosin',303.47,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(97,'Gaylord-Hilll',947.38,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(98,'Ebert Group',742.13,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(99,'Hammes-Rodriguez',379.19,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(100,'Kub, Prosacco and Prohaska',128.07,'2015-06-24 09:53:17','2015-06-24 09:53:17');
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
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Cristian Jaramillo','cristian_gerar@hotmail.com','s3cret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(2,'Valentine Schaefer MD','Bradtke.Khalil@Kuvalis.info','secret',2,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(3,'Larue Keeling','Kennith00@Kassulke.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(4,'Dr. Jamel Raynor Sr.','Hilda85@Jakubowski.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(5,'Prof. Derek Trantow','Jabari.Kshlerin@gmail.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(6,'Ali Turner','Koelpin.Buford@yahoo.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(7,'Scottie Hilll','pTerry@gmail.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(8,'Abbigail Heaney','xMcKenzie@hotmail.com','secret',1,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(9,'Jamil Braun','Gutmann.Levi@yahoo.com','secret',2,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(10,'Aileen Kautzer DVM','Camron01@Keebler.net','secret',2,'2015-06-24 09:53:17','2015-06-24 09:53:17'),(11,'Johann Collier','Ansley.OReilly@yahoo.com','secret',2,'2015-06-24 09:53:17','2015-06-24 09:53:17');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-23 23:58:35
