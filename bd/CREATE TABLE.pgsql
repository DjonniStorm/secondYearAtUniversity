-- fun
DROP TABLE IF EXISTS CheckLine CASCADE;
DROP TABLE IF EXISTS Artist_ProductAudio CASCADE;
DROP TABLE IF EXISTS ProductAudio CASCADE;
DROP TABLE IF EXISTS VideoGenre CASCADE;
DROP TABLE IF EXISTS ProductVideo CASCADE;
DROP TABLE IF EXISTS GenreVideo CASCADE;
DROP TABLE IF EXISTS Actor_ProductVideo CASCADE;
DROP TABLE IF EXISTS Actor CASCADE;
DROP TABLE IF EXISTS GenreAudio CASCADE;
DROP TABLE IF EXISTS Artist CASCADE;
DROP TABLE IF EXISTS Receipt CASCADE;
DROP TABLE IF EXISTS Client CASCADE;
DROP TABLE IF EXISTS Seller CASCADE;
DROP TABLE IF EXISTS Product CASCADE;
DROP TABLE IF EXISTS FilmStudio CASCADE;
DROP TABLE IF EXISTS Receipt CASCADE;
DROP TABLE IF EXISTS ReceiptLine CASCADE;
DROP TABLE IF EXISTS genre_productvideo CASCADE;
DROP TABLE IF EXISTS tip CASCADE;

CREATE TABLE Seller (
    ID SERIAL PRIMARY KEY,
    first_name VARCHAR(30) NOT NULL,
    last_name VARCHAR(30) NOT NULL,
    work_experience INTEGER NOT NULL,
    phone VARCHAR(20) UNIQUE NOT NULL,
    email VARCHAR(30) NOT NULL
);


CREATE TABLE Client (
    ID SERIAL PRIMARY KEY,
    first_name VARCHAR(30) NOT NULL,
    last_name VARCHAR(30) NOT NULL,
    phone   VARCHAR(20) UNIQUE NOT NULL,
    email   VARCHAR(30),
    registration_date DATE NOT NULL,
    loyalty_points INTEGER NOT NULL DEFAULT 0,
    date_of_birth DATE
);

CREATE TABLE Product (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    price NUMERIC(19, 2) NOT NULL,
    total INTEGER NOT NULL DEFAULT 0,
    available INTEGER NOT NULL DEFAULT 0,
    age_rating SMALLINT NOT NULL,
    release_year DATE NOT NULL
);

CREATE TABLE FilmStudio (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);

CREATE TABLE ProductVideo (
    product_id SERIAL PRIMARY KEY,
    film_studio INTEGER NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(ID),
    FOREIGN KEY (film_studio) REFERENCES FilmStudio(ID)
);

CREATE TABLE GenreVideo (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);

CREATE TABLE Genre_ProductVideo (
    product_video_id INTEGER NOT NULL UNIQUE,
    genre_id INTEGER NOT NULL,
    FOREIGN KEY (product_video_id) REFERENCES ProductVideo(product_id),
    FOREIGN KEY (genre_id) REFERENCES GenreVideo(ID),
    PRIMARY KEY (product_video_id, genre_id)
);




CREATE TABLE Actor (
    ID SERIAL PRIMARY KEY,
    first_name VARCHAR(30) NOT NULL,
    second_name VARCHAR(30) NOT NULL
);

CREATE TABLE Actor_ProductVideo (
    actor_id INTEGER NOT NULL,
    product_id INTEGER NOT NULL,
    FOREIGN KEY (actor_id) REFERENCES Actor(ID),
    FOREIGN KEY (product_id) REFERENCES Product(ID)
);

CREATE TABLE GenreAudio (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(30)
);

CREATE TABLE ProductAudio (
    product_id INTEGER UNIQUE NOT NULL,
    genre_id INTEGER NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(ID),
    FOREIGN KEY (genre_id) REFERENCES GenreAudio(ID)
);

CREATE TABLE Artist (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);

CREATE TABLE Artist_ProductAudio (
    artist_id INTEGER NOT NULL,
    audio_product_id INTEGER NOT NULL,
    FOREIGN KEY (artist_id) REFERENCES Artist(ID),
    FOREIGN KEY (audio_product_id) REFERENCES Product(ID)
);

CREATE TABLE Receipt (
    ID SERIAL PRIMARY KEY,
    client_id INTEGER NOT NULL,
    seller_id INTEGER NOT NULL,
    total_price NUMERIC(19, 2),
    discount FLOAT
);

