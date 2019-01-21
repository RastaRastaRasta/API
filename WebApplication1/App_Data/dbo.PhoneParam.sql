CREATE TABLE [dbo].[PhoneParam] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [MobilePhoneId] UNIQUEIDENTIFIER NOT NULL,
    [Param]         text              NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

