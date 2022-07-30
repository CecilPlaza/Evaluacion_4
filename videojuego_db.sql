-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 31-07-2022 a las 00:16:12
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.0.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `videojuego_db`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `companiavideojuego`
--

CREATE TABLE `companiavideojuego` (
  `Id` int(11) NOT NULL,
  `Fundado` date NOT NULL,
  `DominaMercado` tinyint(1) NOT NULL,
  `AnioIndustria` int(11) NOT NULL,
  `NombreCompania` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `companiavideojuego`
--

INSERT INTO `companiavideojuego` (`Id`, `Fundado`, `DominaMercado`, `AnioIndustria`, `NombreCompania`) VALUES
(1, '1889-09-23', 1, 133, 'Nintendo'),
(2, '2022-12-03', 1, 28, 'PlayStation (Sony)'),
(3, '2001-11-15', 1, 48, 'Microsoft Xbox'),
(4, '1969-03-21', 1, 53, 'Konami Holdings Corp');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `videojuego`
--

CREATE TABLE `videojuego` (
  `Id` int(11) NOT NULL,
  `Compania_id` int(11) NOT NULL,
  `NombreVideojuego` varchar(50) NOT NULL,
  `CopiasVendidas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `videojuego`
--

INSERT INTO `videojuego` (`Id`, `Compania_id`, `NombreVideojuego`, `CopiasVendidas`) VALUES
(1, 1, 'Mario Kart 8 Deluxe', 45),
(2, 2, 'Horizon Zero Dawn', 20),
(3, 3, 'PlayerUnknown\'s Battlegrounds', 9),
(4, 1, 'Animal Crossing: New Horizons', 38),
(5, 2, 'God of War', 19),
(6, 3, 'Grand Theft Auto V', 9),
(7, 1, 'Super Smash Bros. Ultimate', 28),
(8, 2, 'Uncharted 4: A Thief\'s End', 16),
(9, 3, 'Call of Duty: Black Ops III', 7),
(10, 1, 'The Legend of Zelda: Breath of the Wild', 26),
(11, 2, 'Call of Duty: Black Ops III', 15),
(12, 3, 'Halo 5: Guardians', 6),
(13, 1, 'Pokemon Espada /  Escudo', 24),
(14, 2, 'Red Dead Redemption 2', 14),
(15, 3, 'Call of Duty: WWII', 6),
(16, 1, 'Super Mario Odyssey', 23),
(17, 2, 'Marvel\'s Spider-Man', 13),
(18, 3, 'Minecraft: Xbox One Edition', 5),
(19, 1, 'Super Mario Party', 17),
(20, 2, 'FIFA 18', 11),
(21, 3, 'Gears 5', 3),
(22, 1, 'Pokemon Brilliant Diamond / Shining Pearl', 14),
(23, 2, 'The Last of Us Remastered', 12),
(24, 3, 'Battlefield 1', 5),
(25, 1, 'Pokemon: Let’s Go, Pikachu! / Eevee!', 14),
(26, 2, 'The Witcher 3: Wild Hunt', 11),
(27, 3, 'Star Wars: Battlefront', 4),
(28, 1, 'Ring Fit Adventure', 14),
(29, 2, 'Ghost of Tsushima', 10),
(30, 3, 'Assassin\'s Creed: Unity', 4);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `companiavideojuego`
--
ALTER TABLE `companiavideojuego`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `videojuego`
--
ALTER TABLE `videojuego`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Compania_id` (`Compania_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `companiavideojuego`
--
ALTER TABLE `companiavideojuego`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `videojuego`
--
ALTER TABLE `videojuego`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `videojuego`
--
ALTER TABLE `videojuego`
  ADD CONSTRAINT `videojuego_ibfk_1` FOREIGN KEY (`Compania_id`) REFERENCES `companiavideojuego` (`Id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
