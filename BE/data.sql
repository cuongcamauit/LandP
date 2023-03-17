USE [LandP]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'05637849-2dc3-4a9c-97ac-547ec7ae9264', N'User', N'User', N'2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1537a967-584d-45e7-b5ce-b7c852c9319f', N'Admin', N'Admin', N'1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2d5d9280-dcc9-434b-834a-a1fec31498d2', N'SuperAdmin', N'SuperAdmin', N'0')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'358c295a-2b62-4dac-9949-0b0a1212422c', N'Samsung', N'A branch from korea', N'https://drive.google.com/uc?export=view&id=1JrfIHh1Fi9aM66IMLd2jdZwurx1As6x0')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'0ce12680-8aeb-4b85-99bb-6d7579b93d87', N'Iphone', N'A branch from Ameria', N'https://drive.google.com/uc?export=view&id=1DfzKYG8dsu0C0tNK_5U8GNBM3IE92fsz')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'e3adbae4-a890-4238-9477-400010e06131', N'Smartphone', N'A smart device', N'https://drive.google.com/uc?export=view&id=1VPowiqiVfyuL7Pzntp1mqJV748v34zfb')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'1dac054a-9a42-471d-991f-4d0eb158f068', N'Laptop', N'A smart device', N'https://drive.google.com/uc?export=view&id=15Lo6BabMJo7m9p-VSve4kls1pG2VA1AN')
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [PercentSale], [AverageRating], [SoldQuantity], [CategoryId], [BrandId]) VALUES (N'8af7b29a-fbf9-469c-ec54-08db26ca2f8c', N'Samsung Galaxy S23+ 5G', N'Chip xử lý (CPU):Snapdragon 8 Gen 2 8 nhân 
Tốc độ CPU:1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz', 23000000, N'https://drive.google.com/uc?export=view&id=1fup8tq4WXahlTispGisiFtZc1-bJifLM', N'1zre7ftkUTL5-w7AZgkpyEvKLgrxNorz_', N'string', 100, 2, 0, 0, N'e3adbae4-a890-4238-9477-400010e06131', N'358c295a-2b62-4dac-9949-0b0a1212422c')
GO
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1RXMj3tRalU3bJRbHtulXqBHqYuXvpW6I', N'8af7b29a-fbf9-469c-ec54-08db26ca2f8c')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230317092602_init', N'7.0.3')
GO
