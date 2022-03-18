CREATE TABLE [tbl_LogErrorTest] (
    Sno int IDENTITY(1,1) PRIMARY KEY,
    UserId int NOT NULL,
    ErrorMessage varchar(MAX) ,
	[GenerationDate] [datetime] 
)

ALTER TABLE [dbo].[tbl_LogErrorTest] ADD  DEFAULT (getdate()) FOR [GenerationDate]
GO

 ALTER proc [dbo].[INSERT_LogErrorTest]  
 @UserId int,
 @ErrorMessage nvarchar(MAx)
as                                                                              
begin                                                                              
                                                                              
insert into tbl_LogErrorTest (UserId, ErrorMessage) values (@UserId, @ErrorMessage)
                                        
end 