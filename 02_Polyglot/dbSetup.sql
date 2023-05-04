
USE master;
GO

-- Drop the database if it exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'PolyglotNotebookExamples')
    DROP DATABASE PolyglotNotebookExamples;
GO

-- Recreate the database
CREATE DATABASE PolyglotNotebookExamples;
GO

USE PolyglotNotebookExamples
GO

CREATE TABLE dad_jokes (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    joke NVARCHAR(140) NOT NULL,
    punchline NVARCHAR(140) NOT NULL
);
GO

INSERT INTO dad_jokes (joke, punchline)
VALUES
('Why do programmers prefer dark mode?', 'Because light attracts bugs.'),
('Why do programmers always mix up Halloween and Christmas?', 'Because Oct 31 equals Dec 25.'),
('Why did the programmer quit his job?', 'Because they didn''t get arrays.'),
('Why do Java developers wear glasses?', 'Because they can''t C#.'),
('Why was the JavaScript developer sad?', 'Because everything felt so undefined.'),
('Why don''t programmers like nature?', 'It has too many bugs.'),
('Why did the developer go broke?', 'Because they used up all their cache.'),
('Why was the computer cold?', 'Because it left its Windows open.'),
('Why did the programmer get stuck in the shower?', 'Because the instructions on the shampoo bottle said: Lather, Rinse, Repeat.'),
('Why don''t programmers like to swim?', 'Because they might encounter a fatal error.');
GO

SELECT * FROM dad_jokes