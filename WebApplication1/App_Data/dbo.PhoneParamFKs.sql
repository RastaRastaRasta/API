CREATE TABLE [dbo].[PhoneParam] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [MobilePhoneId] UNIQUEIDENTIFIER NOT NULL,
    [Param]         INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_PhoneParam_ToMobilePhone] FOREIGN KEY ([MobilePhoneId]) REFERENCES [MobilePhone]([id]), 
    CONSTRAINT [FK_PhoneParam_ToParams] FOREIGN KEY ([Param]) REFERENCES [Params]([id])
);

