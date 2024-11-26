-- lab4
-- a. вывести набор строк, 
-- удовлетворяющих определенному условию; 
SELECT * FROM Client
WHERE loyalty_points > 100;

SELECT * FROM Client WHERE TRIM(first_name) LIKE 'Пр%';
-- b Вывести набор строк, 
-- отсортированных по определенному полю по возрастанию и по убыванию;
SELECT first_name, last_name, loyalty_points
FROM Client
ORDER BY loyalty_points DESC;

SELECT * FROM Receipt
ORDER BY total_price;

-- c. продемонстрировать результат группировки;
SELECT release_year, COUNT(*)
FROM Product
GROUP BY release_year;

SELECT seller_id, AVG(total_price)
FROM Receipt
GROUP BY seller_id;

-- d. продемонстрировать работу с операторами обработки атрибутов текста;
SELECT * FROM Artist
WHERE name LIKE 'Р%';

SELECT first_name, second_name FROM Actor
WHERE first_name LIKE 'Р_йан';

-- e. продемонстрировать работу с операторами обработки атрибутов даты;
SELECT * FROM Client
WHERE registration_date >= '2023-01-01' AND registration_date < '2024-01-01';

SELECT * FROM Receipt
WHERE AGE(NOW(), date) < INTERVAL '3 year';

-- lab5
-- a. продемонстрировать работу различных типов соединений; 
SELECT c.first_name, c.last_name, r.total_price
FROM Client c
INNER JOIN Receipt r ON c.ID = r.client_id;

SELECT fs.name AS studio, COUNT(p.ID) AS films
FROM filmstudio fs
LEFT JOIN productvideo pv ON fs.ID = pv.film_studio
LEFT JOIN product p ON pv.product_id = p.ID
GROUP BY fs.name;

SELECT r.ID, r.total_price, c.first_name, c.last_name
FROM Receipt r
RIGHT JOIN Client c ON r.client_id = c.ID;

SELECT p.name AS product_name, ga.name AS genre_audio_name
FROM Product p
FULL OUTER JOIN ProductAudio pa ON p.ID = pa.product_id
FULL OUTER JOIN GenreAudio ga ON pa.genre_id = ga.ID;

-- b. сформировать набор данных из нескольких таблиц (3-х и более)
-- с помощью оператора соединения; 
SELECT 
    c.first_name AS client_first_name,
    c.last_name AS client_last_name,
    r.ID AS receipt_id,
    r.total_price AS receipt_total_price,
    p.name AS product_name,
    rl.rental_time AS rental_duration
FROM Client c
JOIN Receipt r ON c.ID = r.client_id
JOIN ReceiptLine rl ON r.ID = rl.receipt_id
JOIN Product p ON rl.product_id = p.ID;

-- c. продемонстрировать результат группировки данных из нескольких таблиц;
SELECT 
    c.first_name AS client_first_name,
    c.last_name AS client_last_name,
    COUNT(rl.product_id) AS total_products_purchased,
    SUM(r.total_price) AS total_spent
FROM Client c
JOIN Receipt r ON c.ID = r.client_id
JOIN ReceiptLine rl ON r.ID = rl.receipt_id
GROUP BY c.first_name, c.last_name
ORDER BY total_spent DESC;

-- d. выполнение вложенных запросов: 
-- сформировать набор данных из нескольких таблиц с 
-- помощью вложенных запросов, имеющий два или более уровней вложенности. 
SELECT p.name AS product_name, p.price AS product_price, 
    (
        SELECT fs.name 
        FROM FilmStudio fs 
        JOIN ProductVideo pv ON fs.ID = pv.film_studio 
        WHERE pv.product_id = p.ID
    ) AS film_studio, 
        (
            SELECT gv.name 
            FROM GenreVideo gv 
            JOIN Genre_ProductVideo gpv ON gv.ID = gpv.genre_id 
            WHERE gpv.product_video_id = (
                SELECT pv.product_id 
                FROM ProductVideo pv 
                WHERE pv.product_id = p.ID
        )
    ) AS genre_name
FROM Product p;

-- 6. Создание представлений. 
-- Для обработки табличных данных необходимо разработать следующие 
-- представления и продемонстрировать их выполнение

-- a. сложный синтаксис;
CREATE VIEW ProductVideoView AS
SELECT 
    p.name, 
    p.price, 
    p.total, 
    p.age_rating, 
    p.release_year,
    fs.name AS film_studio,
    gv.name AS genre,
    STRING_AGG(a.first_name || ' ' || a.second_name, ', ') AS actors
FROM product p
INNER JOIN productvideo pv ON pv.product_id = p.ID
INNER JOIN filmstudio fs ON pv.film_studio = fs.ID
INNER JOIN Genre_ProductVideo gpv ON pv.product_id = gpv.product_video_id
INNER JOIN genrevideo gv ON gv.ID = gpv.genre_id
INNER JOIN Actor_ProductVideo apv ON p.ID = apv.product_id
INNER JOIN Actor a ON a.ID = apv.actor_id
GROUP BY 
    p.ID, p.name, p.price, p.total,
    p.age_rating, p.release_year, fs.name, gv.name,
    a.first_name, a.second_name;

SELECT * FROM ProductVideoView;
DROP VIEW ProductVideoView;

-- b. скрытие столбцов и строк. 
CREATE VIEW ReceiptsWithDiscountsView AS
SELECT 
    r.date AS receipt_date,
    r.total_price,
    r.discount
FROM Receipt r
WHERE 
    r.discount IS NOT NULL AND r.discount > 100;

SELECT * FROM ReceiptsWithDiscountsView;
DROP VIEW ReceiptsWithDiscountsView;
