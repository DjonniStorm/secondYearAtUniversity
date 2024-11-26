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
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    work_experience INTEGER NOT NULL,
    phone VARCHAR(20) UNIQUE NOT NULL,
    email VARCHAR(50) NOT NULL
);


CREATE TABLE Client (
    ID SERIAL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    phone   VARCHAR(20) UNIQUE NOT NULL,
    email   VARCHAR(50),
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
    release_year INTEGER NOT NULL
);

CREATE TABLE FilmStudio (
    ID SERIAL PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);

CREATE TABLE ProductVideo (
    product_id INTEGER NOT NULL,
    film_studio INTEGER NOT NULL,
    PRIMARY KEY (product_id),
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
    PRIMARY KEY (product_id),
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
    date TIMESTAMP,
    discount FLOAT,
    FOREIGN KEY (client_id) REFERENCES Client(ID),
    FOREIGN KEY (seller_id) REFERENCES Seller(ID)
);

CREATE TABLE ReceiptLine (
    product_id INTEGER NOT NULL,
    receipt_id INTEGER NOT NULL,
    rental_time INTEGER NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(ID),
    FOREIGN KEY (receipt_id) REFERENCES Receipt(ID)
);
