CREATE DATABASE IF NOT EXISTS ForFans CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE ForFans;

CREATE TABLE Users (
    id             INT PRIMARY KEY AUTO_INCREMENT,
    name           VARCHAR(100) NOT NULL,
    email          VARCHAR(150) UNIQUE NOT NULL,
    passwordHash   VARCHAR(255) NOT NULL,
    role           ENUM('subscriber', 'creator', 'admin') NOT NULL DEFAULT 'subscriber',
    profilePicture VARCHAR(500),
    bio            TEXT,
    active         BOOLEAN NOT NULL DEFAULT TRUE,
    createdAt      DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3)
);

CREATE TABLE SubscriptionPlan (
    id           INT PRIMARY KEY AUTO_INCREMENT,
    creatorId    INT NOT NULL,
    name         VARCHAR(100) NOT NULL,
    description  TEXT,
    price        DECIMAL(10,2) NOT NULL,
    durationDays INT NOT NULL DEFAULT 30,
    active       BOOLEAN NOT NULL DEFAULT TRUE,
    createdAt    DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    FOREIGN KEY (creatorId) REFERENCES Users(id)
);

CREATE TABLE Subscription (
    id           INT PRIMARY KEY AUTO_INCREMENT,
    subscriberId INT NOT NULL,
    creatorId    INT NOT NULL,
    planId       INT NOT NULL,
    startDate    DATETIME NOT NULL,
    endDate      DATETIME NOT NULL,
    status       ENUM('active', 'expired', 'canceled') NOT NULL DEFAULT 'active',
    createdAt    DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    FOREIGN KEY (subscriberId) REFERENCES Users(id),
    FOREIGN KEY (creatorId)    REFERENCES Users(id),
    FOREIGN KEY (planId)       REFERENCES SubscriptionPlan(id)
);

CREATE TABLE Content (
    id           INT PRIMARY KEY AUTO_INCREMENT,
    creatorId    INT NOT NULL,
    title        VARCHAR(200) NOT NULL,
    description  TEXT,
    type         ENUM('photo', 'video') NOT NULL,
    fileUrl      VARCHAR(500) NOT NULL,
    thumbnailUrl VARCHAR(500),
    active       BOOLEAN NOT NULL DEFAULT TRUE,
    createdAt    DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    FOREIGN KEY (creatorId) REFERENCES Users(id)
);

-- Which plans unlock which content
CREATE TABLE ContentPlan (
    planId    INT NOT NULL,
    contentId INT NOT NULL,
    PRIMARY KEY (planId, contentId),
    FOREIGN KEY (planId)    REFERENCES SubscriptionPlan(id),
    FOREIGN KEY (contentId) REFERENCES Content(id)
);

CREATE TABLE LikeContent (
    id        INT PRIMARY KEY AUTO_INCREMENT,
    userId    INT NOT NULL,
    contentId INT NOT NULL,
    createdAt DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    UNIQUE KEY uq_like (userId, contentId),
    FOREIGN KEY (userId)    REFERENCES Users(id),
    FOREIGN KEY (contentId) REFERENCES Content(id)
);