CREATE TABLE ReceiptLine (
    product_id INTEGER NOT NULL,
    tip_id  INTEGER NOT NULL,
    rental_time INTEGER NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(ID),
    FOREIGN KEY (tip_id) REFERENCES Receipt(ID)
);



INSERT INTO Client(first_name, last_name, phone, email, registration_date, loyalty_points, date_of_birth) VALUES 
('Елизавета', 'Мартынова', '(935)407-73-53', 'Panteleimon9@hotmail.com', '2024-07-06', 12, '2024-05-15'),
('Борис', 'Гущин', '(961)146-88-53', 'Agafon0@yandex.ru', '2024-05-01', 781, '2024-06-09'),
('Кузьма', 'Самойлова', '(948)863-97-99', 'Egor33@yahoo.com', '2024-01-16', 17, '2024-08-27'),
('Ратибор', 'Никифорова', '(947)293-80-17', 'Maksim_Nesterova@yahoo.com', '2024-08-01', 839, '2024-10-15'),
('Галактион', 'Горбачева', '(987)111-64-33', 'Emiluk47@yandex.ru', '2024-10-08', 5, '2024-04-16'),
('Григорий', 'Гущин', '(907)448-89-89', 'Kliment_Davydova83@ya.ru', '2024-08-12', 729, '2024-10-25'),
('Викентий', 'Голубев', '(980)124-57-98', 'Ruslan28@mail.ru', '2024-08-26', 620, '2023-12-16'),
('Фома', 'Меркушев', '(955)970-04-57', 'Viktor_Ermakov@gmail.com', '2024-10-07', 83, '2024-02-12'),
('Ратибор', 'Вишнякова', '(927)169-53-24', 'Ippolit62@hotmail.com', '2023-12-20', 782, '2024-06-06'),
('Руслан', 'Ефимов', '(931)371-39-07', 'Isai_Kolobov@mail.ru', '2024-02-24', 540, '2024-05-04'),
('Ян', 'Кабанов', '(965)630-01-15', 'Sofiya84@mail.ru', '2024-07-09', 516, '2024-06-11'),
('Зинаида', 'Морозова', '(997)782-17-96', 'Vasilisa73@yahoo.com', '2023-11-25', 144, '2024-03-15'),
('Аким', 'Воронцова', '(907)352-91-38', 'Kharlampii78@gmail.com', '2023-12-06', 409, '2024-05-20'),
('Осип', 'Игнатов', '(952)872-94-04', 'Tatukyana.Fedotov6@hotmail.com', '2024-10-29', 742, '2024-05-22'),
('Феоктист', 'Субботина', '(965)280-23-08', 'Anikei33@yahoo.com', '2024-05-16', 29, '2024-06-26'),
('Велимир', 'Уваров', '(940)494-76-31', 'Antonin.Tretukyakova@mail.ru', '2024-10-27', 996, '2024-04-17'),
('Владислав', 'Шестаков', '(923)832-08-17', 'Stoyan.Abramov@yahoo.com', '2023-12-31', 174, '2024-10-12'),
('Ипполит', 'Колесникова', '(984)481-84-10', 'Ipatii.Simonov@yahoo.com', '2024-02-04', 140, '2023-12-12'),
('Орест', 'Михеев', '(942)628-91-40', 'Ustin.Nazarova@gmail.com', '2024-03-18', 857, '2024-04-28'),
('Анжелика', 'Орехов', '(936)925-86-26', 'Izot_Pavlov95@ya.ru', '2024-10-06', 117, '2024-06-27'),
('Елизавета', 'Нестерова', '(963)162-94-33', 'Lora.Semenova88@ya.ru', '2024-08-21', 832, '2024-03-14'),
('Мария', 'Ковалева', '(928)475-81-03', 'Eremei93@yandex.ru', '2024-06-27', 908, '2024-07-23'),
('Матвей', 'Чернова', '(963)474-56-49', 'Stepan59@mail.ru', '2024-10-07', 312, '2024-09-28'),
('Ираклий', 'Ермакова', '(918)648-74-72', 'Evgeniya84@yandex.ru', '2024-04-12', 470, '2024-05-13'),
('Ираида', 'Родионова', '(984)525-42-11', 'Vladilen.Likhacheva61@ya.ru', '2024-08-22', 538, '2023-11-16'),
('Трофим', 'Блинова', '(941)383-26-82', 'Feliks.Kharitonov@gmail.com', '2024-07-04', 437, '2024-09-20'),
('Исай', 'Шестаков', '(955)216-03-36', 'Ilukya.Zimin69@ya.ru', '2024-02-26', 312, '2024-03-06'),
('Ерофей', 'Кириллова', '(961)717-13-82', 'Stoyan.Fokina@yandex.ru', '2024-08-16', 256, '2024-06-01'),
('Демьян', 'Цветков', '(934)353-80-68', 'Valentina_Yakushev1@mail.ru', '2023-12-06', 298, '2024-02-07'),
('Лидия', 'Веселов', '(992)912-69-68', 'Mikhail18@gmail.com', '2024-10-28', 187, '2024-08-23'),
('Модест', 'Никитина', '(919)147-45-80', 'Trifon.Filatov@yahoo.com', '2024-09-03', 441, '2024-08-23'),
('Ульяна', 'Корнилов', '(906)008-56-19', 'Vissarion_Sorokina44@ya.ru', '2024-01-03', 360, '2024-09-13'),
('Мартьян', 'Васильев', '(920)570-39-22', 'Mefodii42@hotmail.com', '2024-05-02', 423, '2024-07-14'),
('Ким', 'Карпов', '(938)225-03-64', 'Ippolit_Lytkin97@mail.ru', '2024-03-08', 629, '2024-05-09'),
('Изяслав', 'Максимов', '(921)918-69-12', 'Spiridon27@hotmail.com', '2024-02-16', 33, '2024-08-23'),
('Трофим', 'Маслов', '(967)728-80-93', 'Antonin_Volkova@hotmail.com', '2024-04-15', 431, '2024-05-18'),
('Аркадий', 'Воронов', '(970)046-21-97', 'Mechislav_Galkin68@yandex.ru', '2024-07-03', 451, '2024-06-06'),
('Нестор', 'Елисеев', '(970)526-91-84', 'Ladimir10@hotmail.com', '2024-07-17', 142, '2024-09-12'),
('Иосиф', 'Сафонова', '(913)602-51-01', 'Lidiya64@gmail.com', '2024-07-03', 595, '2024-01-19'),
('Самуил', 'Королев', '(973)540-79-31', 'Yuvenalii_Silina@yahoo.com', '2024-05-05', 598, '2024-04-18'),
('Алевтина', 'Зиновьева', '(981)121-94-22', 'Boyan.Dmitrieva@yahoo.com', '2024-06-10', 259, '2024-06-15'),
('Надежда', 'Денисов', '(989)214-21-96', 'Fortunat98@ya.ru', '2024-08-20', 630, '2024-06-23'),
('Прасковья', 'Колобов', '(934)790-18-69', 'Epifan47@ya.ru', '2024-01-19', 583, '2024-06-07'),
('Пахом', 'Галкин', '(931)942-15-39', 'Anastasiya92@yahoo.com', '2024-05-12', 50, '2024-07-06'),
('Велимир', 'Гусев', '(906)802-05-53', 'Akulina_Veselova@yandex.ru', '2024-01-16', 804, '2024-02-28'),
('Викторин', 'Дорофеева', '(983)347-53-09', 'Rodion7@yandex.ru', '2024-06-04', 525, '2024-04-13'),
('Людмила', 'Назарова', '(988)358-44-38', 'Budimir_Tretukyakov73@ya.ru', '2024-06-28', 587, '2024-09-29'),
('Трофим', 'Кондратьева', '(928)561-94-90', 'Filipp29@gmail.com', '2024-02-20', 305, '2024-05-12'),
('Прасковья', 'Тетерин', '(940)266-34-53', 'Tit.Shashkova24@ya.ru', '2023-11-13', 762, '2024-08-30'),
('Исидор', 'Якушева', '(925)447-21-03', 'Denis87@yandex.ru', '2023-11-03', 470, '2024-10-05');

