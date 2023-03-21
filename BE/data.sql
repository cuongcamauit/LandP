USE [LandP]

---Pass: Admin.123, Ak.123
GO
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1f316f05-8e6b-41c9-abda-7d6b658c7741', N'User3', CAST(N'2002-08-01T00:00:00.0000000' AS DateTime2), N'2051120209@ut.edu.vn', N'2051120209@UT.EDU.VN', N'2051120209@ut.edu.vn', N'2051120209@UT.EDU.VN', 1, N'AQAAAAEAACcQAAAAEF9/E4hNAO3iiHSofcFlrfQUMTh6sOaYxj9LnvdlfvvjJUv0q3JbagaSNpjhf2k4zQ==', N'ZEZXNSK2P5VATY7KBK2YVZVSQXTG2BSX', N'09c974ac-3f5a-4500-99f4-ce9c72811092', N'09452069221', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'57ffb9cf-899f-4582-acd2-6e339bbf61f4', N'User2', CAST(N'2002-08-01T00:00:00.0000000' AS DateTime2), N'cuongcamauit@gmail.com', N'CUONGCAMAUIT@GMAIL.COM', N'cuongcamauit@gmail.com', N'CUONGCAMAUIT@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEKNZK//yTJAKtJCva3E8omvac4HjEsY+ascSO71NZCi/DL69Symn5GjA3e02jNw5MA==', N'PXBWWWNWCCVMGJMOVSPYU5KKZUPAAJ7D', N'4bd665a3-ad20-4dc8-91e3-7ed6b5c42c7a', N'09452069221', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'602a8a9f-3feb-493d-a433-058b0ca7397a', N'Admin1', CAST(N'2002-12-01T00:00:00.0000000' AS DateTime2), N'admin@landp.com', N'ADMIN@LANDP.COM', N'admin@landp.com', N'ADMIN@LANDP.COM', 0, N'AQAAAAEAACcQAAAAEFgP7uCz5gWfhVLqRaqFGJR4BwwgY3nCucdyXFRGdNpTPu5+VTDX931D9ag9B3TNmg==', N'TR5RXELVQSLNRRNNAGTT5NO3KDERAIG3', N'4d932272-5844-4e18-9575-825a7113e5bd', N'0987654321', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'User1', CAST(N'2002-12-01T00:00:00.0000000' AS DateTime2), N'danhitclub@gmail.com', N'DANHITCLUB@GMAIL.COM', N'danhitclub@gmail.com', N'DANHITCLUB@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECVVLGCw+WCnT6lK8Z7QvxgsNghLED1RYLxXiX10lbS+lK7gGdia1wXLOcBoO/p8Ew==', N'FT73EJAWFY6II3D7W6IKBBPVX2YF4ESG', N'248ec62f-4377-4406-aaf3-10adbd14b1a4', N'0123456', 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'c9aad3b4-36d8-4a5a-892e-08db28edd5e8', N'Ca Mau', N'Tp Ca Mau', N'8', N'5', N'a2c9e56f-97db-4b81-8a13-3803e4b5be88')
GO
INSERT [dbo].[Orders] ([Id], [Status], [Date], [isPaid], [Total], [CustomerId], [AddressId]) VALUES (N'7f1b03ee-47dc-4f38-3ae7-08db28edee9e', N'New', CAST(N'2023-03-20T09:50:57.8747772' AS DateTime2), 1, 62360000000, N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'c9aad3b4-36d8-4a5a-892e-08db28edd5e8')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'73573d18-516c-443c-9750-7bca17c20829', N'Admin', N'Admin', N'1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd1ecff08-8f07-4f51-8497-02fe45f9533d', N'User', N'User', N'2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e12bf61f-1511-4361-8e45-3e96397c1872', N'SuperAdmin', N'SuperAdmin', N'0')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'602a8a9f-3feb-493d-a433-058b0ca7397a', N'73573d18-516c-443c-9750-7bca17c20829')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1f316f05-8e6b-41c9-abda-7d6b658c7741', N'd1ecff08-8f07-4f51-8497-02fe45f9533d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57ffb9cf-899f-4582-acd2-6e339bbf61f4', N'd1ecff08-8f07-4f51-8497-02fe45f9533d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'd1ecff08-8f07-4f51-8497-02fe45f9533d')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'2ef43281-9c42-466e-ad66-483ff6f46326', N'Samsung', N'A branch from korea', N'https://drive.google.com/uc?export=view&id=1JrfIHh1Fi9aM66IMLd2jdZwurx1As6x0')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'36326612-2d44-446f-87cd-d060d14237a6', N'Apple', N'A branch from Ameria', N'https://drive.google.com/uc?export=view&id=1DfzKYG8dsu0C0tNK_5U8GNBM3IE92fsz')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'3f8d98cb-a695-4334-bec2-09008670c39a', N'Laptop', N'A smart device', N'https://drive.google.com/uc?export=view&id=15Lo6BabMJo7m9p-VSve4kls1pG2VA1AN')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'Smartphone', N'A smart device', N'https://drive.google.com/uc?export=view&id=1VPowiqiVfyuL7Pzntp1mqJV748v34zfb')
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [PercentSale], [AverageRating], [ReviewQuantity], [SoldQuantity], [CategoryId], [BrandId]) VALUES (N'bb4c851f-d618-4dee-1bf8-08db29e27c02', N'Samsung Galaxy A14', N'Màn hình:

PLS TFT LCD6.6"Full HD+
Hệ điều hành:

Android 12
Camera sau:

Chính 50 MP & Phụ 5 MP, 2 MP, 2 MP
Camera trước:

8 MP
Chip:

Exynos 850
RAM:

4 GB
Dung lượng lưu trữ:

128 GB
SIM:

2 Nano SIMHỗ trợ 4G
Pin, Sạc:

5000 mAh15 W', 4190000, N'https://drive.google.com/uc?export=view&id=1iqeezIpD3F7OjhMYtYsihMI7jEh2ofZw', N'1l8-2tGS6ZQISMFindI7G25BCwL5vMVQE', N'Unit', 100, 2, 0, 0, 0, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'2ef43281-9c42-466e-ad66-483ff6f46326')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [PercentSale], [AverageRating], [ReviewQuantity], [SoldQuantity], [CategoryId], [BrandId]) VALUES (N'257c3301-487b-4c18-bc3d-21ffb71a4d43', N'Iphone 12', N'Màn hình:

OLED6.1"Super Retina XDR
Hệ điều hành:

iOS 15`
Camera sau:

2 camera 12 MP
Camera trước:

12 MP
Chip:

Apple A14 Bionic
RAM:

4 GB
Dung lượng lưu trữ:

64 GB
SIM:

1 Nano SIM & 1 eSIMHỗ trợ 5G
Pin, Sạc:

2815 mAh20 W', 15590000, N'https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By', N'1b9JWfgUruHr6j3U3XalWbAD2UO329_6X', N'Unit', 43, 20, 0, 0, 0, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [PercentSale], [AverageRating], [ReviewQuantity], [SoldQuantity], [CategoryId], [BrandId]) VALUES (N'd01f7780-5cdd-4ff0-b6db-947a1f3d3f04', N'Samsung Galaxy A23', N'Màn hình:

PLS TFT LCD6.6"Full HD+
Hệ điều hành:

Android 12
Camera sau:

Chính 50 MP & Phụ 5 MP, 2 MP, 2 MP
Camera trước:

8 MP
Chip:

Snapdragon 680
RAM:

4 GB
Dung lượng lưu trữ:

128 GB
SIM:

2 Nano SIMHỗ trợ 4G
Pin, Sạc:

5000 mAh25 W', 4990000, N'https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL', N'12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn', N'Unit', 100, 0, 0, 0, 0, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'2ef43281-9c42-466e-ad66-483ff6f46326')
GO
INSERT [dbo].[Views] ([CustomerId], [ProductId], [Date]) VALUES (N'57ffb9cf-899f-4582-acd2-6e339bbf61f4', N'bb4c851f-d618-4dee-1bf8-08db29e27c02', CAST(N'2023-03-21T15:03:35.7742242' AS DateTime2))
INSERT [dbo].[Views] ([CustomerId], [ProductId], [Date]) VALUES (N'57ffb9cf-899f-4582-acd2-6e339bbf61f4', N'257c3301-487b-4c18-bc3d-21ffb71a4d43', CAST(N'2023-03-21T15:02:58.3268575' AS DateTime2))
INSERT [dbo].[Views] ([CustomerId], [ProductId], [Date]) VALUES (N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'bb4c851f-d618-4dee-1bf8-08db29e27c02', CAST(N'2023-03-21T15:04:32.8854659' AS DateTime2))
INSERT [dbo].[Views] ([CustomerId], [ProductId], [Date]) VALUES (N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'257c3301-487b-4c18-bc3d-21ffb71a4d43', CAST(N'2023-03-21T15:04:48.1898853' AS DateTime2))
INSERT [dbo].[Views] ([CustomerId], [ProductId], [Date]) VALUES (N'a2c9e56f-97db-4b81-8a13-3803e4b5be88', N'd01f7780-5cdd-4ff0-b6db-947a1f3d3f04', CAST(N'2023-03-21T15:05:45.0323771' AS DateTime2))
GO
INSERT [dbo].[HistoryStatuses] ([Id], [Status], [Date], [OrderId]) VALUES (N'ef7dd03e-2bd2-4437-985e-08db28edeeab', N'New', CAST(N'2023-03-20T09:50:57.9610372' AS DateTime2), N'7f1b03ee-47dc-4f38-3ae7-08db28edee9e')
GO
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [PercentSale]) VALUES (N'7f1b03ee-47dc-4f38-3ae7-08db28edee9e', N'257c3301-487b-4c18-bc3d-21ffb71a4d43', 7, 15590000, 20)
GO
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1DeA5LM1HQsUEb9tXUHEg27fWqKenJJDG', N'257c3301-487b-4c18-bc3d-21ffb71a4d43')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1g7NLy-NZE9OTZhH0xctgVXONMNjHpQ4V', N'257c3301-487b-4c18-bc3d-21ffb71a4d43')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1JgLvP6rxTkkkmdWG7RhyqB4nMnaktLE6', N'257c3301-487b-4c18-bc3d-21ffb71a4d43')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1JO-t8NpCi9qb9Jx8pmXbdHMvPg8LQAg3', N'257c3301-487b-4c18-bc3d-21ffb71a4d43')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1IzG911rHzKN2p51Ite3JZqDV1FonTt4d', N'd01f7780-5cdd-4ff0-b6db-947a1f3d3f04')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230320013516_init', N'7.0.3')
GO
