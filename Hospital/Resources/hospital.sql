-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: hospital
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `carreras`
--

DROP TABLE IF EXISTS `carreras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carreras` (
  `id_carrera` int NOT NULL,
  `descripcion` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id_carrera`),
  KEY `id_carrera` (`id_carrera`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carreras`
--

LOCK TABLES `carreras` WRITE;
/*!40000 ALTER TABLE `carreras` DISABLE KEYS */;
/*!40000 ALTER TABLE `carreras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultas`
--

DROP TABLE IF EXISTS `consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultas` (
  `id_consulta` int NOT NULL AUTO_INCREMENT,
  `pacientes_noControl` int DEFAULT NULL,
  `usuario_idUsuario` int DEFAULT NULL,
  `id_Usuario` int DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `noControl` int DEFAULT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id_consulta`)
) ENGINE=InnoDB AUTO_INCREMENT=1235 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` VALUES (1,3,1,1,'2020-05-18',3,'alksdjlasjdlaskjdlaskjd'),(2,1,1,1,'2020-05-18',1,'asasdasdasdasd'),(152,1,1,1,'2020-05-18',1,'alejandro esta enfermo'),(153,1,1,1,'2020-05-18',1,'alejandro esta enfermo'),(1234,1,1,1,'2020-05-18',1,'12334512312');
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultasdetalle`
--

DROP TABLE IF EXISTS `consultasdetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultasdetalle` (
  `id_consultadetalle` int NOT NULL AUTO_INCREMENT,
  `medicamento_idmedicamento` int DEFAULT NULL,
  `consulta_idconsulta` int DEFAULT NULL,
  `id_consulta` int DEFAULT NULL,
  `id_medicamento` int DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  PRIMARY KEY (`id_consultadetalle`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultasdetalle`
--

LOCK TABLES `consultasdetalle` WRITE;
/*!40000 ALTER TABLE `consultasdetalle` DISABLE KEYS */;
INSERT INTO `consultasdetalle` VALUES (1,1,153,153,1,1),(2,1236,153,153,1236,3),(3,1235,1,1,1235,1),(4,1234,2,2,1234,1),(5,1236,2,2,1236,4);
/*!40000 ALTER TABLE `consultasdetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ent_med_detalle`
--

DROP TABLE IF EXISTS `ent_med_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ent_med_detalle` (
  `id_detalle` int NOT NULL AUTO_INCREMENT,
  `entradamedicamento_idEntrada` int NOT NULL,
  `medicamento_idMedicamento` int NOT NULL,
  `id_entrada` int NOT NULL,
  `id_medicamento` int NOT NULL,
  `cantidad` int NOT NULL,
  PRIMARY KEY (`id_detalle`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ent_med_detalle`
--

LOCK TABLES `ent_med_detalle` WRITE;
/*!40000 ALTER TABLE `ent_med_detalle` DISABLE KEYS */;
INSERT INTO `ent_med_detalle` VALUES (9,1,1234,1,1234,1),(10,10,1234,10,1234,3),(11,11,1234,11,1234,1),(12,12,1234,12,1234,6),(13,13,1234,13,1234,5),(14,14,1234,14,1234,5),(15,15,1234,15,1234,5),(16,16,1235,16,1235,10),(17,17,1234,17,1234,1),(18,18,1234,18,1234,4),(19,19,1234,19,1234,4),(20,20,1234,20,1234,4),(21,21,1235,21,1235,1),(22,22,1235,22,1235,1),(23,23,1234,23,1234,1),(24,24,1235,24,1235,11);
/*!40000 ALTER TABLE `ent_med_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entrada_medicamento`
--

DROP TABLE IF EXISTS `entrada_medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entrada_medicamento` (
  `id_entrada` int NOT NULL AUTO_INCREMENT,
  `usuario_idUsuario` int DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `idUsuario` int DEFAULT NULL,
  PRIMARY KEY (`id_entrada`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrada_medicamento`
--

LOCK TABLES `entrada_medicamento` WRITE;
/*!40000 ALTER TABLE `entrada_medicamento` DISABLE KEYS */;
INSERT INTO `entrada_medicamento` VALUES (4,1,'2020-05-17',1),(5,1,'2020-05-17',1),(6,1,'2020-05-17',1),(7,1,'2020-05-17',1),(8,1,'2020-05-17',1),(9,1,'2020-05-17',1),(10,1,'2020-05-17',1),(11,1,'2020-05-17',1),(12,1,'2020-05-17',1),(13,1,'2020-05-17',1),(14,1,'2020-05-17',1),(15,1,'2020-05-17',1),(16,1,'2020-05-17',1),(17,1,'2020-05-18',1),(18,7,'2020-05-18',7),(19,7,'2020-05-18',7);
/*!40000 ALTER TABLE `entrada_medicamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genero` (
  `id_genero` int NOT NULL,
  `descripcion` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicamento`
--

DROP TABLE IF EXISTS `medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicamento` (
  `id_medicamento` int NOT NULL,
  `unidadmedida_idunidadmedida` int DEFAULT NULL,
  `nombre` varchar(35) DEFAULT NULL,
  `existencia` int NOT NULL,
  `unidadmedida` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id_medicamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamento`
--

LOCK TABLES `medicamento` WRITE;
/*!40000 ALTER TABLE `medicamento` DISABLE KEYS */;
INSERT INTO `medicamento` VALUES (1,0,'Aspirina',10,'Pieza'),(1234,1,'Paracetamol',20,'Miligramos'),(1235,3,'Gentamicin',200,'Gramos'),(1236,0,'Dexiatrona',10,'Pieza');
/*!40000 ALTER TABLE `medicamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `noControl` int NOT NULL AUTO_INCREMENT,
  `usuario_idUsuario` int NOT NULL,
  `genero_idGenero` int NOT NULL,
  `carreras_idCarrera` int NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `a_paterno` varchar(35) NOT NULL,
  `a_materno` varchar(35) NOT NULL,
  `id_carrera` int NOT NULL,
  `id_genero` int NOT NULL,
  PRIMARY KEY (`noControl`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,1,0,2,'Alejandro','Cancino','Castillo',2,0),(2,1,0,3,'Andrea','Cancino','Castillo',3,0),(3,1,0,3,'Rafael','Novelo','Granados',3,0);
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_usuario` (
  `id_tipousuario` int NOT NULL,
  `descripcion` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id_tipousuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidad_medida`
--

DROP TABLE IF EXISTS `unidad_medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unidad_medida` (
  `id_unidadMedida` int NOT NULL,
  `descripcion` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id_unidadMedida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidad_medida`
--

LOCK TABLES `unidad_medida` WRITE;
/*!40000 ALTER TABLE `unidad_medida` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidad_medida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `genero_id` varchar(30) DEFAULT NULL,
  `tipo_usuario_id` int NOT NULL,
  `nombre` varchar(35) DEFAULT NULL,
  `a_paterno` varchar(35) DEFAULT NULL,
  `a_materno` varchar(35) DEFAULT NULL,
  `id_tipousuario` int DEFAULT NULL,
  `usuario` varchar(35) DEFAULT NULL,
  `contrasena` varchar(35) NOT NULL,
  `id_genero` int DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'0',1,'admin','admin','admin',1,'admin','admin',0),(5,NULL,1,'alejandro','cancino','castillo',1,'1234','1234',NULL),(6,NULL,2,'alejandro','cancino','castillo',2,'1234','1234',NULL),(7,NULL,1,'Alexander','Cancino','Castillo',1,'alex','1234',NULL);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-18 22:40:33
