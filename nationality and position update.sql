USE [FOOTBALL_CLUB]
GO

DROP TABLE Nationality;
GO

DROP TABLE Position;
GO

ALTER TABLE Football_Player
ADD Nationality nvarchar(50);
GO
ALTER TABLE Football_Player
ADD Position nvarchar(50);
GO
