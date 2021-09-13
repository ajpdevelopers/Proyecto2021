-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: Chat_BD
-- ------------------------------------------------------
-- Server version	8.0.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrador`
--

DROP TABLE IF EXISTS `administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrador` (
  `Ci` int NOT NULL,
  `permisos` enum('Modificar datos','Registros') NOT NULL,
  PRIMARY KEY (`Ci`),
  CONSTRAINT `administrador_ibfk_1` FOREIGN KEY (`Ci`) REFERENCES `usuario` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
INSERT INTO `administrador` VALUES (51996596,'Registros'),(55966549,'Modificar datos'),(59876546,'Registros');
/*!40000 ALTER TABLE `administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alumno` (
  `Ci` int NOT NULL,
  PRIMARY KEY (`Ci`),
  CONSTRAINT `alumno_ibfk_1` FOREIGN KEY (`Ci`) REFERENCES `usuario` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES (51996594),(52987456),(53106408),(53489753),(54357935);
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignatura`
--

DROP TABLE IF EXISTS `asignatura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asignatura` (
  `IdMateria` int NOT NULL,
  `Materia` varchar(20) NOT NULL,
  PRIMARY KEY (`IdMateria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignatura`
--

LOCK TABLES `asignatura` WRITE;
/*!40000 ALTER TABLE `asignatura` DISABLE KEYS */;
INSERT INTO `asignatura` VALUES (12121212,'Proyecto'),(12128128,'Matematicas'),(22129999,'Geometria'),(34343434,'Programacion');
/*!40000 ALTER TABLE `asignatura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chat` (
  `IDChat` int NOT NULL,
  `Registro` varchar(800) NOT NULL,
  `Individual` int NOT NULL,
  `Grupal` int NOT NULL,
  `Calidad` enum('Anfitrion','Oyente') NOT NULL,
  `CiDocente` int NOT NULL,
  `CiAlumno` int NOT NULL,
  PRIMARY KEY (`IDChat`),
  KEY `CiDocente` (`CiDocente`),
  KEY `CiAlumno` (`CiAlumno`),
  CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`CiDocente`) REFERENCES `docente` (`Ci`),
  CONSTRAINT `chat_ibfk_2` FOREIGN KEY (`CiAlumno`) REFERENCES `alumno` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
INSERT INTO `chat` VALUES (99876123,'Se resolvieron 3 ejercicios y se dio tema nuevo',1,0,'Anfitrion',16584358,54357935),(99988877,'Consultas sobre codigo y compresion de programa',1,0,'Anfitrion',37954689,54357935),(99999999,'Alumnos totales presentes, se dio tema nuevo',0,34,'Oyente',36843456,51996594);
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consulta`
--

DROP TABLE IF EXISTS `consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consulta` (
  `IdConsulta` int NOT NULL,
  `Contenido` varchar(500) DEFAULT NULL,
  `Estado` enum('Realizada','Respondida','Contestada') NOT NULL,
  `Agenda` enum('Lunes','Martes','Miercoles','Jueves','Viernes','Sabado','Domingo') NOT NULL,
  `CiDocente` int NOT NULL,
  `CiAlumno` int NOT NULL,
  PRIMARY KEY (`IdConsulta`),
  KEY `CiAlumno` (`CiAlumno`),
  KEY `CiDocente` (`CiDocente`),
  CONSTRAINT `consulta_ibfk_1` FOREIGN KEY (`CiAlumno`) REFERENCES `alumno` (`Ci`),
  CONSTRAINT `consulta_ibfk_2` FOREIGN KEY (`CiDocente`) REFERENCES `docente` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta`
--

LOCK TABLES `consulta` WRITE;
/*!40000 ALTER TABLE `consulta` DISABLE KEYS */;
INSERT INTO `consulta` VALUES (11112222,'Profesor, tengo dudas sobre los temas de escrito','Realizada','Lunes',36843456,51996594),(11221122,'Los practicos de derivadas te ayudaran a practicar para el escrito','Respondida','Lunes',16584358,51996594),(15687965,'Con que programa usaremos para programar este año?','Realizada','Jueves',23549689,53106408),(22221111,'Tuvistes un error ocacionado por falto de ; y gramatical','Contestada','Martes',37954689,54357935),(99911299,'Profe, como se calcula la pendiente en el caso 5 del practico?','Realizada','Viernes',13548965,53489753);
/*!40000 ALTER TABLE `consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docente`
--

DROP TABLE IF EXISTS `docente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `docente` (
  `Ci` int NOT NULL,
  PRIMARY KEY (`Ci`),
  CONSTRAINT `docente_ibfk_1` FOREIGN KEY (`Ci`) REFERENCES `usuario` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docente`
--

LOCK TABLES `docente` WRITE;
/*!40000 ALTER TABLE `docente` DISABLE KEYS */;
INSERT INTO `docente` VALUES (13548965),(16584358),(23549689),(36843456),(37954689);
/*!40000 ALTER TABLE `docente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo`
--

DROP TABLE IF EXISTS `grupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo` (
  `Nomgrupo` varchar(10) NOT NULL,
  `IDGrupo` int NOT NULL,
  PRIMARY KEY (`IDGrupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES ('3ºBA1',12312312),('3ºBA',68968968),('3ºBB',99999998);
/*!40000 ALTER TABLE `grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mensaje`
--

DROP TABLE IF EXISTS `mensaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mensaje` (
  `Fecha` date NOT NULL,
  `IDChat` int NOT NULL,
  `Registro` varchar(800) NOT NULL,
  `Individual` int NOT NULL,
  `Grupal` int NOT NULL,
  PRIMARY KEY (`Fecha`),
  KEY `IDChat` (`IDChat`),
  CONSTRAINT `mensaje_ibfk_1` FOREIGN KEY (`IDChat`) REFERENCES `chat` (`IDChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensaje`
--

LOCK TABLES `mensaje` WRITE;
/*!40000 ALTER TABLE `mensaje` DISABLE KEYS */;
INSERT INTO `mensaje` VALUES ('2021-04-05',99999999,'Alumnos totales presentes, se dio tema nuevo',0,34),('2021-06-05',99988877,'Consultas sobre codigo y compresion de programa',0,32),('2021-06-06',99988877,'Se resolvieron 3 ejercicios y se dio tema nuevo',1,0);
/*!40000 ALTER TABLE `mensaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `realiza`
--

DROP TABLE IF EXISTS `realiza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `realiza` (
  `IDGrupo` int NOT NULL,
  `IdMateria` int NOT NULL,
  KEY `IDGrupo` (`IDGrupo`),
  KEY `IdMateria` (`IdMateria`),
  CONSTRAINT `realiza_ibfk_1` FOREIGN KEY (`IDGrupo`) REFERENCES `grupo` (`IDGrupo`),
  CONSTRAINT `realiza_ibfk_2` FOREIGN KEY (`IdMateria`) REFERENCES `asignatura` (`IdMateria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `realiza`
--

LOCK TABLES `realiza` WRITE;
/*!40000 ALTER TABLE `realiza` DISABLE KEYS */;
INSERT INTO `realiza` VALUES (68968968,12121212),(12312312,34343434),(99999998,12128128),(12312312,22129999),(12312312,34343434);
/*!40000 ALTER TABLE `realiza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supervisa`
--

DROP TABLE IF EXISTS `supervisa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supervisa` (
  `CiAdm` int NOT NULL,
  `IdCons` int NOT NULL,
  KEY `CiAdm` (`CiAdm`),
  CONSTRAINT `supervisa_ibfk_1` FOREIGN KEY (`CiAdm`) REFERENCES `administrador` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supervisa`
--

LOCK TABLES `supervisa` WRITE;
/*!40000 ALTER TABLE `supervisa` DISABLE KEYS */;
INSERT INTO `supervisa` VALUES (55966549,11112222),(51996596,22221111),(55966549,11221122),(59876546,99911299),(59876546,15687965);
/*!40000 ALTER TABLE `supervisa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiene` (
  `CiAlumno` int NOT NULL,
  `IDGrupo` int NOT NULL,
  KEY `IDGrupo` (`IDGrupo`),
  KEY `CiAlumno` (`CiAlumno`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`IDGrupo`) REFERENCES `grupo` (`IDGrupo`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`CiAlumno`) REFERENCES `alumno` (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
INSERT INTO `tiene` VALUES (51996594,68968968),(54357935,12312312),(53489753,99999998),(53106408,68968968),(52987456,12312312);
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabaja`
--

DROP TABLE IF EXISTS `trabaja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabaja` (
  `CiDocente` int NOT NULL,
  `IDMateria` int NOT NULL,
  KEY `CiDocente` (`CiDocente`),
  KEY `IDMateria` (`IDMateria`),
  CONSTRAINT `trabaja_ibfk_1` FOREIGN KEY (`CiDocente`) REFERENCES `docente` (`Ci`),
  CONSTRAINT `trabaja_ibfk_2` FOREIGN KEY (`IDMateria`) REFERENCES `asignatura` (`IdMateria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabaja`
--

LOCK TABLES `trabaja` WRITE;
/*!40000 ALTER TABLE `trabaja` DISABLE KEYS */;
INSERT INTO `trabaja` VALUES (36843456,12121212),(37954689,34343434),(16584358,12128128),(13548965,22129999),(23549689,34343434);
/*!40000 ALTER TABLE `trabaja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Ci` int NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `contraseña` varchar(45) NOT NULL,
  `ImagenDePerfil` longblob,
  PRIMARY KEY (`Ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (13548965,'Enrique','Espinola','Espinola','EnrEs9887354',NULL),(16584358,'Cristina','Gonzalez','Cristina','CrGz9866864',NULL),(23549689,'Pablo','Perrone','Perrone21','PPP1084654',NULL),(36843456,'Martin','Viar','Viar','MV8796574',NULL),(37954689,'Ignacio','Lasalvia','LaSalvia','IgSalvia987657',NULL),(51996594,'Pablo','Sosa','Paso','P894526873',NULL),(51996596,'Pablo2','Sosa2','PSNicolas','Nc995462311',NULL),(52987456,'Agustin','Pastoreli','Agus','Ap46586546',NULL),(53106408,'Matheo','Santana','Matheo','MS8768752',NULL),(53489753,'Alejandro','Rodriguez','Ale','Aldro15678624',NULL),(54357935,'joaquin','ferreira','Joacote','J4965487354',NULL),(55966549,'Alejo','Nievas','AleNievas18','AlNs986654',NULL),(59876546,'Facundo','Sosa','Fosa','Fo549Sa3596',NULL);
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

-- Dump completed on 2021-09-12 19:04:42