SELECT * FROM client;

INSERT INTO FilmStudio(name) Values
('Warner Bros.'),
('20th Century Fox'),
('Universal Pictures'),
('Paramount Pictures'),
('Columbia Pictures'),
('Walt Disney Pictures'),
('Sony Pictures'),
('Metro-Goldwyn-Mayer (MGM)'),
('DreamWorks Pictures'),
('New Line Cinema'),
('Lionsgate'),
('Focus Features'),
('A24'),
('Pixar Animation Studios'),
('Illumination Entertainment'),
('Studio Ghibli'),
('Legendary Pictures'),
('Regency Enterprises'),
('Amblin Entertainment'),
('Miramax');

SELECT * FROM filmstudio;

INSERT INTO GenreVideo(name) Values
('Драма'),
('Комедия'),
('Ужасы'),
('Фантастика'),
('Фэнтези'),
('Приключения'),
('Экшн'),
('Романтика'),
('Триллер'),
('Мелодрама'),
('Документальный'),
('Биография'),
('Музыкальный'),
('Исторический'),
('Семейный'),
('Спорт'),
('Криминал'),
('Антиутопия'),
('Артхаус'),
('Анимация');

INSERT INTO Product (name, price, total, available, age_rating, release_year) VALUES 
('The Dark Side of the Moon', 371, 26, 18, 6, '2024-7-10'),
('Back in Black', 248, 48, 19, 6),
('The Marshall Mathers LP', 328, 44, 24, 6),
('Hybrid Theory', 329, 21, 18, 16),
('Appetite for Destruction', 133, 36, 16, 0),
('Платина', 242, 34, 21, 16),
('Nevermind', 271, 32, 5, 21),
('The Eminem Show', 172, 27, 23, 0),
('A Night at the Opera', 282, 15, 8, 18),
('The Chronic', 306, 16, 10, 6),
('American Idiot', 52, 39, 37, 6),
('21 Savage', 189, 22, 12, 21),
('The Black Album', 330, 10, 6, 12),
('Dookie', 387, 18, 14, 16),
('The Wall', 281, 37, 5, 6),
('In the Aeroplane Over the Sea', 113, 21, 2, 21),
('The Slim Shady LP', 169, 28, 19, 12),
('The Life of Pablo', 133, 22, 16, 6),
('Lateralus', 136, 15, 10, 16),
('The Colour and the Shape', 224, 47, 36, 6),
('Интерстеллар', 187, 50, 9, 16),
('Бегущий по лезвию 2049', 297, 21, 0, 0),
('Матрица', 257, 43, 17, 18),
('Начало', 162, 44, 12, 18),
('Прибытие', 398, 47, 4, 0),
('Из машины', 281, 24, 21, 16),
('Гравитация', 283, 23, 12, 12),
('Война миров', 361, 25, 14, 12),
('В меньшинстве', 287, 36, 4, 12),
('Граница будущего', 62, 24, 19, 6),
('Вспомнить всё', 285, 45, 37, 16),
('Пятый элемент', 157, 40, 4, 6),
('Аннигиляция', 82, 46, 45, 6),
('Элизиум', 223, 48, 1, 6),
('Обливион', 208, 13, 4, 12),
('Марсианин', 275, 24, 18, 12),
('Я, робот', 229, 33, 16, 18),
('Люди в чёрном (все части, кроме 4)', 306, 46, 45, 6),
('Мстители 1', 250, 12, 10, 21),
('Железный человек 1', 258, 45, 2, 6),
('Пираты Карибского моря: Проклятие Чёрной жемчужины', 99, 40, 8, 12),
('Терминатор', 100, 16, 0, 21),
('Терминатор 2: Судный день', 156, 25, 5, 0),
('Робокоп', 273, 50, 29, 12),
('Район №9', 273, 46, 11, 16),
('Назад в будущее 1', 71, 28, 4, 12),
('Назад в будущее 2', 339, 19, 12, 21),
('Назад в будущее 3', 85, 12, 4, 18),
('Драйв', 320, 15, 10, 6),
('Хоббит: Битва пяти воинств', 66, 46, 25, 6);




INSERT INTO ProductVideo(film_studio) VALUES
(25),
(26),
(27),
(28),
(29),
(30),
(31),
(32),
(33),
(34),
(35),
(36),
(37),
(38),
(39),
(40),
(41),
(42),
(43),
(44),
(45),
(46),
(47),
(48),
(49);


SELECT * FROM genrevideo;

INSERT INTO Genre_ProductVideo(product_video_id, genre_id) VALUES
(25, 3),
(26, 20),
(27, 19),
(28, 15),
(29, 21),
(30, 20),
(31, 21),
(32, 14),
(33, 12),
(34, 7),
(35, 18),
(36, 16),
(37, 6),
(38, 12),
(39, 15),
(40, 2),
(41, 5),
(42, 14),
(43, 17),
(44, 12),
(45, 14),
(46, 19),
(47, 18),
(48, 16),
(49, 8);

SELECT * FROM genre_productvideo;

SELECT * FROM ProductVideo;
