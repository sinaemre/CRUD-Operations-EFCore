using CRUD_Operations.Infrastructure.Context;
using CRUD_Operations.Models.Concrete;
#region Create

//using (var db = new AppDbContext())
//{
//    List<Category> categories = new List<Category>()
//    {
//        new Category
//        {
//            Name = "Box Eldiveni",
//            Description = "Evarlast"
//        },
//        new Category
//        {
//            Name = "Manav",
//            Description = "Meyve - Sebze Ürünleri"
//        },
//        new Category
//        {
//            Name = "Teknoloji",
//            Description = "Teknolojik Aletler"
//        },
//        new Category
//        {
//            Name = "Şarküteri",
//            Description = "Süt Ürünleri"
//        },
//        new Category
//        {
//            Name = "Kasap",
//            Description = "Et-Tavuk Ürünleri"
//        }
//    };

//    foreach (var category in categories)
//    {
//        db.Categories.Add(category);
//        if (db.SaveChanges() > 0)
//        {
//            Console.WriteLine($"{category.Name} kategorisi {category.CreatedDate} tarihinde eklendi!");
//        }
//        else
//        {
//            Console.WriteLine("Kategori eklenirken bir hata oluştu!");
//        }
//    }
//}





#endregion

#region Read
//using (var db = new AppDbContext())
//{
//    var categories = db.Categories.Where(x => x.Status != CRUD_Operations.Models.Abstract.Status.Passive)
//                                  .Select(x => new 
//                                  {
//                                      x.Id,
//                                      x.Name, 
//                                      x.Description,
//                                      x.CreatedDate,
//                                      x.Status
//                                  })
//                                  .ToList();

//	foreach (var category in categories)
//	{
//        Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEklenme Tarihi: {category.CreatedDate}\nDurum: {category.Status}\n===============");
//    }
//}
#endregion

#region Update
//using (var db = new AppDbContext())
//{
//    var category = db.Categories.FirstOrDefault(x => x.Id == 3);

//    category.Name = "Değiştirilmiş Kategori";
//    category.Description = "Değiştirilmiş Açıklama";
//    category.UpdatedDate = DateTime.Now;
//    category.Status = CRUD_Operations.Models.Abstract.Status.Modified;

//    db.Categories.Update(category);

//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine("Kategori güncellendi!");
//    }
//    else
//    {
//        Console.WriteLine("Kategori güncellenirken bir hata oluştu!");
//    }
//}
#endregion

#region Delete
//using (var db = new AppDbContext())
//{
//    var deleteCategory = db.Categories.FirstOrDefault(x => x.Id == 3);

//    deleteCategory.DeletedDate = DateTime.Now;
//    deleteCategory.Status = CRUD_Operations.Models.Abstract.Status.Passive;

//    db.Categories.Update(deleteCategory);

//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine("Kategori silindi!");
//    }
//    else
//    {
//        Console.WriteLine("Kategori silinemedi!");
//    }

//    var categories = db.Categories.Where(x => x.Status != CRUD_Operations.Models.Abstract.Status.Passive)
//                                  .Select(x => new
//                                  {
//                                      x.Id,
//                                      x.Name,
//                                      x.Description,
//                                      x.CreatedDate,
//                                      x.Status
//                                  })
//                                  .ToList();

//    foreach (var category in categories)
//    {
//        Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEklenme Tarihi: {category.CreatedDate}\nDurum: {category.Status}\n===============");
//    }

//}


#endregion

#region Examples
//Kullanıcıdan kategori adı ve açıklaması alıp database'e kaydedelim.
//Console.Write("Lütfen kategori adı giriniz: ");
//string categoryName = Console.ReadLine();
//Console.Write("Lütfen kategori açıklaması giriniz: ");
//string categoryDescription = Console.ReadLine();

//using (var db = new AppDbContext())
//{
//    var category = new Category
//    {
//        Name = categoryName,
//        Description = categoryDescription
//    };

