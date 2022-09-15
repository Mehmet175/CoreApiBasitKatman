# CoreApiBasitKatman

Package Manager Console : 
Scaffold-DbContext "Data Source={server_ip};Initial Catalog={database_name};Persist Security Info=True;User ID={user_name};Password={userPassword}" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EF

EF = {çıkarılacak yol}

Değişiklik yapıldığında zorla üzerine yazmak için :
Scaffold-DbContext "Data Source={server_ip};Initial Catalog={database_name};Persist Security Info=True;User ID={user_name};Password={userPassword}" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EF -f

Nuget Packages :
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
