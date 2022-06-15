create database pfr_cases
use pfr_cases

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE `действующие_дела` (
  `номер_дела` int NOT NULL,
  `дата_создания_дела` date NOT NULL,
  `фио` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `дата_рождения` date NOT NULL,
  `вид_начислений` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `снилс` varchar(20) NOT NULL,
  `район_проживания` varchar(65) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `адрес_проживания` varchar(70) NOT NULL,
  `фио_создавшего` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;


CREATE TABLE `пользователи` (
  `id` int NOT NULL,
  `фио_специалиста` varchar(100) CHARACTER SET ucs2 COLLATE ucs2_general_ci NOT NULL,
  `должность` varchar(70) CHARACTER SET ucs2 COLLATE ucs2_general_ci NOT NULL,
  `отдел` varchar(300) CHARACTER SET ucs2 COLLATE ucs2_general_ci NOT NULL,
  `логин` varchar(30) NOT NULL,
  `пароль` varchar(50) NOT NULL,
  `дата_создания` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ucs2;


CREATE TABLE `архивные_дела` (
  `номер_архивного_дела` int NOT NULL,
  `номер_дела` int NOT NULL,
  `фио` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `дата_рождения` date NOT NULL,
  `вид_начислений` varchar(80) NOT NULL,
  `район_проживания` varchar(65) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `адрес_проживания` varchar(70) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `фио_создавшего` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `дата_архивирования` date NOT NULL,
  `причина_архивирования` varchar(60) NOT NULL,
  `фио_архивариуса` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

CREATE TABLE `запросы_архивных_дел` (
  `id` int NOT NULL,
  `дата_передачи_в_отдел` date NOT NULL,
  `фио_специалиста` varchar(50) NOT NULL,
  `дата_повторного_архивирования` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

ALTER TABLE `действующие_дела`
  ADD PRIMARY KEY (`номер_дела`);

ALTER TABLE `пользователи`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `архивные_дела`
  ADD PRIMARY KEY (`номер_архивного_дела`),
  ADD UNIQUE KEY `номер_дела` (`номер_дела`);

ALTER TABLE `запросы_архивных_дел`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `действующие_дела`
  MODIFY `номер_дела` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

ALTER TABLE `пользователи`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `архивные_дела`
  MODIFY `номер_архивного_дела` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `запросы_архивных_дел`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