//    db.Categories.Add(category);

//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine($"\n{category.Name} kategorisi sisteme kaydedilmiştir.");
//    }
//    else
//    {
//        Console.WriteLine("Sisteme kaydedilemedi!");
//    }
//}

//Kullanıcıdan alınan kategori adına göre kategoriyi gösterelim.
//Console.Write("Lütfen kategori adı giriniz: ");
//string categoryName = Console.ReadLine();
//Console.WriteLine("Kategori Bilgileri");

//using (var db = new AppDbContext())
//{
//    var category = db.Categories.FirstOrDefault(x => x.Name == categoryName && x.Status != CRUD_Operations.Models.Abstract.Status.Passive);
//	if (category is not null)
//	{
//        Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEklenme Tarihi: {category.CreatedDate}");
//    }
//	else
//	{
//        Console.WriteLine("Bu isimde bir kategori yoktur!");
//    }
//}

//Kullanıcının girdiği id bilgisine göre güncelleme yapmasını sağlayalım.
//try
//{
//    Console.Write("Güncellemek istediğiniz kategori ID'sini giriniz: ");
//    int id = Convert.ToInt32(Console.ReadLine());
//	using (var db = new AppDbContext())
//	{
//		var category = db.Categories.FirstOrDefault(x => x.Id == id);
//		if (category != null)
//		{
//            Console.WriteLine($"Yeni kategori adı giriniz(Şuan ki adı: {category.Name})");
//			string newCategoryName = Console.ReadLine();
//            Console.WriteLine($"Yeni kategori açıklaması giriniz(Şuan ki açıklama: {category.Description})");
//            string newCategoryDescription = Console.ReadLine();

//			category.Name = newCategoryName;
//			category.Description = newCategoryDescription;

//			category.UpdatedDate = DateTime.Now;
//			category.Status = CRUD_Operations.Models.Abstract.Status.Modified;
//			db.Categories.Update(category);

//			if (db.SaveChanges() > 0)
//			{
//                Console.WriteLine("Kategoriniz güncellenmiştir. Yeni kategori bilgileri: ");
//				var newCategory = db.Categories.FirstOrDefault(x => x.Id == category.Id);
//                Console.WriteLine($"Id: {newCategory.Id}\nAd: {newCategory.Name}\nAçıklama: {newCategory.Description}\nEklenme Tarihi: {newCategory.CreatedDate}\nGüncellenme Tarihi: {newCategory.UpdatedDate}\nDurum: {newCategory.Status}");
//            }
//			else
//			{
//                Console.WriteLine("Güncelleme sırasında hata oluştu!");
//            }

//        }
//		else
//		{
//            Console.WriteLine("Girdiğiniz ID değerine sahip bir kategori bulunamadı!");
//        }
//	}
//}
//catch (FormatException)
//{
//    Console.WriteLine("Lütfen id değeri için bir sayı giriniz!");
//}


//Kullanıcıdan aldığımız kategori adına sahip kategoriyi silelim.
Console.Write("Silmek istediğiniz kategori adını giriniz: ");
string categoryName = Console.ReadLine();

using (var db = new AppDbContext())
{
    var category = db.Categories.FirstOrDefault(x => x.Name == categoryName && x.Status != CRUD_Operations.Models.Abstract.Status.Passive);
	if (category is not null)
	{
		//Database'den direk siler.
		//db.Categories.Remove(category);
		category.DeletedDate = DateTime.Now;
		category.Status = CRUD_Operations.Models.Abstract.Status.Passive;
		db.Categories.Update(category);

		if (db.SaveChanges() > 0)
		{
            Console.WriteLine("Kategori silinmiştir!");
        }
		else
		{
            Console.WriteLine("Kategori silinirken bir hata oluştu!");
        }
	}
	else 
	{
		Console.WriteLine("Böyle bir kategori sistemde kayıtlı değildir!"); 
	}
}
#endregion