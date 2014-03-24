CREATE TABLE[dbo].[Setting]
(
[Id] INT NOT NULL IDENTITY(1,1),
[Key] VARCHAR(50) NOT NULL,
[Value] VARCHAR(500) NULL,
CONSTRAINT [PK_Setting] PRIMARY KEY ([Id])
);

CREATE TABLE [dbo].[PetType]
(
[PetTypeID] INT NOT NULL IDENTITY(1,1),
[PetTypeDescription] VARCHAR(50) NULL,
CONSTRAINT [PK_PetType] PRIMARY KEY ([PetTypeID])
);

CREATE TABLE [dbo].[Status]
(
[StatusID] INT NOT NULL IDENTITY(1,1),
[Description] VARCHAR (50) NOT NULL,
CONSTRAINT [PK_Status] PRIMARY KEY ([StatusID])
);

CREATE TABLE [dbo].[Pet]
(
[PetID] INT NOT NULL IDENTITY(1,1),
[PetName] VARCHAR(100) NOT NULL,
[PetAgeYears] INT NULL,
[PetAgeMonths] INT NULL,
[StatusID] INT NOT NULL,
[LastSeenOn] DATE NULL,
[LastSeenWhere] VARCHAR(500) NULL,
[Notes] VARCHAR(1500) NULL,
[UserId] INT NOT NULL,
CONSTRAINT [PK_Pet] PRIMARY KEY ([PetID]),
CONSTRAINT [FK_Pet_Status] FOREIGN KEY ([StatusID])
 REFERENCES [Status] ([StatusID]),
 CONSTRAINT [FK_Pet_User] FOREIGN KEY ([UserId])
   REFERENCES [UserProfile] ([UserId])
);

CREATE TABLE [dbo].[PetPhoto]
(
[PhotoID] INT NOT NULL IDENTITY(1,1),
[PetID] INT NOT NULL,
 CONSTRAINT [DF_PhotoFile] DEFAULT '/content/pets/no-image.png',
 [Notes] VARCHAR(500) NULL,
 CONSTRAINT [PK_PetPhoto] PRIMARY KEY ([PhotoID]),
 CONSTRAINT [FK_PetPhoto_Pet] FOREIGN KEY ([PetID])
   REFERENCES [Pet] ([PetID])
);