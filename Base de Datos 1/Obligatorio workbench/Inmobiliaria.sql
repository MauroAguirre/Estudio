-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: inmobiliaria
-- ------------------------------------------------------
-- Server version	5.5.24-log

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
-- Table structure for table `alquileres`
--

DROP TABLE IF EXISTS `alquileres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alquileres` (
  `idNegocio` int(11) NOT NULL,
  `codigoPostalLugar` int(11) DEFAULT NULL,
  `direccionLugar` varchar(45) DEFAULT NULL,
  `fechaDeAbandono` date DEFAULT NULL,
  `valorCuota` int(11) DEFAULT NULL,
  PRIMARY KEY (`idNegocio`),
  KEY `alquilerLugar_idx` (`codigoPostalLugar`,`direccionLugar`),
  CONSTRAINT `alquilerNegocio` FOREIGN KEY (`idNegocio`) REFERENCES `negocios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `alquilerLugar` FOREIGN KEY (`codigoPostalLugar`, `direccionLugar`) REFERENCES `lugares` (`codigoPostal`, `direccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alquileres`
--

LOCK TABLES `alquileres` WRITE;
/*!40000 ALTER TABLE `alquileres` DISABLE KEYS */;
INSERT INTO `alquileres` VALUES (7,20100,'Punta del este','2323-12-12',20100),(8,20000,'Centro','1111-11-11',20000);
/*!40000 ALTER TABLE `alquileres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `apartamentos`
--

DROP TABLE IF EXISTS `apartamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `apartamentos` (
  `codigoPostalEdificado` int(11) NOT NULL,
  `direccionEdificado` varchar(45) NOT NULL,
  PRIMARY KEY (`codigoPostalEdificado`,`direccionEdificado`),
  CONSTRAINT `apartamentoEdificado` FOREIGN KEY (`codigoPostalEdificado`, `direccionEdificado`) REFERENCES `edificados` (`codigoPostalLugar`, `direccionLugar`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apartamentos`
--

LOCK TABLES `apartamentos` WRITE;
/*!40000 ALTER TABLE `apartamentos` DISABLE KEYS */;
INSERT INTO `apartamentos` VALUES (20000,'Centro'),(20000,'Maldonado');
/*!40000 ALTER TABLE `apartamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `casas`
--

DROP TABLE IF EXISTS `casas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `casas` (
  `codigoPostalEdificado` int(11) NOT NULL,
  `direccionEdificado` varchar(45) NOT NULL,
  PRIMARY KEY (`codigoPostalEdificado`,`direccionEdificado`),
  CONSTRAINT `casaEdificado` FOREIGN KEY (`codigoPostalEdificado`, `direccionEdificado`) REFERENCES `edificados` (`codigoPostalLugar`, `direccionLugar`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `casas`
--

LOCK TABLES `casas` WRITE;
/*!40000 ALTER TABLE `casas` DISABLE KEYS */;
INSERT INTO `casas` VALUES (14000,'Positos'),(20100,'Punta del este');
/*!40000 ALTER TABLE `casas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `ciConsumidor` int(11) NOT NULL,
  PRIMARY KEY (`ciConsumidor`),
  CONSTRAINT `clienteConsumidor` FOREIGN KEY (`ciConsumidor`) REFERENCES `consumidores` (`ci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (59876542),(77774563),(83650311),(91299875);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consumidores`
--

DROP TABLE IF EXISTS `consumidores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consumidores` (
  `ci` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `mail` varchar(45) DEFAULT NULL,
  `celular` int(11) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consumidores`
--

LOCK TABLES `consumidores` WRITE;
/*!40000 ALTER TABLE `consumidores` DISABLE KEYS */;
INSERT INTO `consumidores` VALUES (12345111,'Laura','Cordano','Cordanonono111@gmail.com',97323545,426322332,'San Carlos ituzaingo basilio araujo'),(12872555,'Pablo','Gutierrez','gutigutipabluti1@gmail.com',99989876,422900876,'Maldonado los lirios el ceibo'),(30749090,'Ana','Peres','AnaPerez3984@hotmail.com',99116543,422123265,'Maldonado gemelos can menor'),(34242311,'Annie','Toledo','thegirlwithmagicwings876@gmail.com',99112211,555987678,'Brasil Tv. Paulina'),(54351233,'Ronaldo','Nazario','footballmasterggwp@hotmail.com',97398745,555334455,'Brasil av. mal floriano. r. dos andradas'),(59876542,'Raul','Peres','raulito23@gmail.com',99876543,422347688,'Maldonado 18 de julio 3 de febrero'),(77774563,'Carlos','Aguirre','Carlitos8973@gmail.com',97098098,426090807,'San Carlos 18 de julio carape'),(83650311,'Maicol','De Leon','maicramaicraplease33@gmail.com',99121212,422322391,'Maldonado rocha trinidad'),(91299875,'Max','Pain','slowMotion541@gmail.com',99897671,2147483647,'Nueva York 28 Carmine St');
/*!40000 ALTER TABLE `consumidores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edificados`
--

DROP TABLE IF EXISTS `edificados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `edificados` (
  `codigoPostalLugar` int(11) NOT NULL,
  `direccionLugar` varchar(45) NOT NULL,
  `patios` int(11) DEFAULT NULL,
  `garajes` int(11) DEFAULT NULL,
  `cantidadAmbientes` int(11) DEFAULT NULL,
  `cantidadBaños` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigoPostalLugar`,`direccionLugar`),
  CONSTRAINT `edificadoLugar` FOREIGN KEY (`codigoPostalLugar`, `direccionLugar`) REFERENCES `lugares` (`codigoPostal`, `direccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edificados`
--

LOCK TABLES `edificados` WRITE;
/*!40000 ALTER TABLE `edificados` DISABLE KEYS */;
INSERT INTO `edificados` VALUES (14000,'Positos',1,1,8,1),(19000,'Piriapolis',1,0,7,1),(20000,'Centro',0,0,6,1),(20000,'Maldonado',0,1,7,1),(20100,'Punta del este',2,3,14,2);
/*!40000 ALTER TABLE `edificados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locales`
--

DROP TABLE IF EXISTS `locales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locales` (
  `codigoPostalEdificado` int(11) NOT NULL,
  `direccionEdificado` varchar(45) NOT NULL,
  PRIMARY KEY (`codigoPostalEdificado`,`direccionEdificado`),
  CONSTRAINT `localEdificado` FOREIGN KEY (`codigoPostalEdificado`, `direccionEdificado`) REFERENCES `edificados` (`codigoPostalLugar`, `direccionLugar`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locales`
--

LOCK TABLES `locales` WRITE;
/*!40000 ALTER TABLE `locales` DISABLE KEYS */;
INSERT INTO `locales` VALUES (19000,'Piriapolis');
/*!40000 ALTER TABLE `locales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lugares`
--

DROP TABLE IF EXISTS `lugares`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lugares` (
  `codigoPostal` int(11) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `ciPropietario` int(11) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `superficieTotal` int(11) DEFAULT NULL,
  `superficieEdificada` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigoPostal`,`direccion`),
  KEY `lugarPropietario_idx` (`ciPropietario`),
  CONSTRAINT `lugarPropietario` FOREIGN KEY (`ciPropietario`) REFERENCES `propietarios` (`ciConsumidor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lugares`
--

LOCK TABLES `lugares` WRITE;
/*!40000 ALTER TABLE `lugares` DISABLE KEYS */;
INSERT INTO `lugares` VALUES (14000,'Positos',30749090,60000,'montevideo',200,180,'Centro'),(19000,'Piriapolis',12872555,53000,'Piriapolis',430,260,'A estrenar'),(20000,'Centro',34242311,20000,'Cerro',150,100,'Unico dueño'),(20000,'Maldonado',12345111,35000,'Maldonado',300,150,'A estrenar'),(20100,'Punta del este',12872555,210000,'Maldonado',500,423,'Unico dueño'),(40000,'San Carlos',54351233,10000,'San Carlos',150,0,'Unico dueño');
/*!40000 ALTER TABLE `lugares` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `negocios`
--

DROP TABLE IF EXISTS `negocios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `negocios` (
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `negocios`
--

LOCK TABLES `negocios` WRITE;
/*!40000 ALTER TABLE `negocios` DISABLE KEYS */;
INSERT INTO `negocios` VALUES (1),(2),(3),(4),(5),(6),(7),(8);
/*!40000 ALTER TABLE `negocios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ofertas`
--

DROP TABLE IF EXISTS `ofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ofertas` (
  `id` int(11) NOT NULL,
  `idNegocio` int(11) DEFAULT NULL,
  `ciCliente` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `vendedor` varchar(45) DEFAULT NULL,
  `escribano` varchar(45) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `ofertaCliente_idx` (`ciCliente`),
  KEY `ofertaNegocio_idx` (`idNegocio`),
  CONSTRAINT `ofertaCliente` FOREIGN KEY (`ciCliente`) REFERENCES `clientes` (`ciConsumidor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ofertaNegocio` FOREIGN KEY (`idNegocio`) REFERENCES `negocios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ofertas`
--

LOCK TABLES `ofertas` WRITE;
/*!40000 ALTER TABLE `ofertas` DISABLE KEYS */;
INSERT INTO `ofertas` VALUES (1,1,59876542,'2000-12-12','Tito','Don Figary',60000),(2,2,77774563,'2001-02-12','Pablo','Lautaro',50000),(3,3,83650311,'2010-11-03','Annie','Jesus',60000);
/*!40000 ALTER TABLE `ofertas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `propietarios`
--

DROP TABLE IF EXISTS `propietarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `propietarios` (
  `ciConsumidor` int(11) NOT NULL,
  PRIMARY KEY (`ciConsumidor`),
  CONSTRAINT `propietarioConsumidor` FOREIGN KEY (`ciConsumidor`) REFERENCES `consumidores` (`ci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `propietarios`
--

LOCK TABLES `propietarios` WRITE;
/*!40000 ALTER TABLE `propietarios` DISABLE KEYS */;
INSERT INTO `propietarios` VALUES (12345111),(12872555),(30749090),(34242311),(54351233);
/*!40000 ALTER TABLE `propietarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `terrenos`
--

DROP TABLE IF EXISTS `terrenos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `terrenos` (
  `codigoPostalLugar` int(11) NOT NULL,
  `direccionLugar` varchar(45) NOT NULL,
  PRIMARY KEY (`codigoPostalLugar`,`direccionLugar`),
  CONSTRAINT `terrenoLugar` FOREIGN KEY (`codigoPostalLugar`, `direccionLugar`) REFERENCES `lugares` (`codigoPostal`, `direccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terrenos`
--

LOCK TABLES `terrenos` WRITE;
/*!40000 ALTER TABLE `terrenos` DISABLE KEYS */;
INSERT INTO `terrenos` VALUES (40000,'San Carlos');
/*!40000 ALTER TABLE `terrenos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `idNegocio` int(11) NOT NULL,
  `codigoPostalLugar` int(11) DEFAULT NULL,
  `direccionLugar` varchar(45) DEFAULT NULL,
  `precioTotal` int(11) DEFAULT NULL,
  `entregaRestante` int(11) DEFAULT NULL,
  `entregaInicial` int(11) DEFAULT NULL,
  PRIMARY KEY (`idNegocio`),
  KEY `ventaLugar_idx` (`codigoPostalLugar`,`direccionLugar`),
  CONSTRAINT `ventaNegocio` FOREIGN KEY (`idNegocio`) REFERENCES `negocios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ventaLugar` FOREIGN KEY (`codigoPostalLugar`, `direccionLugar`) REFERENCES `lugares` (`codigoPostal`, `direccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (1,14000,'Positos',60000,40000,10000),(2,19000,'Piriapolis',53000,40000,10300),(3,20000,'Centro',20000,10000,10000),(4,20000,'Centro',35000,10000,5000),(5,20100,'Punta del este',210000,200000,10000),(6,40000,'San Carlos',10000,8000,2000);
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

-- Dump completed on 2017-11-22 18:19:13
