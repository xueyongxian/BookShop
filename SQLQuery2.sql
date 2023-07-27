CREATE TABLE [dbo].[BookTb1] (
    [Bid]     INT            IDENTITY (100, 1) NOT NULL,
    [Btitle]  NVARCHAR(100) NOT NULL,
    [Bauthor] NVARCHAR(50) NOT NULL,
    [Bcat]    NVARCHAR(50)            NOT NULL,
    [Bqty]    INT            NOT NULL,
    [Bprice]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Bid] ASC)
);