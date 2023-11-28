CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS arbys(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        name CHAR(225) NOT NULL,
        numberOfMeats INT NOT NULL,
        calories INT NOT NULL,
        menuItem ENUM('1', '2', '3', '4', '5', '6', '7') NOT NULL
    ) default charset utf8 COMMENT '';

INSERT INTO
    arbys (
        name,
        `numberOfMeats`,
        calories,
        `menuItem`
    )
VALUES ("Roast Beef aujus", 1, 700, 4)

SELECT * FROM arbys