CREATE DATABASE Book;
go

CREATE TABLE [dbo].[Book] (
    [Id]          INT           NOT NULL,
    [Titulo]      VARCHAR (50)  NULL,
    [Descripcion] VARCHAR (150) NULL,
    [Autor]       VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
