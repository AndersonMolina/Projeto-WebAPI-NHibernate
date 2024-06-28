Create Table [dbo].[cliente](
	[id] [int] identity(1,1) not null,
	[nome] [varchar](50) null,
	[email] [varchar](50) null,
	[fone] [varchar](30) null
constraint  [pk_cliente] primary key clustered([id] asc)
)

insert into cliente (nome,email,fone) values ('Cronos', 'cronos@email.com', '11 1111-1111')
insert into cliente (nome,email,fone) values ('Mantas', 'mantas@email.com', '22 2222-2222')
insert into cliente (nome,email,fone) values ('Abaddon', 'abaddon@email.com', '33 3333-3333')