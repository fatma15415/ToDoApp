# To-Do App

تطبيق بسيط لإدارة المهام باستخدام ASP.NET Core Web API وSQL Server.

---

## كيفية تشغيل المشروع

- افتح المشروع باستخدام Visual Studio 2022 أو أعلى.
- تأكد من أن SQL Server يعمل على جهازك.
- تأكد من إعداد الاتصال بقاعدة البيانات في `appsettings.json`:
  ```json
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=TodoAppDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
افتح الـ Terminal أو Package Manager Console داخل Visual Studio وشغّل:


dotnet ef database update
أي متطلبات الإعداد
.NET 8 SDK

Visual Studio 2022 أو أحدث

SQL Server

Entity Framework Core Tools

إعداد الاتصال الصحيح بقاعدة البيانات في appsettings.json

ما تمكنت من إكماله
إنشاء تطبيق كامل لإدارة مهام To-Do باستخدام ASP.NET Core MVC.

تنفيذ العمليات الأساسية (إضافة - تعديل - حذف - عرض) باستخدام MVC وEF Core.

استخدام Entity Framework Core وربطه بـ SQL Server.

إعداد قاعدة البيانات من خلال Migrations وتشغيلها تلقائيًا.

تصميم واجهة مستخدم بسيطة باستخدام Razor Views.

تنظيم المشروع باستخدام طبقات منفصلة (Controllers )
