-- Tao database trong PostgreSQL truoc: lesson5mvc
-- Sau do chon database lesson5mvc va chay phan SQL ben duoi.

DROP TABLE IF EXISTS product;

CREATE TABLE product (
    id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name VARCHAR(200) NOT NULL,
    price NUMERIC(18, 2) NOT NULL
);

INSERT INTO product (name, price) VALUES
('Laptop', 15000000),
('Ban phim', 500000),
('Chuot', 300000),
('Tai nghe', 800000),
('Man hinh', 4500000);

SELECT * FROM product ORDER BY id;
