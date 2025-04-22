-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Фев 02 2023 г., 20:37
-- Версия сервера: 10.4.27-MariaDB
-- Версия PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `pizza`
--

-- --------------------------------------------------------

--
-- Структура таблицы `category`
--

CREATE TABLE `category` (
  `Kod_Category` int(2) NOT NULL,
  `Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `category`
--

INSERT INTO `category` (`Kod_Category`, `Name`) VALUES
(1, 'Пиццы'),
(2, 'Напитки'),
(3, 'Десерт');

-- --------------------------------------------------------

--
-- Структура таблицы `dolzhnosty`
--

CREATE TABLE `dolzhnosty` (
  `Kod_Dolzhnosty` int(3) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Oklad` int(6) NOT NULL,
  `Login` varchar(20) DEFAULT NULL,
  `Parol` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `dolzhnosty`
--

INSERT INTO `dolzhnosty` (`Kod_Dolzhnosty`, `Name`, `Oklad`, `Login`, `Parol`) VALUES
(1, 'Менеджер', 40000, 'men', '11'),
(2, 'Старший менеджер', 45000, 'StMen', '11'),
(3, 'Доставщик', 35000, NULL, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `dostavka`
--

CREATE TABLE `dostavka` (
  `Kod_Dostavky` int(10) NOT NULL,
  `Familiya` varchar(20) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Ulitsa` varchar(20) NOT NULL,
  `Dom` int(5) NOT NULL,
  `Kvartira` int(5) NOT NULL,
  `Kod_Dostavshika` int(11) NOT NULL,
  `Status_Dostavki` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `dostavka`
--

INSERT INTO `dostavka` (`Kod_Dostavky`, `Familiya`, `Name`, `Ulitsa`, `Dom`, `Kvartira`, `Kod_Dostavshika`, `Status_Dostavki`) VALUES
(29, 'Пошутилкина', 'Юлия', 'Михайловна', 1, 2, 3, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `menu`
--

CREATE TABLE `menu` (
  `Kod_Bluda` int(3) NOT NULL,
  `Kod_Kategory` int(2) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Kkal` int(4) NOT NULL,
  `Ves` int(4) NOT NULL,
  `Cena` int(5) NOT NULL,
  `prodazha` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `menu`
--

INSERT INTO `menu` (`Kod_Bluda`, `Kod_Kategory`, `Name`, `Kkal`, `Ves`, `Cena`, `prodazha`) VALUES
(1, 1, 'Маргаритта', 208, 1000, 800, 1),
(2, 1, 'Сан-Диего', 300, 800, 1100, 1),
(3, 1, 'Гавайская', 280, 900, 1000, 1),
(4, 1, 'Фирменная', 310, 1000, 1500, 1),
(8, 1, 'Мясная', 300, 400, 800, 1),
(15, 1, 'Мясное ассорти', 300, 500, 600, 1),
(20, 1, 'Мексиканская', 200, 400, 500, 1),
(31, 3, 'Муравейник', 200, 100, 150, 1),
(32, 2, 'Кола', 40, 250, 150, 1),
(33, 2, 'Спрайт', 20, 250, 150, 1),
(34, 2, 'Морс', 20, 250, 100, 1),
(35, 3, 'Птичье молочко', 90, 100, 100, 0),
(36, 1, 'Re', 1, 1, 1, 1),
(37, 1, 'ww', 2, 2, 2, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `oplata`
--

CREATE TABLE `oplata` (
  `Kod_Oplaty` int(10) NOT NULL,
  `Summa` int(5) NOT NULL,
  `Beznalich` tinyint(1) NOT NULL,
  `Status_Oplaty` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `oplata`
--

INSERT INTO `oplata` (`Kod_Oplaty`, `Summa`, `Beznalich`, `Status_Oplaty`) VALUES
(111, 0, 0, 0),
(112, 1250, 0, 0),
(113, 2200, 1, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `personal`
--

CREATE TABLE `personal` (
  `Kod_Sotrudnika` int(3) NOT NULL,
  `Kod_Dolzhnosty` int(3) NOT NULL,
  `Familiya` varchar(20) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Otchestvo` varchar(20) NOT NULL,
  `Data_rozhdeniya` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `personal`
--

INSERT INTO `personal` (`Kod_Sotrudnika`, `Kod_Dolzhnosty`, `Familiya`, `Name`, `Otchestvo`, `Data_rozhdeniya`) VALUES
(1, 1, 'Филипов', 'Артем', 'Юрьевич', '1990-03-04'),
(2, 2, 'Иванов', 'Иван', 'Иванович', '1980-01-02'),
(3, 3, 'Азанов', 'Антон', 'Максимович', '2000-08-03');

-- --------------------------------------------------------

--
-- Структура таблицы `sclad`
--

CREATE TABLE `sclad` (
  `Kod_Indredienta` int(3) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Kolichestvo` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `sclad`
--

INSERT INTO `sclad` (`Kod_Indredienta`, `Name`, `Kolichestvo`) VALUES
(1, 'Помидоры', NULL),
(2, 'Ананасы', NULL),
(3, 'Персики', NULL),
(4, 'Сыр Моцарелла', NULL),
(5, 'Майонез', NULL),
(6, 'Кетчуп', NULL),
(7, 'Ветчина', NULL),
(8, 'Зелень', NULL),
(9, 'Баклажаны', NULL),
(10, 'Базилик', NULL),
(11, 'Тесто', NULL),
(12, 'Сахар', NULL),
(13, 'Соль', NULL),
(14, 'Кола', NULL),
(15, 'Спрайт', NULL),
(25, 'Морс', NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `sostav`
--

CREATE TABLE `sostav` (
  `Kod_Bluda` int(3) NOT NULL,
  `Kod_Indredienta` int(3) DEFAULT NULL,
  `Kolichestvo` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `sostav`
--

INSERT INTO `sostav` (`Kod_Bluda`, `Kod_Indredienta`, `Kolichestvo`) VALUES
(1, 1, 1),
(1, 6, 10),
(1, 5, 10),
(2, 2, 1),
(2, 3, 2),
(2, 11, 1),
(1, 11, 1),
(3, 2, 1),
(3, 3, 1),
(3, 9, 1),
(3, 1, 1),
(4, 2, 1),
(4, 6, 10),
(4, 7, 20),
(4, 8, 10),
(20, 1, 30),
(20, 11, 300),
(20, 5, 35),
(20, 6, 35),
(8, 10, 10),
(8, 2, 1),
(8, 11, 0),
(31, 11, 70),
(31, 12, 20),
(31, 13, 5),
(31, 3, 15),
(32, 14, 250),
(33, 15, 250),
(34, 25, 250),
(35, 11, 70),
(35, 12, 15),
(35, 13, 2),
(36, 2, 1),
(37, 2, 2),
(37, 2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `str_zakaza`
--

CREATE TABLE `str_zakaza` (
  `Kod_Zakaza` int(10) NOT NULL,
  `Kod_Bluda` int(3) NOT NULL,
  `Kolichestvo_Porciy` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `str_zakaza`
--

INSERT INTO `str_zakaza` (`Kod_Zakaza`, `Kod_Bluda`, `Kolichestvo_Porciy`) VALUES
(112, 2, 1),
(112, 32, 1),
(113, 33, 2),
(113, 31, 2),
(113, 1, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `zakazy`
--

CREATE TABLE `zakazy` (
  `Kod_Zakaza` int(10) NOT NULL,
  `Kod_Oplaty` int(10) NOT NULL,
  `Kod_Menedzhera` int(3) NOT NULL,
  `Kod_Dostavky` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `zakazy`
--

INSERT INTO `zakazy` (`Kod_Zakaza`, `Kod_Oplaty`, `Kod_Menedzhera`, `Kod_Dostavky`) VALUES
(112, 112, 1, NULL),
(113, 113, 1, 29);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`Kod_Category`);

--
-- Индексы таблицы `dolzhnosty`
--
ALTER TABLE `dolzhnosty`
  ADD PRIMARY KEY (`Kod_Dolzhnosty`);

--
-- Индексы таблицы `dostavka`
--
ALTER TABLE `dostavka`
  ADD PRIMARY KEY (`Kod_Dostavky`),
  ADD KEY `Kod_Dostavshika` (`Kod_Dostavshika`);

--
-- Индексы таблицы `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`Kod_Bluda`),
  ADD KEY `Kod_Kategory` (`Kod_Kategory`);

--
-- Индексы таблицы `oplata`
--
ALTER TABLE `oplata`
  ADD PRIMARY KEY (`Kod_Oplaty`);

--
-- Индексы таблицы `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`Kod_Sotrudnika`),
  ADD KEY `Kod_Dolzhnosty` (`Kod_Dolzhnosty`);

--
-- Индексы таблицы `sclad`
--
ALTER TABLE `sclad`
  ADD PRIMARY KEY (`Kod_Indredienta`);

--
-- Индексы таблицы `sostav`
--
ALTER TABLE `sostav`
  ADD KEY `Kod_Bluda` (`Kod_Bluda`,`Kod_Indredienta`),
  ADD KEY `Kod_Indredienta` (`Kod_Indredienta`);

--
-- Индексы таблицы `str_zakaza`
--
ALTER TABLE `str_zakaza`
  ADD KEY `Kod_Zakaza` (`Kod_Zakaza`,`Kod_Bluda`),
  ADD KEY `Kod_Bluda` (`Kod_Bluda`);

--
-- Индексы таблицы `zakazy`
--
ALTER TABLE `zakazy`
  ADD PRIMARY KEY (`Kod_Zakaza`),
  ADD KEY `Kod_Oplaty` (`Kod_Oplaty`,`Kod_Menedzhera`,`Kod_Dostavky`),
  ADD KEY `Kod_Dostavky` (`Kod_Dostavky`),
  ADD KEY `Kod_Menedzhera` (`Kod_Menedzhera`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `category`
--
ALTER TABLE `category`
  MODIFY `Kod_Category` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `dolzhnosty`
--
ALTER TABLE `dolzhnosty`
  MODIFY `Kod_Dolzhnosty` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `dostavka`
--
ALTER TABLE `dostavka`
  MODIFY `Kod_Dostavky` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT для таблицы `menu`
--
ALTER TABLE `menu`
  MODIFY `Kod_Bluda` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT для таблицы `oplata`
--
ALTER TABLE `oplata`
  MODIFY `Kod_Oplaty` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;

--
-- AUTO_INCREMENT для таблицы `personal`
--
ALTER TABLE `personal`
  MODIFY `Kod_Sotrudnika` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `sclad`
--
ALTER TABLE `sclad`
  MODIFY `Kod_Indredienta` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `zakazy`
--
ALTER TABLE `zakazy`
  MODIFY `Kod_Zakaza` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `dostavka`
--
ALTER TABLE `dostavka`
  ADD CONSTRAINT `dostavka_ibfk_1` FOREIGN KEY (`Kod_Dostavshika`) REFERENCES `personal` (`Kod_Sotrudnika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`Kod_Kategory`) REFERENCES `category` (`Kod_Category`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `personal`
--
ALTER TABLE `personal`
  ADD CONSTRAINT `personal_ibfk_1` FOREIGN KEY (`Kod_Dolzhnosty`) REFERENCES `dolzhnosty` (`Kod_Dolzhnosty`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `sostav`
--
ALTER TABLE `sostav`
  ADD CONSTRAINT `sostav_ibfk_1` FOREIGN KEY (`Kod_Bluda`) REFERENCES `menu` (`Kod_Bluda`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `sostav_ibfk_2` FOREIGN KEY (`Kod_Indredienta`) REFERENCES `sclad` (`Kod_Indredienta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `str_zakaza`
--
ALTER TABLE `str_zakaza`
  ADD CONSTRAINT `str_zakaza_ibfk_2` FOREIGN KEY (`Kod_Zakaza`) REFERENCES `zakazy` (`Kod_Zakaza`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `str_zakaza_ibfk_3` FOREIGN KEY (`Kod_Bluda`) REFERENCES `menu` (`Kod_Bluda`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `zakazy`
--
ALTER TABLE `zakazy`
  ADD CONSTRAINT `zakazy_ibfk_1` FOREIGN KEY (`Kod_Oplaty`) REFERENCES `oplata` (`Kod_Oplaty`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `zakazy_ibfk_2` FOREIGN KEY (`Kod_Dostavky`) REFERENCES `dostavka` (`Kod_Dostavky`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `zakazy_ibfk_3` FOREIGN KEY (`Kod_Menedzhera`) REFERENCES `personal` (`Kod_Sotrudnika`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
